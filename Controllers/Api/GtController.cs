using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
public class GtController : Controller {
  [HttpGet("costo")]
  public IActionResult Costo(){
      // 1. Muestra todos los registros cuyo costo sea mayor a 1000000
      MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
      var db = client.GetDatabase("Inmuebles");
      var collection = db.GetCollection<Inmueble>("RentasVentas");
       
      var filtro = Builders<Inmueble>.Filter.Gt(x  => x.Costo, 1000000);
      var lista = collection.Find(filtro).ToList();
      return Ok(lista);
  }

  [HttpGet("pisos")]
  public IActionResult Pisos(){
    // 2. Muestra todos los registros con mas de dos pisos 
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gt(x => x.Pisos, 2);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("metros_construccion")]
  public IActionResult MetrosConstruccion(){
    // 3. Muestra todos los registros cuya superficie de construccion (metros-construccion) sea mayor a 150 m2
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosConstruccion, 150);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("metros_terreno")]
  public IActionResult MetrosTerreno(){
    // 4. Muestra todos los registros con mas de 500 m2 de terreno
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosTerreno, 500);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("Banios")]
  public IActionResult Banios(){
    // 5. Muestra todos los registros cuyo numero de baños sea mayor a 3
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gt(x => x.Banios, 3);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

}