using Hamfer.Kernel.Errors;

namespace Hamfer.WebApi.Core.Errors;

public class WebApiError : ApiError
{
  private const string WEB_API_MESSAGE_DEFAULT = "خطایی در وب ای پی آی رخ داده است!";

  public WebApiError(string? message = WEB_API_MESSAGE_DEFAULT, Exception? innerError = null): base(message, innerError)
  {
  }
}