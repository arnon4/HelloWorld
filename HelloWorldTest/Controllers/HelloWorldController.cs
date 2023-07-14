using Microsoft.AspNetCore.Mvc;
using MyWrapper;

namespace HelloWorldTest.Controllers; 
[ApiController]
public sealed class HelloWorldController : ControllerBase {
    private readonly Wrapper _wrapper;
    public HelloWorldController(Wrapper wrapper) => _wrapper = wrapper;

    [HttpGet("/")]
    public string GetHello() {
        _wrapper.Information("In Hello");
        return "Hello World";
    }
}