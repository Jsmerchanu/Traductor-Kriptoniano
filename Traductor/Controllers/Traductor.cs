﻿using Microsoft.AspNetCore.Mvc;
using Traductor.Models;



namespace Traductor.Controllers
{
    public class TraductorController : Controller
    {
        private readonly TraductorModel _traductorModel;
       

        public TraductorController(TraductorModel traductorModel)
        {
            _traductorModel = traductorModel;
        }

        [HttpPost]
        public IActionResult Traducir(string texto, string kripto)
        {
            texto = texto.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                // Manejar el caso de texto vacío, por ejemplo, mostrando un mensaje de error
                return RedirectToAction("Error");
            }
            var rutasSvg1= new List<(char Letra, string RutaSvg)>();
            var rutasSvg = new List<(char Letra, string RutaSvg)>();
            foreach (char letra in texto)
            {
                string rutaSvg = _traductorModel.ObtenerRutaSvg(letra);
                rutasSvg.Add((letra, rutaSvg));
                string rutaSvg1 = _traductorModel.ObtenerRutaSvg(letra);
                rutasSvg1.Add((letra, rutaSvg));
            }
            rutasSvg1.Reverse();
            var viewModel = new TraductorViewModel
            {
                RutasSvg1 = rutasSvg1,
                RutasSvg = rutasSvg,
                Kripto = kripto
            };
            // Verificar si el viewModel es null antes de pasar a la vista
            if (viewModel != null)
            {
                return View(viewModel);
            }
            else
            {
                // Manejar el caso de viewModel null, por ejemplo, redireccionar a una página de error
                return RedirectToAction("Error");
            }
            
           
        }
    }

}

