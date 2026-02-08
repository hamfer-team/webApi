namespace Hamfer.WebApi.Server;

/// <summary>
/// The Web-Api suited config of server.
/// </summary>
public class WebApiServerConfig {
  const int PORT_DEFAULT = 3000;
  // const int PORT_SSL_DEFAULT = 3043;
  const string HOST_IP_DEFAULT = "127.0.0.1";
  const string START_MESSAGE_PORT_PLACE_HOLDER = "${port}";
  const string START_MESSAGE_HOST_NAME_PLACE_HOLDER = "${hostName}";
  const string START_MESSAGE_DEFAULT = $"🔰 Web Api Server is running at http://{START_MESSAGE_HOST_NAME_PLACE_HOLDER}:{START_MESSAGE_PORT_PLACE_HOLDER}/";

  //export const DOCUMENTATION_DEFAULT_ROUTE: string = "document";
  //const SESSION_MAX_AGE_DEFAULT: number = 120000; // 2 min

  public readonly WebApiAppInfo? appInfo;
  public readonly string? environment;
  public readonly int port;
  public readonly string hostIpAddress;
  public readonly string startMessage;
  public WebApiCorsSettings? corsSettings { get; set; }
  public bool useSession {get; set;}

  //documentationRoute: string;
  //sslSettings: WebApiSslSettings | null;
  //sessionMaxAge: number;
  //corsSettings: WebApiCorsSettings;

  /// <summary>
  /// Creating a new Web Api Server Config.
  /// </summary>
  /// <param name="hostIpAddress">The IP-address of host, Use `0.0.0.0` for `ANY`</param>
  /// <param name="port">The Port number for listening</param>
  /// <param name="appInfo">The information about this app</param>
  /// <param name="environment">The application environment</param>
  /// <param name="startMessage">The message that appears after starting server</param>
  /// <param name="corsSettings">The CORS policies settings</param>
  public WebApiServerConfig(
    string? hostIpAddress = null,
    int? port = null, 
    WebApiAppInfo? appInfo = null,
    string? environment = null,
    string? startMessage = null,
    WebApiCorsSettings? corsSettings = null,
    bool useSession = false
  )
  {
    this.port = port ?? PORT_DEFAULT;
    this.hostIpAddress = hostIpAddress ?? HOST_IP_DEFAULT;
    this.appInfo = appInfo;
    this.environment = environment;
    this.corsSettings = corsSettings;
    this.useSession = useSession;
    
    string message = startMessage ?? START_MESSAGE_DEFAULT;
    message = message
    .Replace(START_MESSAGE_HOST_NAME_PLACE_HOLDER, "{0}", StringComparison.InvariantCultureIgnoreCase)
    .Replace(START_MESSAGE_PORT_PLACE_HOLDER, "{1}", StringComparison.InvariantCultureIgnoreCase);
    this.startMessage = string.Format(message, this.hostIpAddress, this.port);
  }
}