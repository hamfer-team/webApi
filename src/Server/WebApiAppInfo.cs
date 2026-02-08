using Microsoft.OpenApi;

namespace Hamfer.WebApi.Server;

public sealed class WebApiAppInfo
{
  public string? title { get; set; }
  public string? version { get; set; }
  public string? description { get; set; }
  public string? summary { get; set; }
  public string? termsOfServiceUrl { get; set; }
  public string? contactName { get; set; }
  public string? contactEmail { get; set; }
  public string? contactUsUrl { get; set; }
  public string? licenceName { get; set; }
  public string? licenceUrl { get; set; }

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