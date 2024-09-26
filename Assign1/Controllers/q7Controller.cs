using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assign1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request with one query parameter and provides a response message.
        /// </summary>
        /// <param name="days">The number of days to add (positive) or subtract (negative) from the current date.</param>
        /// <returns>An HTTP response with a body indicating the usage, echoing the value of days.</returns>
        /// <example>
        /// GET api/q7/timemachine?days=1 -> 2024-09-25 (if called on Sep 24,2024)
        /// GET api/q7/timemachine?days=-1 -> 2024-09-23 (if called on Sep 24,2024)
        /// </example>
        [HttpGet(template: "timemachine")]
        public string timemachine(int days)
        {
            DateTime today = DateTime.Today;
            DateTime date2 = today.AddDays(days);
            string day = date2.ToString("yyyy-MM-dd");
            return day;
        }
    }
}
