using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Test.Controllers
{
    public class TestController : Controller
    {
        public TestController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
