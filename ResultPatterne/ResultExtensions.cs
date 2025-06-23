using Application.Ressults;
using Microsoft.AspNetCore.Mvc;

namespace Application.Results
{
    public static class ResultExtensions
    {
        public static IActionResult ToActionResult(this Result result) 
        {
            return result.IsSuccess 
                ? new ObjectResult(new { Message = result.ResponseText }) { StatusCode  = result.StatusCode }
                : new ObjectResult(new { Error = result.Error!.Message, result.Error.Details}) { StatusCode = result.StatusCode };
        }

        public static IActionResult ToActionResult<TValue>(this Result<TValue> result)
        {
            return result.IsSuccess
                ? new ObjectResult(new { result.Value, Message = result.ResponseText }) { StatusCode = result.StatusCode }
                : new ObjectResult(new { Error = result.Error!.Message, result.Error.Details }) { StatusCode = result.Error.StatusCode };
        }
    }
}
