using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GoodsDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    public class GeneralController : Controller
    {
        public IActionResult Index()
        {
            return Json("Welecome GoodsDemo General Index");
        }
    }
}