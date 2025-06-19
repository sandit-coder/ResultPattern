namespace Application.Results;

public record AppError
{
    public string Message { get; }


    public Object? Details { get; }


    public int StatusCode { get; }


    public AppError(string message, int statusCode, object? details = null)
    {
        Details = details;
        Message = message;
        StatusCode = statusCode;
    }
}
