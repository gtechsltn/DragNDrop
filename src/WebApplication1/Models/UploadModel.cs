namespace WebApplication1.Models
{
    public class ResponseApi
    {
        public string error { get; set; }
        public string newUuid { get; set; }
        public bool success { get; set; }
        public bool preventRetry { get; set; }
        public bool reset { get; set; }
    }
}