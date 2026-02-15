using Hamfer.WebApi.Core.Errors;

namespace Hamfer.WebApi.Core;

public class WebApiResult
{
  const string MESSAGE_SUCCEED_DEFAULT = "اجرای درخواست با موفقیت پایان پذیرفت.";
  const string MESSAGE_FAILED_DEFAULT = "در اجرای درخواست خطایی رخ داده است!";

  public readonly int statusCode;
  public readonly string contentType;
  
  public string? message { get; set; }
  public dynamic? content { get; set; }
  public bool succeed => statusCode < 400;

  public WebApiResult(
    dynamic? content,
    string? message = null,
    WebApiStatusCode statusCode = WebApiStatusCode.Ok,
    WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON,
    string? charSet = null
  )
  {
    this.message = message;
    this.content = content;
    this.statusCode = (int)statusCode;
    this.contentType = prepareContentType(contentType, charSet);
  }

  public WebApiResult(dynamic? content, string? message, int statusCode, string contentType, string? charSet = null)
  {
    this.message = message;
    this.content = content;
    this.statusCode = statusCode;
    this.contentType = prepareContentType(contentType, charSet);
  }

  public object getContent()
  {
    this.message ??= (this.succeed ? MESSAGE_SUCCEED_DEFAULT : MESSAGE_FAILED_DEFAULT);
    
    return new
    {
      this.succeed,
      this.message,
      this.content,
    };
  }

  private string prepareContentType(string contentType, string? charSet = null)
  {
    return WebApiContentType.AddCharSet(contentType, charSet);
  }

  private string prepareContentType(WebApiContentTypeEnum contentType, string? charSet = null)
  {
    string contentTypeString = contentType.ToStringContentType();
    return prepareContentType(contentTypeString, charSet);
  }

  #region static Results 
  public static WebApiResult Inform(dynamic content, WebApiStatusCode statusCode = WebApiStatusCode._100_Continue, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.Informational, content, statusCode, contentType, charSet);

  public static WebApiResult Success(dynamic content, WebApiStatusCode statusCode = WebApiStatusCode._200_OK, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.Successful, content, statusCode, contentType, charSet);
  public static WebApiResult Ok(dynamic content, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.Successful, content, WebApiStatusCode._200_OK, contentType, charSet);
  public static WebApiResult Created(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.TEXT, string? charSet = null)
    => Handle(WebApiStatusCodeCategory.Successful, content, WebApiStatusCode._201_Created, contentType, charSet);
  public static WebApiResult Accepted(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.TEXT, string? charSet = null)
    => Handle(WebApiStatusCodeCategory.Successful, content, WebApiStatusCode._202_Accepted, contentType, charSet);
  public static WebApiResult NoContent()
    => Handle(WebApiStatusCodeCategory.Successful, null, WebApiStatusCode._204_No_Content, WebApiContentTypeEnum.TEXT, null);

  public static WebApiResult Redirect(dynamic? content = null, WebApiStatusCode statusCode = WebApiStatusCode._307_Temporary_Redirect, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.Redirection, content, statusCode, contentType, charSet);
  public static WebApiResult PermanentRedirect(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.Redirection, content, WebApiStatusCode._308_Permanent_Redirect, contentType, charSet);
  public static WebApiResult MovedPermanently(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.Redirection, content, WebApiStatusCode._301_Moved_Permanently, contentType, charSet);

  public static WebApiResult ClientError(dynamic? content = null, WebApiStatusCode statusCode = WebApiStatusCode._400_Bad_Request, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.ClientError, content, statusCode, contentType, charSet);
  public static WebApiResult BadRequest(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.ClientError, content, WebApiStatusCode._400_Bad_Request, contentType, charSet);
  public static WebApiResult Unauthorized(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.ClientError, content, WebApiStatusCode._401_Unauthorized, contentType, charSet);
  public static WebApiResult Forbidden(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.ClientError, content, WebApiStatusCode._403_Forbidden, contentType, charSet);
  public static WebApiResult NotFound(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.ClientError, content, WebApiStatusCode._404_Not_Found, contentType, charSet);
  public static WebApiResult MethodNotAllowed(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.ClientError, content, WebApiStatusCode._405_Method_Not_Allowed, contentType, charSet);
  public static WebApiResult NotAcceptable(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.ClientError, content, WebApiStatusCode._406_Not_Acceptable, contentType, charSet);
  public static WebApiResult TooManyRequests(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.ClientError, content, WebApiStatusCode._429_Too_Many_Requests, contentType, charSet);

  public static WebApiResult Error(dynamic content, WebApiStatusCode statusCode = WebApiStatusCode._500_Internal_Server_Error, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.ServerError, content, statusCode, contentType, charSet);
  public static WebApiResult NotImplemented(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.ServerError, content, WebApiStatusCode._501_Not_Implemented, contentType, charSet);
  public static WebApiResult BadGateway(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.ServerError, content, WebApiStatusCode._502_Bad_Gateway, contentType, charSet);
  public static WebApiResult Unavailable(dynamic? content = null, WebApiContentTypeEnum contentType = WebApiContentTypeEnum.JSON, string? charSet = "utf-8")
    => Handle(WebApiStatusCodeCategory.ServerError, content, WebApiStatusCode._503_Service_Unavailable, contentType, charSet);
  
  private static WebApiResult Handle(WebApiStatusCodeCategory cat, dynamic? content, WebApiStatusCode statusCode, WebApiContentTypeEnum contentType, string? charSet)
  {
    if (statusCode.GetCategory() != cat)
    {
      throw new WebApiInvalidUsageError(statusCode.ToString(), $"{cat} Result");
    }

    string? message = cat switch
    {
      WebApiStatusCodeCategory.Informational => "نیاز است موضوعی به اطلاع رسانده شود!",
      WebApiStatusCodeCategory.Successful => "دریافت و اجرای درخواست با موفقیت پایان پذیرفت.",
      WebApiStatusCodeCategory.Redirection => "نیاز است به آدرس دیگری منتقل شوید!",
      WebApiStatusCodeCategory.ClientError => "در درخواست ارسالی خطایی وجود دارد!",
      WebApiStatusCodeCategory.ServerError => "در زمان اجرای درخواست خطایی رخ داده است!",
      _ => throw new WebApiError("دسته‌بندی کد وضعیت درخواست یافت نشد!", new ArgumentOutOfRangeException(nameof(cat))),
    };

    return new WebApiResult(content, message, statusCode, contentType, charSet);    
  }
  #endregion
}