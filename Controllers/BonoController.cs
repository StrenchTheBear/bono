using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bono.Models;
using bono.Data;


namespace BONO.Controllers
{
    public class BonoController : Controller
    {

       private readonly ILogger<BonoController> _logger;

       private readonly DatabaseContext _context;

        public BonoController(ILogger<BonoController> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(BONO.Models.bono objbono){
            if (ModelState.IsValid)
            {
                _context.Add(objbono);
                _context.SaveChanges();      
                
                objbono.Response = "AVILCAYÂÑEZ";
            }
            return View("index", objbono);
        }

    }
}