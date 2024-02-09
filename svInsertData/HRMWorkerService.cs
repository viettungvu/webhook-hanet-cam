using Microsoft.EntityFrameworkCore;
using Infra.EF;
using Infra.Models;

namespace svInsertData
{
    public class HRMWorkerService : BackgroundService
    {
        private readonly ILogger<HRMWorkerService> _logger;
        private readonly IConfiguration _config;

        private readonly IServiceProvider _serviceProvider;

        public HRMWorkerService(ILogger<HRMWorkerService> logger, IConfiguration config, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _config = config;
            _serviceProvider = serviceProvider;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{nameof(HRMWorkerService)} started at ${DateTimeOffset.Now}");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{nameof(HRMWorkerService)} stopped at {DateTimeOffset.Now}");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation($"{nameof(HRMWorkerService)} is working.");
            try
            {
                int delay = _config.GetValue<int>("DelayService");
                if (delay <= 0)
                {
                    delay = 30;
                }
                using (IServiceScope scope = _serviceProvider.CreateScope())
                {
                    HRMLogDbContext sqliteDbContext = scope.ServiceProvider.GetRequiredService<HRMLogDbContext>();
                    HRMDbContext hrmDbContext = scope.ServiceProvider.GetRequiredService<HRMDbContext>();
                    while (!stoppingToken.IsCancellationRequested)
                    {
                        _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                        await Task.Delay(delay * 1000, stoppingToken);
                        await DoWork(sqliteDbContext, hrmDbContext);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }

        private async Task DoWork(HRMLogDbContext sqliteDbContext, HRMDbContext hrmDbContext)
        {
            try
            {
                int maximumError = _config.GetValue<int>("MaximumError");

                List<CheckinFail> checkInFail = sqliteDbContext.CheckinData.Where(x => x.status == TrangThai.ERROR && x.errorCount < maximumError).ToList();

                for (int i = 0; i < checkInFail.Count; i++)
                {
                    CheckinFail data = checkInFail[i];
                    int rows_effected = await hrmDbContext.Database.ExecuteSqlInterpolatedAsync(
                           $"EXEC Ins_H0_EmployeeTimeBillByUserIdAndTime @UserId={data.aliasID},@InputTime={data.date},@Machine={data.deviceName}"
                       );

                    ///N?u insert th�nh c�ng th� ?�nh tr?ng th�i l� inserted, c�n n?u v?n l?i th� ?�nh tr?ng th�i ERROR, ??ng th?i t?ng s? l?n l?i l�n 1.
                    ///Khi service ch?y th� ch? l?y nh?ng b?n ghi c� tr?ng th�i ERROR + s? l?n l?i nh? h?n 5 (d�ng 67). M?c ?�ch ?? tr�nh insert tr�ng nh?ng b?n ghi ?� insert th�nh c�ng, ho?c insert l?i qu� nhi?u l?n v?n insert l?i.
                    if (rows_effected > 0)
                    {
                        data.status = TrangThai.INSERTED;
                    }
                    else
                    {
                        data.status = TrangThai.ERROR;
                        data.errorCount += 1;
                    }
                    sqliteDbContext.CheckinData.Update(data);
                }
                sqliteDbContext.SaveChanges();
                hrmDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }
    }
}