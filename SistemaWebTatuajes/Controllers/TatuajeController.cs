using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Controllers
{
    [Authorize(Roles = "Administrador,Usuario")]
    public class TatuajeController : Controller
    {
        private ITatuajeService _service;
        private IArtistaService _serviceArtista;
        private IWebHostEnvironment _enviroment;

        public TatuajeController(ITatuajeService service, IWebHostEnvironment enviroment, IArtistaService serviceArtista)
        {
            _service = service;
            _enviroment = enviroment;
            _serviceArtista = serviceArtista;
        }
        //METODO QUE ME RETORNA LA VISTA DE AGREGAR LOS TATUAJES POR AUTOR, PARA LLENAR EL COMBO BOX EN registro de tatuajes por artista
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var list = await _serviceArtista.getArtistas();
                List<SelectListItem> listitem = list.ConvertAll(i =>
                {
                    return new SelectListItem()
                    {
                        Text = i.Nombre,
                        Value = i.Id_Artista.ToString()
                    };

                });
                ViewBag.items = listitem;
            }
            catch (Exception)
            {

            }
            return View();
        }
        //METODO PARA INSERTAR TATUAJES
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(TatuajeViewModel tatuajeViewModel)
        {
            int msj = 0;
            try
            {
                if (ModelState.IsValid)
                {                 
                    await _service.Insert(tatuajeViewModel.Id_Artista,getFotos(tatuajeViewModel.tatuajes));
                    await GuardarFotosCarpeta(tatuajeViewModel);
                    msj = 1;
                }
            }
            catch (Exception ex)
            {
                msj = 2;
            }
            return Json(msj);
        }
        //METODO PARA OBTENER UN ARREGLO DE LAS FOTOS DE TATUAJES DE CADA ARTISTA(METODO DE ARRIBA)
        public string[] getFotos(IFormFile []fotos)
        {
            string[] nom = new string[fotos.Length];
            int pos = 0;
            foreach (var i in fotos)
            {
                nom[pos] = i.FileName;
                pos++;
            }
            return nom;
        }
        //METODO PARA GUARDAR EN CARPETA EN WWWWROOT/TIPOS
        public async Task GuardarFotosCarpeta(TatuajeViewModel tatuajeViewModel)
        {
            foreach (var i in tatuajeViewModel.tatuajes) {
                var filename = Path.Combine(_enviroment.ContentRootPath, "wwwroot/Tipos", i.FileName);
                using FileStream stream = new FileStream(filename, FileMode.Create);
                await i.CopyToAsync(stream);
            }
        }
    }
}
