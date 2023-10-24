using svInsertData.Models;
using Microsoft.EntityFrameworkCore;
namespace svInsertData
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _config;
        private readonly FallbackDbContext _fallbackContext;
        private readonly ApplicationDbContext _mainContext;


        public Worker(ILogger<Worker> logger, FallbackDbContext fallbackContext, ApplicationDbContext mainContext, IConfiguration config)
        {
            _logger = logger;
            _config = config;
            _fallbackContext = fallbackContext;
            _mainContext = mainContext;

        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int delay = _config.GetValue<int>("DelayService");
            if (delay <= 0)
            {
                delay = 30;
            }

            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(delay * 1000, stoppingToken);
                await DoWork();
            }
        }

        private async Task DoWork()
        {
            List<CheckinFail> checkInFail = _fallbackContext.CheckinData.Where(x => x.status == TrangThai.ERROR && x.errorCount < 5).ToList();

            for (int i = 0; i < checkInFail.Count; i++)
            {
                CheckinFail data = checkInFail[i];
                int rows_effected = await _mainContext.Database.ExecuteSqlInterpolatedAsync(
                       $"EXEC Ins_H0_EmployeeTimeBillByUserIdAndTime @UserId={data.aliasID},@InputTime={data.date},@Machine={data.deviceName}"
                   );
                if (rows_effected > 0)
                {
                    data.status = TrangThai.INSERTED;
                }
                else
                {
                    data.status = TrangThai.ERROR;
                    data.errorCount += 1;
                }
                _fallbackContext.CheckinData.Update(data);
            }
            _fallbackContext.SaveChanges();
            _mainContext.SaveChanges();
        }
    }
}