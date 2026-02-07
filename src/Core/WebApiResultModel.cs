namespace Hamfer.WebApi.Core;

public class WebApiResultModel
{
  public WebApiStatusCode statusCode { get; set; }
  public dynamic content { get; set; }
  public string contentType { get; set; }

  public WebApiResultModel(dynamic content, WebApiStatusCode statusCode, WebApiContentTypeEnum contentType, string? charSet = null)
  {
    this.content = content;
    this.statusCode = statusCode;
    this.contentType = prepareContentType(contentType, charSet);
  }

  public WebApiResultModel(dynamic content, WebApiStatusCode statusCode, string contentType, string? charSet = null)
  {
    this.content = content;
    this.statusCode = statusCode;
    this.contentType = prepareContentType(contentType, charSet);
  }

  private string prepareContentType(string contentType, string? charSet = null)
  {
    return charSet != null ? $"{contentType}; charset={charSet}" : contentType;
  }

  private string prepareContentType(WebApiContentTypeEnum contentType, string? charSet = null)
  {
    string contentTypeString = contentType.ToString();
    return prepareContentType(contentTypeString, charSet);
  }
}