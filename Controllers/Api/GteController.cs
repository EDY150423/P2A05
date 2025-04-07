using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gte")]
public class GteController : Controller {

  [HttpGet("costo")]
  public IActionResult Costo(){
    // 1. Muestra todos los registros cuyo costo sea mayor o igual a 500,000
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.Costo, 500000);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("pisos")]
  public IActionResult Pisos(){
    // 2. Muestra todos los registros con 4 o más pisos
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.Pisos, 4);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("metros_terreno")]
  public IActionResult  MetrosTerreno(){
    // Consulta 3 - Muestra todos los registros cuya superficie de terreno (metros-terreno) sea mayor o igual a 200 m²
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosTerreno, 200);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("banios")]
  public IActionResult Banios(){
    // 4. Muestra todos los registros con 3 o más baños
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.Banios, 3);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("fecha_publicacion")]
  public IActionResult FechaPublicacion(){
    // Consulta 5 - Muestra todos los registros cuya fecha de publicación sea igual o posterior a 2023-01-01
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.FechaPublicacion, "2023-01-01");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

}