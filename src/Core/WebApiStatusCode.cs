namespace Hamfer.WebApi.Core;

// https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Status
// Last update = 2025-12-21

public enum WebApiStatusCode 
{
  //#region Informational responses (100 – 199)
  // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
  
  /// <summary> This interim response indicates that the client should continue the request or ignore the response if the request is already finished. </summary>
  _100 = 100,
  /// <summary> This interim response indicates that the client should continue the request or ignore the response if the request is already finished. </summary>
  _100_Continue = _100,
  /// <summary> This interim response indicates that the client should continue the request or ignore the response if the request is already finished. </summary>
  Continue = _100,
  /// <summary> This interim response indicates that the client should continue the request or ignore the response if the request is already finished. </summary>
  CONTINUE = _100,

  /// <summary> This code is sent in response to an Upgrade request header from the client and indicates the protocol the server is switching to. (https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/Upgrade) </summary>
  _101 = 101,
  /// <summary> This code is sent in response to an Upgrade request header from the client and indicates the protocol the server is switching to. (https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/Upgrade) </summary>
  _101_Switching_Protocols = _101, 
  /// <summary> This code is sent in response to an Upgrade request header from the client and indicates the protocol the server is switching to. (https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/Upgrade) </summary>
  SwitchingProtocols = _101, 
  /// <summary> This code is sent in response to an Upgrade request header from the client and indicates the protocol the server is switching to. (https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/Upgrade) </summary>
  SWITCHING_PROTOCOLS = _101, 

  /// <summary>
  /// This code was used in WebDAV contexts to indicate that a request has been received by the server, but no status was available at the time of the response.
  // 💥 Deprecated. Not for use in new websites.
  /// </summary>
  _102 = 102,
  /// <summary>
  /// This code was used in WebDAV contexts to indicate that a request has been received by the server, but no status was available at the time of the response.
  // 💥 Deprecated. Not for use in new websites.
  /// </summary>
  _102_Processing = _102, 
  /// <summary>
  /// This code was used in WebDAV contexts to indicate that a request has been received by the server, but no status was available at the time of the response.
  // 💥 Deprecated. Not for use in new websites.
  /// </summary>
  Processing = _102,
  /// <summary>
  /// This code was used in WebDAV contexts to indicate that a request has been received by the server, but no status was available at the time of the response.
  // 💥 Deprecated. Not for use in new websites.
  /// </summary>
  PROCESSING = _102,

  /// <summary> This status code is primarily intended to be used with the Link header, letting the user agent start preloading resources while the server prepares a response or preconnect to an origin from which the page will need resources. </summary>
  _103 = 103,
  /// <summary> This status code is primarily intended to be used with the Link header, letting the user agent start preloading resources while the server prepares a response or preconnect to an origin from which the page will need resources. </summary>
  _103_Early_Hints = _103, 
  /// <summary> This status code is primarily intended to be used with the Link header, letting the user agent start preloading resources while the server prepares a response or preconnect to an origin from which the page will need resources. </summary>
  EarlyHints = _103,
  /// <summary> This status code is primarily intended to be used with the Link header, letting the user agent start preloading resources while the server prepares a response or preconnect to an origin from which the page will need resources. </summary>
  EARLY_HINTS = _103,

  //#endregion

  //#region Successful responses (200 – 299)
  // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

  /// <summary>
  /// The request succeeded. The result and meaning of "success" depends on the HTTP method:
  /// - GET = The resource has been fetched and transmitted in the message body.
  /// - HEAD = Representation headers are included in the response without any message body.
  /// - PUT or POST = The resource describing the result of the action is transmitted in the message body.
  /// - TRACE = The message body contains the request as received by the server.
  /// </summary>
  _200 = 200,
  /// <summary>
  /// The request succeeded. The result and meaning of "success" depends on the HTTP method:
  /// - GET = The resource has been fetched and transmitted in the message body.
  /// - HEAD = Representation headers are included in the response without any message body.
  /// - PUT or POST = The resource describing the result of the action is transmitted in the message body.
  /// - TRACE = The message body contains the request as received by the server.
  /// </summary>
  _200_OK = _200,
  /// <summary>
  /// The request succeeded. The result and meaning of "success" depends on the HTTP method:
  /// - GET = The resource has been fetched and transmitted in the message body.
  /// - HEAD = Representation headers are included in the response without any message body.
  /// - PUT or POST = The resource describing the result of the action is transmitted in the message body.
  /// - TRACE = The message body contains the request as received by the server.
  /// </summary>
  Ok = _200,
  /// <summary>
  /// The request succeeded. The result and meaning of "success" depends on the HTTP method:
  /// - GET = The resource has been fetched and transmitted in the message body.
  /// - HEAD = Representation headers are included in the response without any message body.
  /// - PUT or POST = The resource describing the result of the action is transmitted in the message body.
  /// - TRACE = The message body contains the request as received by the server.
  /// </summary>
  OK = _200,

  /// <summary> The request succeeded, and a new resource was created as a result. This is typically the response sent after POST requests, or some PUT requests. </summary>
  _201 = 201,
  /// <summary> The request succeeded, and a new resource was created as a result. This is typically the response sent after POST requests, or some PUT requests. </summary>
  _201_Created = _201,
  /// <summary> The request succeeded, and a new resource was created as a result. This is typically the response sent after POST requests, or some PUT requests. </summary>
  Created = _201,
  /// <summary> The request succeeded, and a new resource was created as a result. This is typically the response sent after POST requests, or some PUT requests. </summary>
  CREATED = _201,

  /// <summary> The request has been received but not yet acted upon. It is noncommittal, since there is no way in HTTP to later send an asynchronous response indicating the outcome of the request. It is intended for cases where another process or server handles the request, or for batch processing. </summary>
  _202 = 202,
  /// <summary> The request has been received but not yet acted upon. It is noncommittal, since there is no way in HTTP to later send an asynchronous response indicating the outcome of the request. It is intended for cases where another process or server handles the request, or for batch processing. </summary>
  _202_Accepted = _202,
  /// <summary> The request has been received but not yet acted upon. It is noncommittal, since there is no way in HTTP to later send an asynchronous response indicating the outcome of the request. It is intended for cases where another process or server handles the request, or for batch processing. </summary>
  Accepted = _202,
  /// <summary> The request has been received but not yet acted upon. It is noncommittal, since there is no way in HTTP to later send an asynchronous response indicating the outcome of the request. It is intended for cases where another process or server handles the request, or for batch processing. </summary>
  ACCEPTED = _202,

  /// <summary> This response code means the returned metadata is not exactly the same as is available from the origin server, but is collected from a local or a third-party copy. This is mostly used for mirrors or backups of another resource. Except for that specific case, the 200 OK response is preferred to this status. </summary>
  _203 = 203,
  /// <summary> This response code means the returned metadata is not exactly the same as is available from the origin server, but is collected from a local or a third-party copy. This is mostly used for mirrors or backups of another resource. Except for that specific case, the 200 OK response is preferred to this status. </summary>
  _203_Non_Authoritative_Information = _203,
  /// <summary> This response code means the returned metadata is not exactly the same as is available from the origin server, but is collected from a local or a third-party copy. This is mostly used for mirrors or backups of another resource. Except for that specific case, the 200 OK response is preferred to this status. </summary>
  NonAuthoritativeInformation = _203,
  /// <summary> This response code means the returned metadata is not exactly the same as is available from the origin server, but is collected from a local or a third-party copy. This is mostly used for mirrors or backups of another resource. Except for that specific case, the 200 OK response is preferred to this status. </summary>
  NON_AUTHORITATIVE_INFORMATION = _203,

  /// <summary> There is no content to send for this request, but the headers are useful. The user agent may update its cached headers for this resource with the new ones. </summary>
  _204 = 204,
  /// <summary> There is no content to send for this request, but the headers are useful. The user agent may update its cached headers for this resource with the new ones. </summary>
  _204_No_Content = _204,
/// <summary> There is no content to send for this request, but the headers are useful. The user agent may update its cached headers for this resource with the new ones. </summary>
  NoContent = _204,
  /// <summary> There is no content to send for this request, but the headers are useful. The user agent may update its cached headers for this resource with the new ones. </summary>
  NO_CONTENT = _204,

  /// <summary> Tells the user agent to reset the document which sent this request. </summary>
  _205 = 205,
  /// <summary> Tells the user agent to reset the document which sent this request. </summary>
  _205_Reset_Content = _205,
  /// <summary> Tells the user agent to reset the document which sent this request. </summary>
  ResetContent = _205,
  /// <summary> Tells the user agent to reset the document which sent this request. </summary>
  RESET_CONTENT = _205,

  /// <summary> This response code is used in response to a range request when the client has requested a part or parts of a resource. </summary>
  _206 = 206,
  /// <summary> This response code is used in response to a range request when the client has requested a part or parts of a resource. </summary>
  _206_Partial_Content = _206,
  /// <summary> This response code is used in response to a range request when the client has requested a part or parts of a resource. </summary>
  PartialContent = _206,
  /// <summary> This response code is used in response to a range request when the client has requested a part or parts of a resource. </summary>
  PARTIAL_CONTENT = _206,

  /// <summary> Conveys information about multiple resources, for situations where multiple status codes might be appropriate. (WebDAV) </summary>
  _207 = 207,
  /// <summary> Conveys information about multiple resources, for situations where multiple status codes might be appropriate. (WebDAV) </summary>
  _207_Multi_Status = _207,
  /// <summary> Conveys information about multiple resources, for situations where multiple status codes might be appropriate. (WebDAV) </summary>
  MultiStatus = _207,
  /// <summary> Conveys information about multiple resources, for situations where multiple status codes might be appropriate. (WebDAV) </summary>
  MULTI_STATUS = _207,

  /// <summary> Used inside a <dav:propstat> response element to avoid repeatedly enumerating the internal members of multiple bindings to the same collection. (WebDAV) </summary>
  _208 = 208,
  /// <summary> Used inside a <dav:propstat> response element to avoid repeatedly enumerating the internal members of multiple bindings to the same collection. (WebDAV) </summary>
  _208_Already_Reported = _208,
  /// <summary> Used inside a <dav:propstat> response element to avoid repeatedly enumerating the internal members of multiple bindings to the same collection. (WebDAV) </summary>
  AlreadyReported = _208,
  /// <summary> Used inside a <dav:propstat> response element to avoid repeatedly enumerating the internal members of multiple bindings to the same collection. (WebDAV) </summary>
  ALREADY_REPORTED = _208,

  ///<summary> The server has fulfilled a GET request for the resource, and the response is a representation of the result of one or more instance-manipulations applied to the current instance. </summary>
  _226 = 226,
  ///<summary> The server has fulfilled a GET request for the resource, and the response is a representation of the result of one or more instance-manipulations applied to the current instance. </summary>
  _226_I_M_Used = _226,
  ///<summary> The server has fulfilled a GET request for the resource, and the response is a representation of the result of one or more instance-manipulations applied to the current instance. </summary>
  IMUsed = _226,
  ///<summary> The server has fulfilled a GET request for the resource, and the response is a representation of the result of one or more instance-manipulations applied to the current instance. </summary>
  I_M_USED = _226,

  //#endregion

  //#region Redirection messages (300 – 399)
  // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
  
  /// <summary>
  /// In agent-driven content negotiation, the request has more than one possible response and the user agent or user should choose one of them. There is no standardized way for clients to automatically choose one of the responses, so this is rarely used.
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Content_negotiation#agent-driven_negotiation
  /// </summary>
  _300 = 300,
  /// <summary>
  /// In agent-driven content negotiation, the request has more than one possible response and the user agent or user should choose one of them. There is no standardized way for clients to automatically choose one of the responses, so this is rarely used.
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Content_negotiation#agent-driven_negotiation
  /// </summary>
  _300_Multiple_Choices = _300,
  /// <summary>
  /// In agent-driven content negotiation, the request has more than one possible response and the user agent or user should choose one of them. There is no standardized way for clients to automatically choose one of the responses, so this is rarely used.
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Content_negotiation#agent-driven_negotiation
  /// </summary>
  MultipleChoices = _300,
  /// <summary>
  /// In agent-driven content negotiation, the request has more than one possible response and the user agent or user should choose one of them. There is no standardized way for clients to automatically choose one of the responses, so this is rarely used.
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Content_negotiation#agent-driven_negotiation
  /// </summary>
  MULTIPLE_CHOICES = _300,

  /// <summary> The URL of the requested resource has been changed permanently. The new URL is given in the response. </summary>
  _301 = 301,
  /// <summary> The URL of the requested resource has been changed permanently. The new URL is given in the response. </summary>
  _301_Moved_Permanently = _301,
  /// <summary> The URL of the requested resource has been changed permanently. The new URL is given in the response. </summary>
  MovedPermanently = _301,
  /// <summary> The URL of the requested resource has been changed permanently. The new URL is given in the response. </summary>
  MOVED_PERMANENTLY = _301,

  /// <summary> This response code means that the URI of requested resource has been changed temporarily. Further changes in the URI might be made in the future, so the same URI should be used by the client in future requests. </summary>
  _302 = 302,
  /// <summary> This response code means that the URI of requested resource has been changed temporarily. Further changes in the URI might be made in the future, so the same URI should be used by the client in future requests. </summary>
  _302_Found = _302,
  /// <summary> This response code means that the URI of requested resource has been changed temporarily. Further changes in the URI might be made in the future, so the same URI should be used by the client in future requests. </summary>
  Found = _302,
  /// <summary> This response code means that the URI of requested resource has been changed temporarily. Further changes in the URI might be made in the future, so the same URI should be used by the client in future requests. </summary>
  FOUND = _302,

  /// <summary> The server sent this response to direct the client to get the requested resource at another URI with a GET request. </summary>
  _303 = 303,
  /// <summary> The server sent this response to direct the client to get the requested resource at another URI with a GET request. </summary>
  _303_See_Other = _303,
  /// <summary> The server sent this response to direct the client to get the requested resource at another URI with a GET request. </summary>
  SeeOther = _303,
  /// <summary> The server sent this response to direct the client to get the requested resource at another URI with a GET request. </summary>
  SEE_OTHER = _303,

  /// <summary> This is used for caching purposes. It tells the client that the response has not been modified, so the client can continue to use the same cached version of the response. </summary>
  _304 = 304,
  /// <summary> This is used for caching purposes. It tells the client that the response has not been modified, so the client can continue to use the same cached version of the response. </summary>
  _304_Not_Modified = _304,
  /// <summary> This is used for caching purposes. It tells the client that the response has not been modified, so the client can continue to use the same cached version of the response. </summary>
  NotModified = _304,
  /// <summary> This is used for caching purposes. It tells the client that the response has not been modified, so the client can continue to use the same cached version of the response. </summary>
  NOT_MODIFIED = _304,

  /// <summary>
  /// Defined in a previous version of the HTTP specification to indicate that a requested response must be accessed by a proxy. It has been deprecated due to security concerns regarding in-band configuration of a proxy.
  /// 💥 Deprecated. Not for use in new websites.
  /// </summary>
  _305 = 305,
  /// <summary>
  /// Defined in a previous version of the HTTP specification to indicate that a requested response must be accessed by a proxy. It has been deprecated due to security concerns regarding in-band configuration of a proxy.
  /// 💥 Deprecated. Not for use in new websites.
  /// </summary>
  _305_Use_Proxy = _305,
  /// <summary>
  /// Defined in a previous version of the HTTP specification to indicate that a requested response must be accessed by a proxy. It has been deprecated due to security concerns regarding in-band configuration of a proxy.
  /// 💥 Deprecated. Not for use in new websites.
  /// </summary>
  UseProxy = _305,
  /// <summary>
  /// Defined in a previous version of the HTTP specification to indicate that a requested response must be accessed by a proxy. It has been deprecated due to security concerns regarding in-band configuration of a proxy.
  /// 💥 Deprecated. Not for use in new websites.
  /// </summary>
  Use_Proxy = _305,

  /// <summary> This response code is no longer used; but is reserved. It was used in a previous version of the HTTP/1.1 specification. </summary>
  _306 = 306,
  /// <summary> This response code is no longer used; but is reserved. It was used in a previous version of the HTTP/1.1 specification. </summary>
  _306_Unused = _306, 
  /// <summary> This response code is no longer used; but is reserved. It was used in a previous version of the HTTP/1.1 specification. </summary>
  Unused = _306,
  /// <summary> This response code is no longer used; but is reserved. It was used in a previous version of the HTTP/1.1 specification. </summary>
  UNUSED = _306,

  /// <summary> The server sends this response to direct the client to get the requested resource at another URI with the same method that was used in the prior request. This has the same semantics as the 302 Found response code, with the exception that the user agent must not change the HTTP method used = if a POST was used in the first request, a POST must be used in the redirected request. </summary>
  _307 = 307,
  /// <summary> The server sends this response to direct the client to get the requested resource at another URI with the same method that was used in the prior request. This has the same semantics as the 302 Found response code, with the exception that the user agent must not change the HTTP method used = if a POST was used in the first request, a POST must be used in the redirected request. </summary>
  _307_Temporary_Redirect = _307,
  /// <summary> The server sends this response to direct the client to get the requested resource at another URI with the same method that was used in the prior request. This has the same semantics as the 302 Found response code, with the exception that the user agent must not change the HTTP method used = if a POST was used in the first request, a POST must be used in the redirected request. </summary>
  TemporaryRedirect = _307,
  /// <summary> The server sends this response to direct the client to get the requested resource at another URI with the same method that was used in the prior request. This has the same semantics as the 302 Found response code, with the exception that the user agent must not change the HTTP method used = if a POST was used in the first request, a POST must be used in the redirected request. </summary>
  TEMPORARY_REDIRECT = _307,

  /// <summary> This means that the resource is now permanently located at another URI, specified by the Location response header. This has the same semantics as the 301 Moved Permanently HTTP response code, with the exception that the user agent must not change the HTTP method used = if a POST was used in the first request, a POST must be used in the second request. </summary>
  _308 = 308,
  /// <summary> This means that the resource is now permanently located at another URI, specified by the Location response header. This has the same semantics as the 301 Moved Permanently HTTP response code, with the exception that the user agent must not change the HTTP method used = if a POST was used in the first request, a POST must be used in the second request. </summary>
  _308_Permanent_Redirect = _308,
  /// <summary> This means that the resource is now permanently located at another URI, specified by the Location response header. This has the same semantics as the 301 Moved Permanently HTTP response code, with the exception that the user agent must not change the HTTP method used = if a POST was used in the first request, a POST must be used in the second request. </summary>
  PermanentRedirect = _308,
  /// <summary> This means that the resource is now permanently located at another URI, specified by the Location response header. This has the same semantics as the 301 Moved Permanently HTTP response code, with the exception that the user agent must not change the HTTP method used = if a POST was used in the first request, a POST must be used in the second request. </summary>
  Permanent_Redirect = _308,

  //#endregion

  //#region Client error responses (400 – 499)
  // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
  
  /// <summary> The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). </summary>
  _400 = 400,
  /// <summary> The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). </summary>
  _400_Bad_Request = _400,
  /// <summary> The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). </summary>
  BadRequest = _400,
  /// <summary> The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). </summary>
  BAD_REQUEST = _400,

  /// <summary> Although the HTTP standard specifies "unauthorized", semantically this response means "unauthenticated". That is, the client must authenticate itself to get the requested response. </summary>
  _401 = 401,
  /// <summary> Although the HTTP standard specifies "unauthorized", semantically this response means "unauthenticated". That is, the client must authenticate itself to get the requested response. </summary>
  _401_Unauthorized = _401,
  /// <summary> Although the HTTP standard specifies "unauthorized", semantically this response means "unauthenticated". That is, the client must authenticate itself to get the requested response. </summary>
  Unauthorized = _401,
  /// <summary> Although the HTTP standard specifies "unauthorized", semantically this response means "unauthenticated". That is, the client must authenticate itself to get the requested response. </summary>
  UNAUTHORIZED = _401,

  /// <summary> The initial purpose of this code was for digital payment systems, however this status code is rarely used and no standard convention exists. </summary>
  _402 = 402,
  /// <summary> The initial purpose of this code was for digital payment systems, however this status code is rarely used and no standard convention exists. </summary>
  _402_Payment_Required = _402,
  /// <summary> The initial purpose of this code was for digital payment systems, however this status code is rarely used and no standard convention exists. </summary>
  PaymentRequired = _402,
  /// <summary> The initial purpose of this code was for digital payment systems, however this status code is rarely used and no standard convention exists. </summary>
  Payment_Required = _402,

  /// <summary> The client does not have access rights to the content; that is, it is unauthorized, so the server is refusing to give the requested resource. Unlike 401 Unauthorized, the client's identity is known to the server. </summary>
  _403 = 403,
  /// <summary> The client does not have access rights to the content; that is, it is unauthorized, so the server is refusing to give the requested resource. Unlike 401 Unauthorized, the client's identity is known to the server. </summary>
  _403_Forbidden = _403,
  /// <summary> The client does not have access rights to the content; that is, it is unauthorized, so the server is refusing to give the requested resource. Unlike 401 Unauthorized, the client's identity is known to the server. </summary>
  Forbidden = _403,
  /// <summary> The client does not have access rights to the content; that is, it is unauthorized, so the server is refusing to give the requested resource. Unlike 401 Unauthorized, the client's identity is known to the server. </summary>
  FORBIDDEN = _403,

  /// <summary> The server cannot find the requested resource. In the browser, this means the URL is not recognized. In an API, this can also mean that the endpoint is valid but the resource itself does not exist. Servers may also send this response instead of 403 Forbidden to hide the existence of a resource from an unauthorized client. This response code is probably the most well known due to its frequent occurrence on the web. </summary>
  _404 = 404,
  /// <summary> The server cannot find the requested resource. In the browser, this means the URL is not recognized. In an API, this can also mean that the endpoint is valid but the resource itself does not exist. Servers may also send this response instead of 403 Forbidden to hide the existence of a resource from an unauthorized client. This response code is probably the most well known due to its frequent occurrence on the web. </summary>
  _404_Not_Found = _404,
  /// <summary> The server cannot find the requested resource. In the browser, this means the URL is not recognized. In an API, this can also mean that the endpoint is valid but the resource itself does not exist. Servers may also send this response instead of 403 Forbidden to hide the existence of a resource from an unauthorized client. This response code is probably the most well known due to its frequent occurrence on the web. </summary>
  NotFound = _404,
  /// <summary> The server cannot find the requested resource. In the browser, this means the URL is not recognized. In an API, this can also mean that the endpoint is valid but the resource itself does not exist. Servers may also send this response instead of 403 Forbidden to hide the existence of a resource from an unauthorized client. This response code is probably the most well known due to its frequent occurrence on the web. </summary>
  NOT_FOUND = _404,

  /// <summary> The request method is known by the server but is not supported by the target resource. For example, an API may not allow DELETE on a resource, or the TRACE method entirely. </summary>
  _405 = 405,
  /// <summary> The request method is known by the server but is not supported by the target resource. For example, an API may not allow DELETE on a resource, or the TRACE method entirely. </summary>
  _405_Method_Not_Allowed = _405,
  /// <summary> The request method is known by the server but is not supported by the target resource. For example, an API may not allow DELETE on a resource, or the TRACE method entirely. </summary>
  MethodNotAllowed = _405,
  /// <summary> The request method is known by the server but is not supported by the target resource. For example, an API may not allow DELETE on a resource, or the TRACE method entirely. </summary>
  METHOD_NOT_ALLOWED = _405,

  /// <summary> This response is sent when the web server, after performing server-driven content negotiation, doesn't find any content that conforms to the criteria given by the user agent. </summary>
  _406 = 406,
  /// <summary> This response is sent when the web server, after performing server-driven content negotiation, doesn't find any content that conforms to the criteria given by the user agent. </summary>
  _406_Not_Acceptable = _406,
  /// <summary> This response is sent when the web server, after performing server-driven content negotiation, doesn't find any content that conforms to the criteria given by the user agent. </summary>
  NotAcceptable = _406,
  /// <summary> This response is sent when the web server, after performing server-driven content negotiation, doesn't find any content that conforms to the criteria given by the user agent. </summary>
  NOT_ACCEPTABLE = _406,

  /// <summary> This is similar to 401 Unauthorized but authentication is needed to be done by a proxy. </summary>
  _407 = 407,
  /// <summary> This is similar to 401 Unauthorized but authentication is needed to be done by a proxy. </summary>
  _407_Proxy_Authentication_Required = _407,
  /// <summary> This is similar to 401 Unauthorized but authentication is needed to be done by a proxy. </summary>
  ProxyAuthenticationRequired = _407,
  /// <summary> This is similar to 401 Unauthorized but authentication is needed to be done by a proxy. </summary>
  PROXY_AUTHENTICATION_REQUIRED = _407,

  /// <summary> This response is sent on an idle connection by some servers, even without any previous request by the client. It means that the server would like to shut down this unused connection. This response is used much more since some browsers use HTTP pre-connection mechanisms to speed up browsing. Some servers may shut down a connection without sending this message. </summary>
  _408 = 408,
  /// <summary> This response is sent on an idle connection by some servers, even without any previous request by the client. It means that the server would like to shut down this unused connection. This response is used much more since some browsers use HTTP pre-connection mechanisms to speed up browsing. Some servers may shut down a connection without sending this message. </summary>
  _408_Request_Timeout = _408,
  /// <summary> This response is sent on an idle connection by some servers, even without any previous request by the client. It means that the server would like to shut down this unused connection. This response is used much more since some browsers use HTTP pre-connection mechanisms to speed up browsing. Some servers may shut down a connection without sending this message. </summary>
  RequestTimeout = _408,
  /// <summary> This response is sent on an idle connection by some servers, even without any previous request by the client. It means that the server would like to shut down this unused connection. This response is used much more since some browsers use HTTP pre-connection mechanisms to speed up browsing. Some servers may shut down a connection without sending this message. </summary>
  REQUEST_TIMEOUT = _408,

  /// <summary> This response is sent when a request conflicts with the current state of the server. In WebDAV remote web authoring, 409 responses are errors sent to the client so that a user might be able to resolve a conflict and resubmit the request. </summary>
  _409 = 409,
  /// <summary> This response is sent when a request conflicts with the current state of the server. In WebDAV remote web authoring, 409 responses are errors sent to the client so that a user might be able to resolve a conflict and resubmit the request. </summary>
  _409_Conflict = _409,
  /// <summary> This response is sent when a request conflicts with the current state of the server. In WebDAV remote web authoring, 409 responses are errors sent to the client so that a user might be able to resolve a conflict and resubmit the request. </summary>
  Conflict = _409,
  /// <summary> This response is sent when a request conflicts with the current state of the server. In WebDAV remote web authoring, 409 responses are errors sent to the client so that a user might be able to resolve a conflict and resubmit the request. </summary>
  CONFLICT = _409,

  /// <summary> This response is sent when the requested content has been permanently deleted from server, with no forwarding address. Clients are expected to remove their caches and links to the resource. The HTTP specification intends this status code to be used for "limited-time, promotional services". APIs should not feel compelled to indicate resources that have been deleted with this status code. </summary>
  _410 = 410,
  /// <summary> This response is sent when the requested content has been permanently deleted from server, with no forwarding address. Clients are expected to remove their caches and links to the resource. The HTTP specification intends this status code to be used for "limited-time, promotional services". APIs should not feel compelled to indicate resources that have been deleted with this status code. </summary>
  _410_Gone = _410,
  /// <summary> This response is sent when the requested content has been permanently deleted from server, with no forwarding address. Clients are expected to remove their caches and links to the resource. The HTTP specification intends this status code to be used for "limited-time, promotional services". APIs should not feel compelled to indicate resources that have been deleted with this status code. </summary>
  Gone = _410,
  /// <summary> This response is sent when the requested content has been permanently deleted from server, with no forwarding address. Clients are expected to remove their caches and links to the resource. The HTTP specification intends this status code to be used for "limited-time, promotional services". APIs should not feel compelled to indicate resources that have been deleted with this status code. </summary>
  GONE = _410,

  /// <summary> Server rejected the request because the Content-Length header field is not defined and the server requires it. </summary>
  _411 = 411,
  /// <summary> Server rejected the request because the Content-Length header field is not defined and the server requires it. </summary>
  _411_Length_Required = _411,
  /// <summary> Server rejected the request because the Content-Length header field is not defined and the server requires it. </summary>
  LengthRequired = _411,
  /// <summary> Server rejected the request because the Content-Length header field is not defined and the server requires it. </summary>
  LENGTH_REQUIRED = _411,

  /// <summary>
  /// In conditional requests, the client has indicated preconditions in its headers which the server does not meet.
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Conditional_requests
  /// </summary>
  _412 = 412,
  /// <summary>
  /// In conditional requests, the client has indicated preconditions in its headers which the server does not meet.
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Conditional_requests
  /// </summary>
  _412_Precondition_Failed = _412,
  /// <summary>
  /// In conditional requests, the client has indicated preconditions in its headers which the server does not meet.
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Conditional_requests
  /// </summary>
  PreconditionFailed = _412,
  /// <summary>
  /// In conditional requests, the client has indicated preconditions in its headers which the server does not meet.
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Conditional_requests
  /// </summary>
  PRECONDITION_FAILED = _412,

  /// <summary> The request body is larger than limits defined by server. The server might close the connection or return a Retry-After header field. </summary>
  _413 = 413,
  /// <summary> The request body is larger than limits defined by server. The server might close the connection or return a Retry-After header field. </summary>
  _413_Content_Too_Large = _413,
  /// <summary> The request body is larger than limits defined by server. The server might close the connection or return a Retry-After header field. </summary>
  ContentTooLarge = _413,
  /// <summary> The request body is larger than limits defined by server. The server might close the connection or return a Retry-After header field. </summary>
  CONTENT_TOO_LARGE = _413,

  /// <summary> The URI requested by the client is longer than the server is willing to interpret. </summary>
  _414 = 414,
  /// <summary> The URI requested by the client is longer than the server is willing to interpret. </summary>
  _414_URI_Too_Long = _414,
  /// <summary> The URI requested by the client is longer than the server is willing to interpret. </summary>
  URITooLong = _414,
  /// <summary> The URI requested by the client is longer than the server is willing to interpret. </summary>
  URI_Too_Long = _414,

  /// <summary> The media format of the requested data is not supported by the server, so the server is rejecting the request. </summary>
  _415 = 415,
  /// <summary> The media format of the requested data is not supported by the server, so the server is rejecting the request. </summary>
  _415_Unsupported_Media_Type = _415,
  /// <summary> The media format of the requested data is not supported by the server, so the server is rejecting the request. </summary>
  UnsupportedMediaType = _415,
  /// <summary> The media format of the requested data is not supported by the server, so the server is rejecting the request. </summary>
  UNSUPPORTED_MEDIA_TYPE = _415,

  /// <summary>
  /// The ranges specified by the Range header field in the request cannot be fulfilled. It's possible that the range is outside the size of the target resource's data.
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Range_requests
  /// </summary>
  _416 = 416,
  /// <summary>
  /// The ranges specified by the Range header field in the request cannot be fulfilled. It's possible that the range is outside the size of the target resource's data.
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Range_requests
  /// </summary>
  _416_Range_Not_Satisfiable = _416,
  /// <summary>
  /// The ranges specified by the Range header field in the request cannot be fulfilled. It's possible that the range is outside the size of the target resource's data.
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Range_requests
  /// </summary>
  RangeNotSatisfiable = _416,
  /// <summary>
  /// The ranges specified by the Range header field in the request cannot be fulfilled. It's possible that the range is outside the size of the target resource's data.
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Range_requests
  /// </summary>
  RANGE_NOT_SATISFIABLE = _416,

  /// <summary> This response code means the expectation indicated by the Expect request header field cannot be met by the server. </summary>
  _417 = 417,
  /// <summary> This response code means the expectation indicated by the Expect request header field cannot be met by the server. </summary>
  _417_Expectation_Failed = _417,
  /// <summary> This response code means the expectation indicated by the Expect request header field cannot be met by the server. </summary>
  ExpectationFailed = _417,
  /// <summary> This response code means the expectation indicated by the Expect request header field cannot be met by the server. </summary>
  EXPECTATION_FAILED = _417,

  /// <summary> The server refuses the attempt to brew coffee with a teapot. ;) </summary>
  _418 = 418,
  /// <summary> The server refuses the attempt to brew coffee with a teapot. ;) </summary>
  _418_I_m_a_teapot = _418,
  /// <summary> The server refuses the attempt to brew coffee with a teapot. ;) </summary>
  IMATeapot = _418,
  /// <summary> The server refuses the attempt to brew coffee with a teapot. ;) </summary>
  I_m_a_teapot = _418,

  /// <summary> The request was directed at a server that is not able to produce a response. This can be sent by a server that is not configured to produce responses for the combination of scheme and authority that are included in the request URI. </summary>
  _421 = 421,
  /// <summary> The request was directed at a server that is not able to produce a response. This can be sent by a server that is not configured to produce responses for the combination of scheme and authority that are included in the request URI. </summary>
  _421_Misdirected_Request = _421,
  /// <summary> The request was directed at a server that is not able to produce a response. This can be sent by a server that is not configured to produce responses for the combination of scheme and authority that are included in the request URI. </summary>
  MisdirectedRequest = _421,
  /// <summary> The request was directed at a server that is not able to produce a response. This can be sent by a server that is not configured to produce responses for the combination of scheme and authority that are included in the request URI. </summary>
  Misdirected_Request = _421,

  /// <summary> The request was well-formed but was unable to be followed due to semantic errors. (WebDAV) </summary>
  _422 = 422,
  /// <summary> The request was well-formed but was unable to be followed due to semantic errors. (WebDAV) </summary>
  _422_Unprocessable_Content = _422,
  /// <summary> The request was well-formed but was unable to be followed due to semantic errors. (WebDAV) </summary>
  UnprocessableContent = _422,
  /// <summary> The request was well-formed but was unable to be followed due to semantic errors. (WebDAV) </summary>
  Unprocessable_Content = _422,

  /// <summary> The resource that is being accessed is locked. (WebDAV) </summary>
  _423 = 423,
  /// <summary> The resource that is being accessed is locked. (WebDAV) </summary>
  _423_Locked = _423,
  /// <summary> The resource that is being accessed is locked. (WebDAV) </summary>
  Locked = _423,
  /// <summary> The resource that is being accessed is locked. (WebDAV) </summary>
  LOCKED = _423,

  /// <summary> The request failed due to failure of a previous request. </summary>
  _424 = 424,
  /// <summary> The request failed due to failure of a previous request. </summary>
  _424_Failed_Dependency = _424,
  /// <summary> The request failed due to failure of a previous request. </summary>
  FailedDependency = _424,
  /// <summary> The request failed due to failure of a previous request. </summary>
  FAILED_DEPENDENCY = _424,

  // Indicates that the server is unwilling to risk processing a request that might be replayed.
  // Experimental. Expect behavior will change in future.
  _425 = 425,
  TooEarly = _425, Too_Early = _425, _425_Too_Early = _425,

  /// <summary>
  /// The server refuses to perform the request using the current protocol but might be willing to do so after the client upgrades to a different protocol. The server sends an Upgrade header in a 426 response to indicate the required protocol(s).
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/Upgrade
  /// </summary>
  _426 = 426,
  /// <summary>
  /// The server refuses to perform the request using the current protocol but might be willing to do so after the client upgrades to a different protocol. The server sends an Upgrade header in a 426 response to indicate the required protocol(s).
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/Upgrade
  /// </summary>
  _426_Upgrade_Required = _426,
  /// <summary>
  /// The server refuses to perform the request using the current protocol but might be willing to do so after the client upgrades to a different protocol. The server sends an Upgrade header in a 426 response to indicate the required protocol(s).
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/Upgrade
  /// </summary>
  UpgradeRequired = _426,
  /// <summary>
  /// The server refuses to perform the request using the current protocol but might be willing to do so after the client upgrades to a different protocol. The server sends an Upgrade header in a 426 response to indicate the required protocol(s).
  /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers/Upgrade
  /// </summary>
  Upgrade_Required = _426,

  /// <summary> The origin server requires the request to be conditional. This response is intended to prevent the 'lost update' problem, where a client GETs a resource's state, modifies it and PUTs it back to the server, when meanwhile a third party has modified the state on the server, leading to a conflict. </summary>
  _428 = 428,
  /// <summary> The origin server requires the request to be conditional. This response is intended to prevent the 'lost update' problem, where a client GETs a resource's state, modifies it and PUTs it back to the server, when meanwhile a third party has modified the state on the server, leading to a conflict. </summary>
  _428_Precondition_Required =_428,
  /// <summary> The origin server requires the request to be conditional. This response is intended to prevent the 'lost update' problem, where a client GETs a resource's state, modifies it and PUTs it back to the server, when meanwhile a third party has modified the state on the server, leading to a conflict. </summary>
  PreconditionRequired = _428,
  /// <summary> The origin server requires the request to be conditional. This response is intended to prevent the 'lost update' problem, where a client GETs a resource's state, modifies it and PUTs it back to the server, when meanwhile a third party has modified the state on the server, leading to a conflict. </summary>
  PRECONDITION_REQUIRED = _428,

  /// <summary>
  /// The user has sent too many requests in a given amount of time (rate limiting).
  /// https://developer.mozilla.org/en-US/docs/Glossary/Rate_limit
  /// </summary>
  _429 = 429,
  /// <summary>
  /// The user has sent too many requests in a given amount of time (rate limiting).
  /// https://developer.mozilla.org/en-US/docs/Glossary/Rate_limit
  /// </summary>
  _429_Too_Many_Requests = _429,
  /// <summary>
  /// The user has sent too many requests in a given amount of time (rate limiting).
  /// https://developer.mozilla.org/en-US/docs/Glossary/Rate_limit
  /// </summary>
  TooManyRequests = _429,
  /// <summary>
  /// The user has sent too many requests in a given amount of time (rate limiting).
  /// https://developer.mozilla.org/en-US/docs/Glossary/Rate_limit
  /// </summary>
  TOO_MANY_REQUESTS = _429,

  /// <summary> The server is unwilling to process the request because its header fields are too large. The request may be resubmitted after reducing the size of the request header fields. </summary>
  _431 = 431,
  /// <summary> The server is unwilling to process the request because its header fields are too large. The request may be resubmitted after reducing the size of the request header fields. </summary>
  _431_Request_Header_Fields_Too_Large = _431,
  /// <summary> The server is unwilling to process the request because its header fields are too large. The request may be resubmitted after reducing the size of the request header fields. </summary>
  RequestHeaderFieldsTooLarge = _431,
  /// <summary> The server is unwilling to process the request because its header fields are too large. The request may be resubmitted after reducing the size of the request header fields. </summary>
  REQUEST_HEADER_FIELDS_TOO_LARGE = _431,

  /// <summary> The user agent requested a resource that cannot legally be provided, such as a web page censored by a government. </summary>
  _451 = 451,
  /// <summary> The user agent requested a resource that cannot legally be provided, such as a web page censored by a government. </summary>
  _451_Unavailable_For_Legal_Reasons = _451,
  /// <summary> The user agent requested a resource that cannot legally be provided, such as a web page censored by a government. </summary>
  UnavailableForLegalReasons = _451,
  /// <summary> The user agent requested a resource that cannot legally be provided, such as a web page censored by a government. </summary>
  UNAVAILABLE_FOR_LEGAL_REASONS = _451,

  //#endregion

  //#region Server error responses (500 – 599)
  // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

  /// <summary> The server has encountered a situation it does not know how to handle. This error is generic, indicating that the server cannot find a more appropriate 5XX status code to respond with. </summary>
  _500 = 500,
  /// <summary> The server has encountered a situation it does not know how to handle. This error is generic, indicating that the server cannot find a more appropriate 5XX status code to respond with. </summary>
  _500_Internal_Server_Error = _500,
  /// <summary> The server has encountered a situation it does not know how to handle. This error is generic, indicating that the server cannot find a more appropriate 5XX status code to respond with. </summary>
  InternalServerError = _500,
  /// <summary> The server has encountered a situation it does not know how to handle. This error is generic, indicating that the server cannot find a more appropriate 5XX status code to respond with. </summary>
  INTERNAL_SERVER_ERROR = _500,

  /// <summary> The request method is not supported by the server and cannot be handled. The only methods that servers are required to support (and therefore that must not return this code) are GET and HEAD. </summary>
  _501 = 501,
  /// <summary> The request method is not supported by the server and cannot be handled. The only methods that servers are required to support (and therefore that must not return this code) are GET and HEAD. </summary>
  _501_Not_Implemented = _501,
  /// <summary> The request method is not supported by the server and cannot be handled. The only methods that servers are required to support (and therefore that must not return this code) are GET and HEAD. </summary>
  NotImplemented = _501,
  /// <summary> The request method is not supported by the server and cannot be handled. The only methods that servers are required to support (and therefore that must not return this code) are GET and HEAD. </summary>
  NOT_IMPLEMENTED = _501,

  /// <summary> This error response means that the server, while working as a gateway to get a response needed to handle the request, got an invalid response. </summary>
  _502 = 502,
  /// <summary> This error response means that the server, while working as a gateway to get a response needed to handle the request, got an invalid response. </summary>
  _502_Bad_Gateway = _502,
  /// <summary> This error response means that the server, while working as a gateway to get a response needed to handle the request, got an invalid response. </summary>
  BadGateway = _502,
  /// <summary> This error response means that the server, while working as a gateway to get a response needed to handle the request, got an invalid response. </summary>
  BAD_GATEWAY = _502,

  /// <summary>
  /// The server is not ready to handle the request. Common causes are a server that is down for maintenance or that is overloaded. Note that together with this response, a user-friendly page explaining the problem should be sent.
  /// This response should be used for temporary conditions and the Retry-After HTTP header should, if possible, contain the estimated time before the recovery of the service. 
  /// The webmaster must also take care about the caching-related headers that are sent along with this response, as these temporary condition responses should usually not be cached.
  /// </summary>
  _503 = 503,
  /// <summary>
  /// The server is not ready to handle the request. Common causes are a server that is down for maintenance or that is overloaded. Note that together with this response, a user-friendly page explaining the problem should be sent.
  /// This response should be used for temporary conditions and the Retry-After HTTP header should, if possible, contain the estimated time before the recovery of the service. 
  /// The webmaster must also take care about the caching-related headers that are sent along with this response, as these temporary condition responses should usually not be cached.
  /// </summary>
  _503_Service_Unavailable = _503,
  /// <summary>
  /// The server is not ready to handle the request. Common causes are a server that is down for maintenance or that is overloaded. Note that together with this response, a user-friendly page explaining the problem should be sent.
  /// This response should be used for temporary conditions and the Retry-After HTTP header should, if possible, contain the estimated time before the recovery of the service. 
  /// The webmaster must also take care about the caching-related headers that are sent along with this response, as these temporary condition responses should usually not be cached.
  /// </summary>
  ServiceUnavailable = _503,
  /// <summary>
  /// The server is not ready to handle the request. Common causes are a server that is down for maintenance or that is overloaded. Note that together with this response, a user-friendly page explaining the problem should be sent.
  /// This response should be used for temporary conditions and the Retry-After HTTP header should, if possible, contain the estimated time before the recovery of the service. 
  /// The webmaster must also take care about the caching-related headers that are sent along with this response, as these temporary condition responses should usually not be cached.
  /// </summary>
  SERVICE_UNAVAILABLE = _503,

  /// <summary> This error response is given when the server is acting as a gateway and cannot get a response in time. </summary>
  _504 = 504,
  /// <summary> This error response is given when the server is acting as a gateway and cannot get a response in time. </summary>
  _504_Gateway_Timeout = _504,
  /// <summary> This error response is given when the server is acting as a gateway and cannot get a response in time. </summary>
  GatewayTimeout = _504,
  /// <summary> This error response is given when the server is acting as a gateway and cannot get a response in time. </summary>
  GATEWAY_TIMEOUT = _504,

  /// <summary> The HTTP version used in the request is not supported by the server. </summary>
  _505 = 505,
  /// <summary> The HTTP version used in the request is not supported by the server. </summary>
  _505_HTTP_Version_Not_Supported = _505,
  /// <summary> The HTTP version used in the request is not supported by the server. </summary>
  HTTPVersionNotSupported = _505,
  /// <summary> The HTTP version used in the request is not supported by the server. </summary>
  HTTP_VERSION_NOT_SUPPORTED = _505,

  /// <summary> The server has an internal configuration error = during content negotiation, the chosen variant is configured to engage in content negotiation itself, which results in circular references when creating responses. </summary>
  _506 = 506,
  /// <summary> The server has an internal configuration error = during content negotiation, the chosen variant is configured to engage in content negotiation itself, which results in circular references when creating responses. </summary>
  _506_Variant_Also_Negotiates = _506,
  /// <summary> The server has an internal configuration error = during content negotiation, the chosen variant is configured to engage in content negotiation itself, which results in circular references when creating responses. </summary>
  VariantAlsoNegotiates = _506,
  /// <summary> The server has an internal configuration error = during content negotiation, the chosen variant is configured to engage in content negotiation itself, which results in circular references when creating responses. </summary>
  VARIANT_ALSO_NEGOTIATES = _506,

  /// <summary> The method could not be performed on the resource because the server is unable to store the representation needed to successfully complete the request. (WebDAV) </summary>
  _507 = 507,
  /// <summary> The method could not be performed on the resource because the server is unable to store the representation needed to successfully complete the request. (WebDAV) </summary>
  _507_Insufficient_Storage = _507,
  /// <summary> The method could not be performed on the resource because the server is unable to store the representation needed to successfully complete the request. (WebDAV) </summary>
  InsufficientStorage = _507,
  /// <summary> The method could not be performed on the resource because the server is unable to store the representation needed to successfully complete the request. (WebDAV) </summary>
  INSUFFICIENT_STORAGE = _507,

  /// <summary> The server detected an infinite loop while processing the request. (WebDAV) </summary>
  _508 = 508,
  /// <summary> The server detected an infinite loop while processing the request. (WebDAV) </summary>
  _508_Loop_Detected = _508,
  /// <summary> The server detected an infinite loop while processing the request. (WebDAV) </summary>
  LoopDetected = _508,
  /// <summary> The server detected an infinite loop while processing the request. (WebDAV) </summary>
  LOOP_DETECTED = _508,

  /// <summary> The client request declares an HTTP Extension (RFC 2774) that should be used to process the request, but the extension is not supported. </summary>
  _510 = 510,
  /// <summary> The client request declares an HTTP Extension (RFC 2774) that should be used to process the request, but the extension is not supported. </summary>
  _510_Not_Extended = _510,
  /// <summary> The client request declares an HTTP Extension (RFC 2774) that should be used to process the request, but the extension is not supported. </summary>
  NotExtended = _510,
  /// <summary> The client request declares an HTTP Extension (RFC 2774) that should be used to process the request, but the extension is not supported. </summary>
  NOT_EXTENDED = _510,

  /// <summary> Indicates that the client needs to authenticate to gain network access. </summary>
  _511 = 511,
  /// <summary> Indicates that the client needs to authenticate to gain network access. </summary>
  _511_Network_Authentication_Required = _511,
  /// <summary> Indicates that the client needs to authenticate to gain network access. </summary>
  NetworkAuthenticationRequired = _511,
  /// <summary> Indicates that the client needs to authenticate to gain network access. </summary>
  Network_Authentication_Required = _511,

  //#endregion
};