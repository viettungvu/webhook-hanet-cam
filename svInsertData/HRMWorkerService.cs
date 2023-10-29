using svInsertData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

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
                    SqliteDbContext sqliteDbContext = scope.ServiceProvider.GetRequiredService<SqliteDbContext>();
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

        private async Task DoWork(SqliteDbContext sqliteDbContext, HRMDbContext hrmDbContext)
        {
            try
            {
                List<CheckinFail> checkInFail = sqliteDbContext.CheckinData.Where(x => x.status == TrangThai.ERROR && x.errorCount < 5).ToList();

                for (int i = 0; i < checkInFail.Count; i++)
                {
                    CheckinFail data = checkInFail[i];
                    int rows_effected = await hrmDbContext.Database.ExecuteSqlInterpolatedAsync(
                           $"EXEC Ins_H0_EmployeeTimeBillByUserIdAndTime @UserId={data.aliasID},@InputTime={data.date},@Machine={data.deviceName}"
                       );

                    ///N?u insert thành công thì ?ánh tr?ng thái là inserted, còn n?u v?n l?i thì ?ánh tr?ng thái ERROR, ??ng th?i t?ng s? l?n l?i lên 1.
                    ///Khi service ch?y thì ch? l?y nh?ng b?n ghi có tr?ng thái ERROR + s? l?n l?i nh? h?n 5 (dòng 67). M?c ?ích ?? tránh insert trùng nh?ng b?n ghi ?ã insert thành công, ho?c insert l?i quá nhi?u l?n v?n insert l?i.
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