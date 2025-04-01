using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
  [HttpGet("Operacion-venta")]
  public IActionResult OperacionVenta(){
       return Ok();
  }

}