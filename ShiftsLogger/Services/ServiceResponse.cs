namespace ShiftsLogger.Services;

public class ServiceResponse
{
    public bool IsSuccessful { get; set; }
    public string Message { get; set; } = string.Empty;

}

public sealed class ServiceResponse<T> : ServiceResponse
{
    public T? Data { get; set; }

    public ServiceResponse<T> Success(T? data, string msg)
    {
        return new ServiceResponse<T>
        {
            IsSuccessful = true,
            Message = msg,
            Data = data,
        };
    }

    public ServiceResponse Failure(string msg)
    {
        return new ServiceResponse<T>
        {
            IsSuccessful = false,
            Message = msg,
        };
    }
}

