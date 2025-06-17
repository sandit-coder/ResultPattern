using Microsoft.AspNetCore.Mvc;

namespace Application.Results
{
    public static class ResultExtensions
    {
        public static IActionResult ToActionResult(this Result result)
        {
            return result.IsSuccess
                ? new ObjectResult(new { Message = result.ResponseText }) { StatusCode = result.StatusCode }
                : new ObjectResult(new { Message = result.Error }) { StatusCode = result.StatusCode };
        }

        public static IActionResult ToActionResult<TValue, TError>(this Result<TValue, TError> result)
        {
            return result.IsSuccess
                ? new ObjectResult(result.Value) { StatusCode = result.StatusCode }
                : new ObjectResult(new { Message = result.Error }) { StatusCode = result.StatusCode };
        }
    }
}
