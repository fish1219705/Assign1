using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Assign1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {
        /// <summary>
        ///  Receives an HTTP POST request with a form-encoded body containing two parameters.
        /// </summary>
        /// <param name="Small">The number of small squash ordered, provided as a form parameter.</param>
        /// <param name="Large">The number of large squash ordered, provided as a form parameter.</param>
        /// <returns><returns>An HTTP response with a body echoing the request body parameters.</returns>
        /// <example>
        /// POST api/q8/squashfellows
        /// HEADERS: Content-Type: application/x-www-form-urlencoded
        /// FORM DATA: "Small=1&Large=1"
        /// -> A post method with a form encoded request body. Body Content: 1 Small; 1 Large
        /// POST api/q8/squashfellows
        /// HEADERS: Content-Type: application/x-www-form-urlencoded
        /// FORM DATA: "Small=100&Large=100"
        /// -> A post method with a form encoded request body. Body Content: 100 Small; 100 Large
        /// </example> 

        [HttpPost(template: "squashfellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string squashfellows([FromForm] int Small, [FromForm] int Large)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            double sprice = Math.Round(Small * 25.50, 2);
            string smoney = sprice.ToString("C2", CultureInfo.CurrentCulture);
            double lprice = Math.Round(Large * 40.50, 2);
            string lmoney = lprice.ToString("C2", CultureInfo.CurrentCulture);
            double subprice = Math.Round((sprice + lprice), 2);
            string submoney = subprice.ToString("C2", CultureInfo.CurrentCulture);
            double tax = Math.Round(subprice * 0.13, 2);
            string taxm = tax.ToString("C2", CultureInfo.CurrentCulture);
            double total = Math.Round((subprice + tax), 2);
            string totalm = total.ToString("C2", CultureInfo.CurrentCulture);
            return $"{Small} Small @ $25.50 = {smoney}; {Large} Large @ $40.50 = {lmoney}; Subtotal = {submoney}; Tax = {taxm} HST; Total = {totalm}";
        }
    }
}
