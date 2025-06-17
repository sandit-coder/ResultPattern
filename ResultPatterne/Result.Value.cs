public class Result<TValue, TError>
{
    public TValue? Value { get; }

    public TError? Error { get; }

    public int StatusCode { get; }

    public bool IsSuccess { get; }

    private Result(TValue value, int statusCode)
    {
        StatusCode = statusCode;
        Value = value;
        IsSuccess = true;
        Error = default;
    }

    private Result(TError error, int statusCode)
    {
        StatusCode = statusCode;
        Error = error;
        IsSuccess = false;
        Value = default;
    }

    public static Result<TValue, TError> Success(TValue value, int statusCode) => new(value, statusCode);
    public static Result<TValue, TError> Failure(TError error, int statusCode) => new(error, statusCode);
}
