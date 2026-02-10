using System.Text.Json;
using Hamfer.WebApi.Core;
using Microsoft.AspNetCore.Mvc;

namespace Hamfer.WebApi.Server.Models;

public class WebApiContentResult : ContentResult, IWebApiActionResult
{
}

public class WebApiTextContentResult : ContentResult, IWebApiActionResult
{
  public WebApiTextContentResult(string content, WebApiStatusCode statusCode, string charSet = "utf-8")
  {
    this.ContentType = WebApiContentType.AddCharSet(WebApiContentType.TEXT, charSet);
    this.Content = content;
    this.StatusCode = (int)statusCode;
  }
}

public class WebApiObjectContentResult<TObject> : ContentResult, IWebApiActionResult where TObject: class
{
  public WebApiObjectContentResult(TObject content, WebApiStatusCode statusCode, string charSet = "utf-8")
  {
    this.ContentType = WebApiContentType.AddCharSet(WebApiContentType.JSON, charSet);
    this.Content = JsonSerializer.Serialize(content);
    this.StatusCode = (int)statusCode;
  }
}

public class WebApiJsonContentResult<TContent> : ContentResult, IWebApiActionResult where TContent: class
{
  public WebApiJsonContentResult(TContent content, WebApiStatusCode statusCode, string charSet = "utf-8")
  {
    this.ContentType = WebApiContentType.AddCharSet(WebApiContentType.JSON, charSet);
    this.Content = JsonSerializer.Serialize(content);
    this.StatusCode = (int)statusCode;
  }
}

public class WebApiFileContentResult : FileContentResult, IWebApiActionResult
{
  public WebApiFileContentResult(byte[] fileContent, WebApiContentTypeEnum contentType, string charSet = "utf-8")
    : base(fileContent, contentType.ToStringContentType(charSet))
  {
  }

  public WebApiFileContentResult(string fileName, WebApiContentTypeEnum? contentType = null, string charSet = "utf-8")
    : base(
      File.ReadAllBytes(fileName), 
      contentType?.ToStringContentType(charSet) 
        ?? WebApiContentType.FromFileName(fileName, charSet) 
        ?? WebApiContentType.AddCharSet(WebApiContentType.BINARY, charSet)
    )
  {
  }
}

public class WebApiContentResultStandard : ContentResult, IWebApiActionResult
{
  /// <summary>
  /// API request output should not be valid JavaScript.
  /// This is to protect against a CSRF-like attack. Imagine you have an API: https://example.com/getmysecrets.json
  /// Which returns: {"yoursecrets": [1, 2, 3]}
  ///
  /// An attacker could trick a user into visiting a site overriding the Array or Object constructor, and then containing: 
  ///   <script src="https://example.com/getmysecrets.json"></script>
  ///
  /// This could let them steal the secrets. In modern times, browsers are protected against this kind of attack, but our `]` adds some safety for older browsers.
  /// Adding `]` to the beginning makes sure that the output is a syntax error in JS, so treating it as a JS file will simply crash and fail.
  /// </summary>
  const string RESPONSE_DISPATCH_PREFIX = "]";

  public WebApiContentResultStandard(WebApiResult result, bool useDispatchPrefix = false)
  {
    this.ContentType = result.contentType;
    dynamic? content = result.getContent();
    this.Content = content != null ? (useDispatchPrefix ? RESPONSE_DISPATCH_PREFIX : "") + JsonSerializer.Serialize(content) : null;
    this.StatusCode = result.statusCode;
  }

  public WebApiContentResultStandard(object content, bool useDispatchPrefix = false): this(new WebApiResult(content), useDispatchPrefix)
  {
  }
}