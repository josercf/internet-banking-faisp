using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetBanking.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternetBanking.Controllers
{
    public class CorrentistaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            var model = new NovoCorrentista();
            return View(model);
        }

        [HttpPost]
        public IActionResult Cadastrar(NovoCorrentista model)
        {
            //Criamos a variavél idadeValida que armazena o 
            //resultado da validação da regra de negócio da idade 
            //ser maior ou igual a 16
            var idadeValida = model.ValidarIdade();


            if(idadeValida == false)
            {
                ModelState.AddModelError("DataNascimento", "É necessário a idade maior ou igual a 16 anos");
            }


            return View(model);
        }
    }
}