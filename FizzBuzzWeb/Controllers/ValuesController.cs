using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            string FizzBuzzString = "";

            try
            {
                short number = Convert.ToInt16(id);

                if (number < 0 || number > 1000)
                    throw new OverflowException();

                if (number % 2 == 0)
                    FizzBuzzString = "Fizz";

                if (number % 3 == 0)
                    FizzBuzzString += "Buzz";

                Console.Write("A wiec: ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(FizzBuzzString);
                Console.ResetColor();



                if (FizzBuzzString.Equals(""))
                    Console.WriteLine("\n:[");

                return FizzBuzzString;

            }
            catch (OverflowException)
            {
                return "Liczba poza zakresem. Zakres jest od 0 do 1000\nSprobuj jeszcz raz.";
            }

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
