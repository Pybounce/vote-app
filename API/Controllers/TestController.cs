using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class TestController : Controller
{
    [HttpGet("HelloWorld")]
    public string HelloWorld()
    {
        return "Hello World!";
    }
}


