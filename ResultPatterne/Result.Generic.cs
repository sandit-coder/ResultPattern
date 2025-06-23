using Application.Ressults;
using Application.Results;

namespace Application.Ressults;

public class Result<TValue>
{
    public TValue? Value { get; }

    public AppError? Error { get; }
    
    public int StatusCode { get; }

    public string? ResponseText { get; }

    public bool IsSuccess { get; }

    private Result(TValue value, string responseText = null)
    {
        StatusCode = 200 //in Asp.net - StatusCodes.Status200Ok
        ResponseText = responseText;
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

    public static implicit operator Result<TValue>((TValue value, string responseText) input)
        => new(input.value, input.responseText);
}
