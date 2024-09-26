using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assign1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request with an empty body and provides a response message.
        /// </summary>
        /// <returns>An HTTP response with a body indicating the usage.</returns>
        /// <example>
        /// POST api/q4/knockknock
        /// FORM DATA: (empty)
        /// -> Received a POST request with no request body
        /// </example>
        [HttpPost(template: "knockknock")]
        public string knockknock()
        {
            return "Who's there?";
        }
    }
}
