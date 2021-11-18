using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using SistemaWebTatuajes.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class TendenciasController : Controller
    {
        private IWebHostEnvironment _enviroment;
        private readonly ITendenciasService _tendenciasService;

        public TendenciasController(IWebHostEnvironment enviroment, ITendenciasService tendenciasService)
        {
            _enviroment = enviroment;
            _tendenciasService = tendenciasService;
        }

        public IActionResult Index()
        {
            return View();
        }

        //METODO PARA INSERTAR TENDENCIAS
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(TendenciasViewModel tendenciasViewModel)
        {
            int msj = 0;
            try
            {
                if (ModelState.IsValid)
                {
                    //GUARDO EN BD
                    Tendencias tendencias = new Tendencias();
                    tendencias.Ruta = tendenciasViewModel.TipoTatuaje.FileName;
                    tendencias.Tipo = tendenciasViewModel.Nombre;
                    await _tendenciasService.Insert(tendencias);
                    //GUARDO EN CARPETA
                    var filename = Path.Combine(_enviroment.ContentRootPath, "wwwroot/Tendencias", tendenciasViewModel.TipoTatuaje.FileName);
                    using FileStream stream = new FileStream(filename, FileMode.Create);
                    await tendenciasViewModel.TipoTatuaje.CopyToAsync(stream);
                    msj = 1;
                }
            }
            catch (Exception)
            {
                msj = 2;
            }
            return Json(msj);
        }

        //METODO PARA ELIMINAR
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id != 0)
                {
                    string nombre = await _tendenciasService.Delete(id);
                    var fotoTatuaje = Path.Combine(_enviroment.ContentRootPath, "wwwroot/Tendencias", nombre);
                    System.IO.File.Delete(fotoTatuaje);
                }
            }
            catch (Exception)
            {

            }
            return RedirectToAction("Get", "Tendencias");
        }

        //METODO PARA LISTAR
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Tendencias> list = null;
            try
            {
                var res = await _tendenciasService.Get();
                if (res != null)
                {
                    list = new List<Tendencias>();
                    list = res.ToList();
                }
            }
            catch (Exception)
            {

            }
            return View(list);
        }

        //METODO QUE LISTA LAS TENDENCIAS
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> UltimasTendencias()
        {
            IEnumerable<Tendencias> list = null;
            try
            {
                var res = await _tendenciasService.Get();
                if (res != null)
                {
                    list = new List<Tendencias>();
                    list = res.ToList();
                }
            }
            catch (Exception)
            {

            }
            return View(list);
        }

    }
}
