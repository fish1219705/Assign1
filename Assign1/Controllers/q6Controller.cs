using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assign1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request with one query parameter and provides a response message.
        /// </summary>
        /// <param name="side">The length of the side of the hexagon, passed as a query parameter.</param>
        /// <returns>An HTTP response with a body indicating the usage, echoing the value of side.</returns>
        /// <example>
        /// GET api/q6/hexagon?side=1 -> 2.598076211353316
        /// GET api/q6/hexagon?side=1.5 -> 5.845671475544961
        /// GET api/q6/hexagon?side=20 -> 1039.2304845413264
        /// </example>
        [HttpGet(template: "hexagon")]
        public double hexagon(double side)
        {
            double db = Math.Pow(side, 2);
            double sq = Math.Sqrt(3);
            
            double result = db * sq * 3 / 2;
            return result;
        }
    }
}
