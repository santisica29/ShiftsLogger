namespace ShiftsLogger.Services;

public class ServiceResponse
{
    public bool IsSuccessful { get; set; }
    public string Message { get; set; } = string.Empty;

    public static ServiceResponse Failure(string msg)
    {
        return new ServiceResponse
        {
            IsSuccessful = false,
            Message = msg,
        };
    }

    public static ServiceResponse Success(string msg)
    {
        return new ServiceResponse
        {
            IsSuccessful = true,
            Message = msg,
        };
    }
}

public sealed class ServiceResponse<T> : ServiceResponse
{
    public T? Data { get; set; }

    public static ServiceResponse<T> Success(T? data, string msg)
    {
        return new ServiceResponse<T>
        {
            IsSuccessful = true,
            Message = msg,
            Data = data,
        };
    }

    public static ServiceResponse<T> Failure(string msg)
    {
        return new ServiceResponse<T>
        {
            IsSuccessful = false,
            Message = msg,
        };
    }
}

