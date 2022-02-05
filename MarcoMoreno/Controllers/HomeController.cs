using MarcoMoreno.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MarcoMoreno.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Simular los datos como que estoy usando base de datos

            List<Paciente> paciente = new List<Paciente>();
            paciente.Add(new Paciente()
            {
                Nombre = "Otro Nombre",
                Direccion = "Otra Direccion",
                Telefono = "10234567",
                Edad = 20
                

            });
            paciente.Add(new Paciente()
            {
                Nombre = "Marco Moreno",
                Direccion = "Nindiri",
                Telefono = "10234567",
                Edad = 25
                

            });

            return View(paciente);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Prueba()
        {
            return View();
        }
            

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
