using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assign1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request with one query parameter and provides a response message.
        /// </summary>
        /// <param name="name"> A string query parameter representing the name of the person to greet. </param>
        /// <returns>An HTTP response with a body indicating the usage, echoing the value of name.</returns>
        /// <example>
        /// GET api/q2/greeting?name=Anna -> "Hi Anna!"
        /// GET api/q2/greeting?name=Elaine -> "Hi Elaine!"
        ///  GET api/q2/greeting?name=Jason -> "Hi Jason!"
        /// </example>
        [HttpGet(template: "greeting")]
        public string greeting(string name)
        {

            return $"Hi {name}!";
        }
    }
}
