using Hamfer.WebApi.Server.Models;

namespace Hamfer.WebApi.Server;

public sealed class WebApiAuthenticationSettings
{
  public ITokenValidator tokenValidator { get; set; }

  public WebApiAuthenticationSettings(ITokenValidator tokenValidator)
  {
    this.tokenValidator = tokenValidator;
  }
}