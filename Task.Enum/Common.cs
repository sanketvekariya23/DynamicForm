namespace Task.Enum
{
    public struct ApiResponse
    {
        public byte Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public string DetailedError { get; set; }
    }
    public enum StatusFlag : byte
    {
        Success = 1,
        Failed = 2
    }
}
