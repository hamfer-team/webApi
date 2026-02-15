using Hamfer.WebApi.Server.Models;

namespace Hamfer.WebApi.Server;

public sealed class WebApiAuthenticationSettings
{
  public const string CLAIM_USER_ID_DEFAULT = "uid";

  public string issuer { get; set; }
  public string audience { get; set; }
  public string secretKey { get; set; }
  public string userIdClaim { get; set; }

  public WebApiAuthenticationSettings(string secretKey, string issuer, string audience, string? userIdClaim = null)
  {
    this.secretKey = secretKey;
    this.issuer = issuer;
    this.audience = audience;
    this.userIdClaim = userIdClaim ?? CLAIM_USER_ID_DEFAULT;
  }
}