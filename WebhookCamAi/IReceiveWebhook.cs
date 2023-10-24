namespace WebhookCamAi
{
    public interface IReceiveWebhook
    {
        Task<string> Request(string requestBody);
    }
}