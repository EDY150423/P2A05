using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/nin")]
public class NinController : Controller {

    // Consulta 1 - Muestra todos los registros cuya operación no sea "Venta"
    [HttpGet("operacion")]
    public IActionResult Operacion(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        // Lista con la operación "Venta" para excluirla
        List<string> operaciones = new List<string> { "Venta" };  
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Operacion, operaciones);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    // Consulta 2 - Muestra todos los registros cuyo nombre-agente no sea "Carlos García"
    [HttpGet("nombre_agente")]
    public IActionResult NombreAgente(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        // Lista con el nombre-agente "Carlos García" para excluirlo
        List<string> agentes = new List<string> { "Carlos García" };  
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.NombreAgente, agentes);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    // Consulta 3 - Muestra todos los registros cuyo tipo de inmueble no sea "Casa"
    [HttpGet("tipo")]
    public IActionResult Tipo(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        // Lista con el tipo "Casa" para excluirlo
        List<string> tipos = new List<string> { "Casa" };  
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Tipo, tipos);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    // Consulta 4 - Muestra todos los registros con número de baños diferente de 3
    [HttpGet("banios")]
    public IActionResult Banios(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        // Lista con el número de baños "3" para excluirlo
        List<int> banios = new List<int> { 3 };  
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Banios, banios);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    // Consulta 5 - Muestra todos los registros cuya fecha de publicación no sea "2025-02-26"
    [HttpGet("fecha_publicacion")]
    public IActionResult FechaPublicacion(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        // Lista con la fecha "2025-02-26" para excluirla
        List<string> fechas = new List<string> { "2025-02-26" };  
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.FechaPublicacion, fechas);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

}
