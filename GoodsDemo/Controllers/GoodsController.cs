using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GoodsDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    public class GoodsController : Controller
    {
        [HttpGet]
        public IActionResult GetGoodsInfo()
        {
            var ret = new
            {
                GoodsId = 1,
                GoodsName = "NARS",
                Export = "Freach"
            };
            return Json(ret);
        }
    }
}