namespace ResultPatterne;

public class Result
{
    public string? ResponseText { get; }

    public AppError? Error { get; }

    public int StatusCode { get; }

    public bool IsSuccess { get; }

    private Result(string? reponseText = null)
    {
        StatusCode = StatusCodes.Status200OK;
        ResponseText = reponseText;
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

    public static implicit operator Result(string? responseText)
        => new(responseText);
}