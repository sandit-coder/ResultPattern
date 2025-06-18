using ResultPattern;

public class Result<TValue>
{
    public TValue? Value { get; }

    public AppError? Error { get; }

    public int StatusCode { get; }

    public bool IsSuccess { get; }

    private Result(TValue value, int statusCode)
    {
        StatusCode = statusCode;
        Value = value;
        IsSuccess = true;
        Error = default;
    }

    private Result(AppError error)
    {
        StatusCode = error.StatusCode;
        Error = error;
        IsSuccess = false;
    }

    public static implicit operator Result<TValue>(AppError error)
       => new(error);

    public static implicit operator Result<TValue>((TValue value, int statusCode) input)
        => new(input.value, input.statusCode);
}
