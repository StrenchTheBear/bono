using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bono.Models;

namespace BONO.Controllers
{
    public class BonoController : Controller
    {

       private readonly ILogger<BonoController> _logger;

        public BonoController(ILogger<BonoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(BONO.Models.bono objbono){
            if (ModelState.IsValid)
            {
                objbono.Response = "Registro de Base de Datos (*)";
            }
            return View("index", objbono);
        }

    }
}