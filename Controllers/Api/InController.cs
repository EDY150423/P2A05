using Microsoft.AspNetCore.Mvc;
 using MongoDB.Driver;
 
 [ApiController]
 [Route("api/in")]
 public class InController : Controller {
   
   [HttpGet("operacion")]
   public IActionResult Operacion(){
     // 1. Muestra todos los registros donde la operación sea "Renta" o "Venta"
     MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
     var db = client.GetDatabase("Inmuebles");
     var collection = db.GetCollection<Inmueble>("RentasVentas");
 
     List<string> operaciones = new List<string>();
     operaciones.Add("Renta");
     operaciones.Add("Terreno");
     var filtro =Builders<Inmueble>.Filter.In(x => x.Operacion, operaciones);
     var lista =collection.Find(filtro).ToList();
     return Ok(lista);
   }
   
   [HttpGet("agencia")]
   public IActionResult Agencia(){
     // Muestra todos los registros cuyo agencia sea "Inmobiliaria Perez" o "Fernandez Inmuebles"
     MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
     var db = client.GetDatabase("Inmuebles");
     var collection = db.GetCollection<Inmueble>("RentasVentas");
 
     List<string> agencias = new List<string>();
     agencias.Add("Inmobiliaria Pérez");
     agencias.Add("Fernández Inmuebles");
     var filtro =Builders<Inmueble>.Filter.In(x => x.Agencia, agencias);
     var lista =collection.Find(filtro).ToList();
     return Ok(lista);
   }
 
   [HttpGet("tipo")]
   public IActionResult Tipo(){
     // Muestra todos los registros cuyo tipo de inmueble sea "Casa" o "Terreno"
     MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
     var db = client.GetDatabase("Inmuebles");
     var collection = db.GetCollection<Inmueble>("RentasVentas");
 
     List<string> tipos = new List<string>();
     tipos.Add("Casa");
     tipos.Add("Terreno");
     var filtro =Builders<Inmueble>.Filter.In(x => x.Tipo, tipos);
     var lista =collection.Find(filtro).ToList();
     return Ok(lista);
   }
 
   [HttpGet("nombre_agente")]
   public IActionResult NombreAgente(){
     // Muestra todos los registros cuyo nombre-agente sea "Ana Torres" o "Juan Perez"
     MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
     var db = client.GetDatabase("Inmuebles");
     var collection = db.GetCollection<Inmueble>("RentasVentas");
 
     List<string> agentes = new List<string>();
     agentes.Add("Ana Torres");
     agentes.Add("Juan Pérez");
     var filtro =Builders<Inmueble>.Filter.In(x => x.NombreAgente, agentes);
     var lista =collection.Find(filtro).ToList();
     return Ok(lista);
   }
 
   [HttpGet("pisos")]
   public IActionResult Pisos(){
     // Muestra todos los registros cuyo número de pisos sea 2
     MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
     var db = client.GetDatabase("Inmuebles");
     var collection = db.GetCollection<Inmueble>("RentasVentas");
 
     List<int> pisos = new List<int>();
     pisos.Add(1);
     pisos.Add(2);
     var filtro =Builders<Inmueble>.Filter.In(x => x. Pisos, pisos);
     var lista =collection.Find(filtro).ToList();
     return Ok(lista);
   }
 
 }