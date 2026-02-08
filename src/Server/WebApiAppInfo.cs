using Microsoft.OpenApi;

namespace Hamfer.WebApi.Server;

public sealed class WebApiAppInfo
{
  public readonly string? title;
  public readonly string? version;
  public readonly string? description;
  public readonly string? summary;
  public readonly string? termsOfServiceUrl;
  public readonly string? contactName;
  public readonly string? contactEmail;
  public readonly string? contactUsUrl;
  public readonly string? licenceName;
  public readonly string? licenceUrl;

  public OpenApiInfo GetOpenApiInfo()
  {
    OpenApiContact openApiContact = new()
    {
      Name = this.contactName,
      Email = this.contactEmail,
      Url = this.contactUsUrl != null ? new Uri(contactUsUrl) : null,
    };

    OpenApiLicense openApiLicence =  new()
    {
      Name = this.licenceName,
      Url = this.licenceUrl != null ? new Uri(this.licenceUrl) : null,
    };

    return new OpenApiInfo
    {
      Title = this.title,
      Version = this.version,
      Description = this.description,
      TermsOfService = this.termsOfServiceUrl != null ? new Uri(this.termsOfServiceUrl) : null,
      Contact = openApiContact,
      License = openApiLicence,
      Summary = this.summary,
    };
  }
}