using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica_Odontologica.Dados;
using Clinica_Odontologica.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinica_Odontologica.Controllers
{
    public class ProcedimentoController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Procedimento procedimento)
        {
            int id = BancoDeDados.Instance().GetProcedimentos().Count + 1;
            procedimento.Id = id;

            BancoDeDados.Instance().Add(procedimento);

            ViewData["exibirAlert"] = true;

            ModelState.Clear();

            return View("Cadastrar");
        }
    }
}