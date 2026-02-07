using System.Text.Json;
using Hamfer.WebApi.Core;
using Microsoft.AspNetCore.Mvc;

namespace Hamfer.WebApi.Server.Models;

public class WebApiContentResult : ContentResult, IWebApiActionResult
{
}

public class WebApiTextContentResult : ContentResult, IWebApiActionResult
{
  public WebApiTextContentResult(string content, WebApiStatusCode statusCode)
  {
    this.ContentType = WebApiContentType.TEXT;
    this.Content = content;
    this.StatusCode = (int)statusCode;
  }
}

public class WebApiObjectContentResult<TObject> : ContentResult, IWebApiActionResult
{
  public WebApiObjectContentResult(TObject content, WebApiStatusCode statusCode)
  {
    this.ContentType = WebApiContentType.JSON;
    this.Content = JsonSerializer.Serialize(content);
    this.StatusCode = (int)statusCode;
  }
}