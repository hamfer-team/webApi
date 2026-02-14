using Microsoft.AspNetCore.Authorization;

namespace Hamfer.WebApi.Server.Models;

public class WebApiAuthorizeAttribute : AuthorizeAttribute
{
  public WebApiAuthorizeAttribute(): base() { }
  public WebApiAuthorizeAttribute(string policy): base(policy) { }
}