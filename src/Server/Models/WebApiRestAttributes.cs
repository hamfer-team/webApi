using Microsoft.AspNetCore.Mvc;

namespace Hamfer.WebApi.Server.Models;

public sealed class WebApiGetAttribute: HttpGetAttribute
{
  public WebApiGetAttribute() { }
  public WebApiGetAttribute(string template): base(template) { }
}

public sealed class WebApiPostAttribute: HttpPostAttribute
{
  public WebApiPostAttribute() { }
  public WebApiPostAttribute(string template): base(template) { }
}

public sealed class WebApiPutAttribute: HttpPutAttribute
{
  public WebApiPutAttribute() { }
  public WebApiPutAttribute(string template): base(template) { }
}

public sealed class WebApiDeleteAttribute: HttpDeleteAttribute
{
  public WebApiDeleteAttribute() { }
  public WebApiDeleteAttribute(string template): base(template) { }
}