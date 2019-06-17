using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cookieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        // GET api/brand
        [HttpGet]
        public ActionResult<string> Get()
        {
            // string cookies = "";
            foreach (var item in Request.Cookies)
            {
                if (item.Key == "csb-brand")
                {
                    return item.Value;
                }
                // cookies += item.Key + "=" + item.Value + ",";
            }
            // return cookies;
            return string.Empty;
        }

        [HttpPost("{brand}")]
        public ActionResult Post([FromRoute]string brand)
        {
            Response.Cookies.Append("csb-brand", brand);

            return Ok();
        }
    }
}
