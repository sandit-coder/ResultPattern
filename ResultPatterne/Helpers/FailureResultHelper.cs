namespace ResultPatterne.Helpers;

public static class FailureResultHelper
{
	public static AppError UnknownError()
		=> new AppError("Неизвестная ошибка", StatusCodes.Status500InternalServerError);
}