namespace Infra.Models
{
    public class CheckinData
    {
        public string keycode { get; set; }
        public DateTime date { get; set; }
        public string personTitle { get; set; }
        public int temp { get; set; }
        public string action_type { get; set; }
        public string detected_image_url { get; set; }
        public string placeID { get; set; }
        public string deviceID { get; set; }
        public string deviceName { get; set; }
        public string personName { get; set; }
        public string aliasID { get; set; }
        public string data_type { get; set; }
        public string personID { get; set; }
        public string id { get; set; }
        public long time { get; set; }
        public string personType { get; set; }
        public string placeName { get; set; }
        public string hash { get; set; }
        public string mask { get; set; }
    }
    public enum TrangThai
    {
        INSERTED = 1,
        ERROR = 2,
    }

    public class CheckinFail
    {
        public string id { get; set; }
        public DateTime date { get; set; }
        public string aliasID { get; set; }
        public string deviceName { get; set; }
        public TrangThai status { get; set; }
        public int errorCount { get; set; }
    }
}