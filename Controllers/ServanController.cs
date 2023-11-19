using Microsoft.AspNetCore.Mvc;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServanController : ControllerBase
    { 

        public class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
 

        [HttpGet]
        public IActionResult GetPerson()
        {
            // Örnek bir kişi oluştur
            var person = new Person
            { 
                FirstName = "Servan",
                LastName = "KILINC",
                Age = 24
            };

            // JSON formatında sonuç döndür
            return new JsonResult(person);
        }
 
    }
}