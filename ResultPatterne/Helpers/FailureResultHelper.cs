namespace ResultPatterne.Helpers;

public static class FailureResultHelper
{
	public static AppError UnknownError()
		=> new AppError("����������� ������", StatusCodes.Status500InternalServerError);
}