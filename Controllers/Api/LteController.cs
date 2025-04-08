using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lte")]
public class LteController : Controller {
  
  [HttpGet("costo")]
  public IActionResult Costo(){
    // 1. Muestra todos los registros cuyo costo sea menor o igual a 3,000,000
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.Costo, 3000000);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("metros_construccion")]
  public IActionResult MetrosConstruccion(){
    // 2. Muestra todos los registros cuya superficie de construcción (metros-construcción) sea menor o igual a 70 m²
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosConstruccion, 70);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("baños")]
  public IActionResult Banios(){
    // 3. Muestra todos los registros con 1 o menos baño
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.Banios, 1);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }
  
  [HttpGet("fecha_publicacion")]
  public IActionResult FechaPublicacion(){
    // 4. Muestra todos los registros cuya fecha de publicación sea igual o anterior a 2023-01-01
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.FechaPublicacion, "2023-01-01");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

}
