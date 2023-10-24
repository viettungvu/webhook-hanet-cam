using WebhookCamAi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebhookCamAi
{
    public class WebhookReceiver : IReceiveWebhook
    {
        public async Task<string> Request(string requestBody)
        {
            string jsonFormatted = JValue.Parse(requestBody).ToString(Formatting.Indented);  
            //Console.WriteLine(jsonFormatted);

            await Task.Delay(2000);
            return "{\"message\" : \"Thanks! We got your webhook\"}";
        }
    }
}