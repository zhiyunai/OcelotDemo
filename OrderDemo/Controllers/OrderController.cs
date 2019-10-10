using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult GetOrderInfo()
        {
            var ret = new
            {
                OrderId = "oce16271387",
                GoodsId = 1,
                Count = 2,
                Price = 261
            };
            return Json(ret);
        }
    }
}