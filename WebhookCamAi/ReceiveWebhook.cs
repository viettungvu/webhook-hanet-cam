using WebhookCamAi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;
using WebhookCamAi.Extensions;
using Newtonsoft.Json.Bson;

namespace WebhookCamAi
{
    public class ReceiveWebhook : IReceiveWebhook
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly FallbackDbContext _fallbackContext;

        public ReceiveWebhook(ApplicationDbContext mainContext, FallbackDbContext fallbackDbContext, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = mainContext;
            _fallbackContext = fallbackDbContext;
        }

        public async Task<string> Request(string requestBody)
        {
            string jsonFormatted = JValue.Parse(requestBody).ToString(Formatting.Indented);
            CheckinData data = JsonConvert.DeserializeObject<CheckinData>(jsonFormatted);

            // string str = _configuration.GetValue<string>("ClientSecrets:Value").ToString() + data.id;
            // string strMD5 = HashMD5.ToMD5(str);
            // Console.WriteLine($"Hash string: {HashMD5.ToMD5(str)}"); //&& strMD5 == data.hash

            if (data != null)
            {
                try
                {
                    if (data.data_type == "log")
                    {

                        int rows_effected = await _context.Database.ExecuteSqlInterpolatedAsync(
                            $"EXEC Ins_H0_EmployeeTimeBillByUserIdAndTime @UserId={data.aliasID},@InputTime={data.date},@Machine={data.deviceName}"
                        );
                        if (rows_effected > 0)
                        {
                            return "{\"message\" : \"Insert data success!\"}";
                        }
                        else
                        {
                            try
                            {
                                //if insert failed=> stored data to file for services excute later
                                _fallbackContext.CheckinData.Add(new CheckinFail()
                                {
                                    id = Guid.NewGuid().ToString(),
                                    deviceName = data.deviceName,
                                    aliasID = data.aliasID,
                                    date = data.date,
                                    errorCount = 0,
                                    status = TrangThai.ERROR,
                                });
                                _fallbackContext.SaveChanges();
                                //Task t = Task.Run(() =>
                                // {
                                //     var obj = new
                                //     {
                                //         aliasID = data.aliasID,
                                //         date = data.date,
                                //         deviceName = data.deviceName
                                //     };
                                //     string fileName = string.Format("{0}_{1}.txt", data.aliasID, data.date.ToString("yyyyMMdd"));
                                //     writeToFile(fileName, obj);
                                // });
                            }
                            catch (Exception)
                            {

                            }
                            return "{\"message\" : \"Insert data fail!\"}";
                        }
                    }
                    else
                    {
                        return "{\"message\" : \"Insert data error !\"}";
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }

            }
            return "{\"message\" : \"Checkin Failed !\"}";
        }
        private void writeToFile(string fileName, object data)
        {
            string backupFolder = _configuration.GetSection("BackupFile:Folder").Value;
            //string backupFileName = _configuration.GetSection("BackupFile:FileName").Value;
            if (!string.IsNullOrWhiteSpace(backupFolder))
            {
                try
                {
                    if (!Directory.Exists(backupFolder))
                    {
                        Directory.CreateDirectory(backupFolder);
                    }
                    if (data != null)
                    {
                        string json = JsonConvert.SerializeObject(data);
                        string fullPath = Path.Combine(backupFolder, fileName);
                        System.IO.File.WriteAllText(fullPath, json);
                    }
                }
                catch (Exception)
                {
                }
            }
        }
    }
}