using System.Security.Claims;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hamfer.WebApi.Server.Models;

public interface ITokenValidator
{
  bool validate(string token);
}

public class TokenAuthenticationHandler : AuthenticationHandler<TokenAuthenticationOptions>
{
  readonly IServiceProvider serviceProvider;

  public TokenAuthenticationHandler(IOptionsMonitor<TokenAuthenticationOptions> options, ILoggerFactory logger, UrlEncoder encoder, IServiceProvider serviceProvider)
    : base(options,logger, encoder)
  {
    this.serviceProvider = serviceProvider;
  }

  protected override Task<AuthenticateResult> HandleAuthenticateAsync()
  {
    string token = this.Request.Headers.Authorization.ToString();

    if (string.IsNullOrEmpty(token)) {
      return Task.FromResult(AuthenticateResult.Fail("Token is null"));
    }

    ITokenValidator? tokenValidator = this.serviceProvider.GetService<ITokenValidator>();
    if (tokenValidator == null) {
      return Task.FromResult(AuthenticateResult.Fail("Token-Validator not found"));
    }

    bool isValidToken = tokenValidator.validate(token); // check token here

    if (!isValidToken) {
      return Task.FromResult (AuthenticateResult.Fail($"Balancer not authorize token : for token={token}"));
    }

    var claims = new [] { new Claim ("token", token) };
    var identity = new ClaimsIdentity (claims, nameof(TokenAuthenticationHandler));
    var ticket = new AuthenticationTicket (new ClaimsPrincipal(identity), this.Scheme.Name);
    return Task.FromResult(AuthenticateResult.Success(ticket));
  }
}

public class TokenAuthenticationOptions : AuthenticationSchemeOptions
{
}