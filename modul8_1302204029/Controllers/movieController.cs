using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul8_1302204029.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class movieController : ControllerBase
    {
        private static List<Movies> listMovies = new List<Movies>()
        {
            new Movies("The Shawshank Redemption", "Frank Darabont", new List<string>(){"Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler" }, "wo imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
            new Movies("The Godfather", "Francis Ford Coppola", new List<string>(){ "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton "}, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movies("The Dark Knight", "Christopher Nolan", new List<string>(){ "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"}, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."),
        };
        // GET: api/<movieController>
        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            return listMovies;
        }

        // GET api/<movieController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<movieController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<movieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<movieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
