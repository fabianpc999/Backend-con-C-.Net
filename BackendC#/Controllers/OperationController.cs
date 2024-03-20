using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendC_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        [HttpGet]
        public decimal Get(decimal a, decimal b)
        {
            return a + b;
        }

        // El body se utiliza principalmente para peticiones Post y Put

        // El header o encabezados contienen informacion adicional que es util

        // para obtener informacion del header agregamos como argumento la propiedad FromHeader seguido del tipo y atributo que queremos obtener lo cual puede ser almacenadoo en una variable

        [HttpPost]
        public decimal Add(Numbers numbers, [FromHeader] string Connection,
            [FromHeader(Name ="Content-Length")] string ContentLength, [FromHeader] string Host)
        {
            Console.WriteLine(Connection);
            Console.WriteLine(ContentLength);
            Console.WriteLine(Host);
            return numbers.A - numbers.B;
        }

        [HttpPut]
        public decimal Edit(decimal a, decimal b)
        {
            return a * b;
        }

        [HttpDelete]
        public decimal Delete(decimal a, decimal b)
        {
            return a / b;
        }
    }

    public class Numbers
    {
        public decimal A { get; set; }
        public decimal B { get; set; }
    }
}
