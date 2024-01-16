namespace SOALTIGADOTNET_MODEL_SERA;

public class ApiResponse<T>
{
    public string Message { get; set; }
    public string TransactionId { get; set; }
    public T Data { get; set; }
}
