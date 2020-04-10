using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Clinica_Odontologica.Models;
using Clinica_Odontologica.Dados;

namespace Clinica_Odontologica.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
           

            return View(BancoDeDados.Instance().GetPacientes());
        }
    }
}
