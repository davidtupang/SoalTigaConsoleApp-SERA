namespace SOALTIGADOTNET_EFCORE_SERA
{
    internal class ApiResponse<T>
    {
        public string Message { get; set; }
        public string TransactionId { get; set; }
        public int Data { get; set; }
    }
}