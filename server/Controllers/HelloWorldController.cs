using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class DestinationsController : ControllerBase
{
    // Sample data (You would typically get this from a database)
    private static List<string> destinations = new List<string>
    {
        "Paris", "New York", "Tokyo", "Sydney"
    };

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return destinations;
    }

    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        
        if (id < 0 || id >= destinations.Count)
            return NotFound();

        return destinations[id];
    }

    [HttpPost]
    public ActionResult Add([FromBody] string destination)
    {
        destinations.Add(destination);
        return Ok();
    }
}