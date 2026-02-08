namespace Hamfer.WebApi.Core.Errors;

public class WebApiInvalidUsageError : WebApiError
{
  private const string WEB_API_MESSAGE_DEFAULT = "استفاده نابجا در کد شناسایی شده است!";

  public string used { get; set; }
  public string usedFor { get; set; }

  public WebApiInvalidUsageError(string used, string usedFor, string? message = WEB_API_MESSAGE_DEFAULT, Exception? innerError = null): base(message, innerError)
  {
    this.used = used;
    this.usedFor = usedFor;
  }
}