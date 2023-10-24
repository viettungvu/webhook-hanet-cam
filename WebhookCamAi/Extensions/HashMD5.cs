using System.Security.Cryptography;
using System.Text;

namespace WebhookCamAi.Extensions
{
    public static class HashMD5{
        public static string ToMD5(string s)
        {
            using var md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(s));

            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}