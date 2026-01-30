using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Hamfer.WebApi.Server;

/// <summary>
/// The Web-Api suited server.
/// This server can handle http / https requests.
/// </summary>
public class WebApiServer {
  private readonly int port;
  private readonly string hostName;
  private readonly WebApiServerConfig config;

  private WebApplicationBuilder serverBuilder;

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
    this.hostName = config.hostName;
    //----------
    this.serverBuilder = WebApplication.CreateBuilder();
    
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


  public async Task start()
  {
    this.server ??= this.serverBuilder.Build();
    this.server.MapControllers();

    Console.WriteLine(this.config.startMessage);
    await this.server.RunAsync();
  }
}