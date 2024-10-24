using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    private static readonly string helloWorld = "Hello, World!";

    [HttpGet]
    public ActionResult<string> Get()
    {
        var response = new { message = helloWorld };
        return Ok(response);
    }
}