using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestSample.Models;

namespace TestSample.Controllers
{

    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
