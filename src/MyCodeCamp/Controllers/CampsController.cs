using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NamespaceName
{

  [Route("api/[controller]")]
  public class CampsController : Controller
  {

    [HttpGet()]
    public IActionResult Get()
    {
      return Ok(new {name="mohammad",family="ahmadi"});
    }

  }
}