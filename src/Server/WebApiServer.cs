using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Hamfer.Kernel.Errors;
using Microsoft.OpenApi;

namespace Hamfer.WebApi.Server;

/// <summary>
/// The Web-Api suited server.
/// This server can handle http / https requests.
/// </summary>
public class WebApiServer {
  private const string OPEN_API_NAME = "hamfer-web-api-server-documentation";
  
  private readonly int port;
  private readonly IPAddress? hostIpAddress;
  private readonly WebApiServerConfig config;
  private readonly WebApplicationBuilder serverBuilder;

  private WebApplication? _server;
  private WebApplication? server
  {
    get { return this._server; }
    set { this._server = value; }
  }

  /// <summary>
  /// Creating a new Web Api Server instance
  /// </summary>
  /// <param name="config">Configs of web-api server</param>
  public WebApiServer(WebApiServerConfig config)
  {
    this.config = config;
    this.port = config.port;

    if (!IPAddress.TryParse(config.hostIpAddress, out this.hostIpAddress))
    {
      throw new KernelError($"Host IP Address({config.hostIpAddress}) is not valid!");
    }
    //----------
    
    WebApplicationOptions options = new()
    {
      ApplicationName = config.appInfo?.title ?? "Web-Api Server application",
      EnvironmentName = config.environment,
    };
    this.serverBuilder = WebApplication.CreateBuilder();
    this.serverBuilder.WebHost.UseKestrel();
    this.serverBuilder.WebHost.ConfigureKestrel(app =>
    {
      app.Listen(this.hostIpAddress, this.port);
    });
    
    if (config.corsSettings != null) {
      this.addSession();
    }

    if (this.config.useSession) {
      this.serverBuilder.Services.AddDistributedMemoryCache();
      this.serverBuilder.Services.AddSession(options =>
      {
        options.IdleTimeout = TimeSpan.FromSeconds(2 * 60);
      });
    }

    this.serverBuilder.Services.AddControllers();
    this.serverBuilder.Services.AddEndpointsApiExplorer();
    this.serverBuilder.Services.AddSwaggerGen(options =>
    {
      options.SwaggerDoc(OPEN_API_NAME, this.config.appInfo?.GetOpenApiInfo() ?? new OpenApiInfo());
    });
  }

  /// <summary>
  /// Explicity setting configs to use CORS policy
  /// </summary>
  /// <param name="corsSettings">The Web-Api suited cors settings</param>
  public void useCors(WebApiCorsSettings corsSettings)
  {
    this.config.corsSettings = corsSettings;
  }

  /// <summary>
  /// Explicisty setting configs to use Session in Web-Api.
  /// This means you can access `Session` in the controllers without error
  /// </summary>
  public void useSession()
  {
    this.config.useSession = true;
    this.addSession();
  }
  /// <summary>
  /// 
  /// </summary>
  /// <param name="args"></param>
  /// <returns></returns>
  public async Task start(params string[] args)
  {
    this.server ??= this.serverBuilder.Build();

    if (this.config.useSession) {
      this.server.UseSession();
    }

    // if (this.config.environment == "development") {
      this.server.UseSwagger();
      this.server.UseSwaggerUI(options =>
      {
        options.SwaggerEndpoint($"/swagger/{OPEN_API_NAME}/swagger.json", OPEN_API_NAME);
        options.RoutePrefix = "documents";
      });
    // }
    this.server.MapControllers();

    if (args.Length > 0 && args.FirstOrDefault(w => w.Equals("build-only", StringComparison.InvariantCultureIgnoreCase)) != null)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("💢 Build-Only flag detected!");
      Console.ForegroundColor = ConsoleColor.White;
      return;
    }

    Console.WriteLine(this.config.startMessage);
    await this.server.RunAsync();
  }

  private void addSession()
  {
    this.serverBuilder.Services.AddDistributedMemoryCache();
    this.serverBuilder.Services.AddSession(options =>
    {
      options.IdleTimeout = TimeSpan.FromSeconds(2 * 60);
    });
  }
}