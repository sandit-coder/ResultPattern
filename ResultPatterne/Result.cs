using Application.Results;

namespace Application.Ressults;

public class Result
{
    public string? ResponseText { get; } 

    public AppError? Error { get; }

    public int StatusCode {  get; }

    public bool IsSuccess { get; }

    private Result(int statusCode, string? reponseText = null)
    {
        ResponseText = reponseText;
        StatusCode = statusCode;
        IsSuccess = true;
    }

    private Result(AppError error) 
    {
        IsSuccess = false;
        StatusCode = error.StatusCode;
        Error = error;
    }

    public static implicit operator Result(AppError error) 
        => new(error);

    public static implicit operator Result(int statusCode)
    => new(statusCode);

    public static implicit operator Result((int statusCode, string? responseText) input) 
        => new(input.statusCode, input.responseText);
}