using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica_Odontologica.Dados;
using Clinica_Odontologica.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinica_Odontologica.Controllers
{
    public class PacienteController : Controller
    {

        public IActionResult Cadastrar()
        {   
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Paciente paciente)
        {
            int id = BancoDeDados.Instance().GetPacientes().Count + 1;
            paciente.Id = id;

            BancoDeDados.Instance().Add(paciente);

            ViewData["exibirAlert"] = true;

            ModelState.Clear();

            return View("Cadastrar");
        }
        public IActionResult Deletar(int id)
        {
            BancoDeDados.Instance().Remover(id);
            return RedirectToAction("Index", "Home");
        }
    }
}