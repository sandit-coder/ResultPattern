public class Result
{
    public string? ResponseText { get; }

    public string? Error { get; }

    public int StatusCode { get; }

    public bool IsSuccess { get; }

    private Result(bool isSuccess, string error, int statusCode, string? reponseText = null)
    {
        ResponseText = reponseText;
        StatusCode = statusCode;
        Error = error;
        IsSuccess = isSuccess;
    }

    public static Result Success(int statusCode, string? responseText = null)
        => new(true, null!, statusCode, responseText);

    public static Result Failure(string error, int statusCode)
        => new(false, error, statusCode);
}
