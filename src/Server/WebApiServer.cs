using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Hamfer.Kernel.Errors;

namespace Hamfer.WebApi.Server;

/// <summary>
/// The Web-Api suited server.
/// This server can handle http / https requests.
/// </summary>
public class WebApiServer {
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
      ApplicationName = config.appName ?? "Web-Api Server application",
      EnvironmentName = config.environment,
    };
    this.serverBuilder = WebApplication.CreateBuilder();
    this.serverBuilder.WebHost.UseKestrel();
    this.serverBuilder.WebHost.ConfigureKestrel(app =>
    {
      app.Listen(this.hostIpAddress, this.port);
    });
    
    this.serverBuilder.Services.AddCors((corsOptions) =>
    {
      CorsPolicyBuilder cpb = new();
      cpb.AllowAnyHeader();
      cpb.AllowAnyMethod();
      cpb.WithOrigins("http://localhost:3000", "https://localhost:3043", "http://192.168.1.1");

      corsOptions.AddPolicy("CORS", cpb.Build());
    });

    this.serverBuilder.Services.AddControllers();
  }


  public async Task start(params string[] args)
  {
    this.server ??= this.serverBuilder.Build();
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
}