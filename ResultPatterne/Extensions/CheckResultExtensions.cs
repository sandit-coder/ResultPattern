namespace ResultPatterne.Extensions;

public static class CheckResultExtensions
{
    public static Result CheckResult(this Result result)
    {
        if (result.IsSuccess)
            return result;

        return result.Error ?? FailureResultHelper.UnknownError();
    }

    public static Result<TValue> CheckResult<TValue>(this Result<TValue> result)
    {
        if (result.IsSuccess)
            return result;

        return result.Error ?? FailureResultHelper.UnknownError();
    }
}