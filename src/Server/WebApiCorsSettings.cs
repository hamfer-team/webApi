using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Hamfer.WebApi.Server;

public sealed class WebApiCorsSettings
{
  public const string ALLOW_ANY = "*";
  public const int MAX_AGE_DEFAULT = 86400;

  readonly string? allowedOrigins;
  readonly string? allowedMethods;
  readonly string? allowedHeaders;
  readonly string? exposedHeaders;
  readonly bool allowCredentials;
  readonly int maxAge;

  public WebApiCorsSettings(
    string? allowedOrigins = ALLOW_ANY,
    string? allowedMethods = ALLOW_ANY,
    string? allowedHeaders = ALLOW_ANY,
    string? exposedHeaders = null,
    bool? allowCredentials = false,
    int? maxAge = null
  ) {
    this.allowedOrigins = allowedOrigins;
    this.allowedMethods = allowedMethods;
    this.allowedHeaders = allowedHeaders;
    this.exposedHeaders = exposedHeaders;
    this.allowCredentials = allowCredentials ?? false;
    this.maxAge = maxAge ?? MAX_AGE_DEFAULT;
  }

  public CorsPolicy build()
  {
    CorsPolicyBuilder cpb = new();
    if (this.allowedMethods != null) {
      if (this.allowedMethods == ALLOW_ANY) {
        cpb = cpb.AllowAnyMethod();
      } else {
        cpb = cpb.WithMethods(this.allowedMethods);
      }
    }
    if (this.allowedOrigins != null) {
      if (this.allowedOrigins == ALLOW_ANY) {
        cpb = cpb.AllowAnyOrigin();
      } else {
        cpb = cpb.WithOrigins(this.allowedOrigins);
      }
    }
    if (this.allowedHeaders != null) {
      if (this.allowedHeaders == ALLOW_ANY) {
        cpb = cpb.AllowAnyHeader();
      } else {
        cpb = cpb.WithHeaders(this.allowedHeaders);
      }
    }
    if (this.exposedHeaders != null) {
      cpb = cpb.WithExposedHeaders(this.exposedHeaders);
    }
    cpb = this.allowCredentials ? cpb.AllowCredentials() : cpb.DisallowCredentials();
    cpb = cpb.SetPreflightMaxAge(TimeSpan.FromSeconds(this.maxAge));

    return cpb.Build();
  }
}