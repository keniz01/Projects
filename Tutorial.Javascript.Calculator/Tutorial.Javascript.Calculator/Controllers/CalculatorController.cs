using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tutorial.Javascript.Calculator.Controllers
{
    [Route("[Controller]")]
    public class CalculatorController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}