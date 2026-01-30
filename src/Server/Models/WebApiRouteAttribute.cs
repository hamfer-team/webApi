using Microsoft.AspNetCore.Mvc;

namespace Hamfer.WebApi.Server.Models;

public sealed class WebApiRouteAttribute: RouteAttribute
{
  public WebApiRouteAttribute(): base("{controller}")
  {
  }

  public WebApiRouteAttribute(string template): base(template)
  {
  }
}