using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqContperacioroller : Controller {
  [HttpGet("listar-operacion")]
  public IActionResult ListarOperacion(){
      // 1. Muestra todos los registros cuya operación sea "Venta"
      MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
      var db = client.GetDatabase("Inmuebles");
      var collection = db.GetCollection<Inmueble>("RentasVentas");
       
      var filtro = Builders<Inmueble>.Filter.Eq(x  => x.Operacion, "Venta");
      var lista = collection.Find(filtro).ToList();
      return Ok(lista);
  }

  [HttpGet("Tipo-casa")]
  public IActionResult TipoCasa(){
    // 2. Muestra todos los registros cuyo tipo de inmueble sea "Casa"
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Casa");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("nombre_agente")]
  public IActionResult NombreAgente(){
    // 3. Muestra todos los registros cuyo nombre-agente sea "Carlos García"
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, "Carlos García");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("banios")]
  public IActionResult Banios(){
    // 4. Muestra todos los registros con 4 baños
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Banios, 4);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

  [HttpGet("Agencia-inmobiliaria")]
  public IActionResult AgenciaInmobiliaria(){
    // 5. Muestra todos los registros cuya agencia sea "Inmobiliaria Pérez"
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Agencia, "Inmobiliaria Pérez");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
  }

}