using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assign1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request with one integer route parameter and provides a response message.
        /// </summary>
        /// <param name="baseN">An integer route parameter representing the base number used for calculating the cube.</param>
        /// <returns>An HTTP response with a body echoing the value of routeParam1.</returns>
        /// <example>
        /// GET api/q3/cube/9 -> 729
        /// GET api/q3/cube/5 -> 125
        /// GET api/q3/cube/7 -> 343
        /// </example>
        [HttpGet(template: "cube/{baseN:int}")]
        public int cube(int baseN)
        {
            int cubeN = baseN * baseN * baseN;
            return cubeN;
        }
    }
}
