using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hamfer.WebApi.Server.Models;

/// <summary>
/// The Web-Api suited Controller-Base
/// </summary>
[ApiController]
public abstract class WebApiControllerBase: ControllerBase
{
}