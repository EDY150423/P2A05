using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/ne")]
public class NeController : Controller {
  
  [HttpGet("operacion")]
  public IActionResult Operacion(){
    // 1. Muestra todos los registros cuya operación no sea "Venta"
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Operacion, "Venta");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("banios")]
  public IActionResult Banios(){
    // 2. Muestra todos los registros con número de baños diferente de 2
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Banios, 2);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("tipo")]
  public IActionResult Tipo(){
    // 3. Muestra todos los registros cuyo tipo de inmueble no sea "Casa"
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Tipo, "Casa");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("nombre_agente")]
  public IActionResult NombreAgente(){
    // 4. Muestra todos los registros cuyo agente no sea "Carlos García"
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.NombreAgente, "Carlos García");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("agencia")]
  public IActionResult Agencia(){
    // 5. Muestra todos los registros cuya agencia no sea "Inmobiliaria López"
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Agencia, "Inmobiliaria López");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }
}