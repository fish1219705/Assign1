using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assign1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request with a body and provides a response message.
        /// </summary>
        /// <param name="secret"> An integer value sent in the body of the POST request.</param>
        /// <returns>An HTTP response with a body echoing the request body.</returns>
        /// <example>
        /// POST api/q5/secret
        /// HEADERS: Content-Type: application/json
        /// FORM DATA: {secret}
        /// -> A post method with a request body. Body Content: {secret}
        /// </example>
        [HttpPost(template: "secret")]
        public string secret([FromBody] int secret)
        {

            return $"Shh.. the secret is {secret}";
        }
    }
}
