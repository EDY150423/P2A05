using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lt")]
public class LtController : Controller {
  
  [HttpGet("costo")]
  public IActionResult Costo(){
    // 1. Muestra todos los registros cuyo costo sea menor a 500,000
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lt(x => x.Costo, 500000);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("pisos")]
  public IActionResult Pisos(){
    // 2. Muestra todos los registros con menos de 2 pisos
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lt(x => x.Pisos, 2);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("metros_construccion")]
  public IActionResult MetrosConstruccion(){
    // 3. Muestra todos los registros cuya superficie de construcción (metros-construcción) sea menor a 50 m²
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosConstruccion, 50);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("baños")]
  public IActionResult Banios(){
    // 4. Muestra todos los registros con menos de 3 baños
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lt(x => x.Banios, 3);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("metros_terreno")]
  public IActionResult MetrosTerreno(){
    // 5. Muestra todos los registros cuya superficie de terreno (metros-terreno) sea menor a 500 m²
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosTerreno, 500);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }
}
