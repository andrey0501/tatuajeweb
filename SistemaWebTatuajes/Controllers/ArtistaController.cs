using AutoMapper;
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
    [Authorize(Roles ="Administrador,Usuario")]
    public class ArtistaController : Controller
    {
        private IArtistaService _service;
        private IWebHostEnvironment _enviroment;
        private IMapper _mapper;

        public ArtistaController(IArtistaService service, IWebHostEnvironment enviroment, IMapper mapper)
        {
            _service = service;
            _enviroment = enviroment;
            _mapper = mapper;
        }


        //METODO QUE ME RETORNA LA VISTA DE LISTAR ARTISTAS
        [HttpGet]
        public async Task<IActionResult> Index(int? pagina)
        {
            List<Artistas> list = new List<Artistas>();
            try
            {
                if (pagina == null) pagina = 1;
                int? skip = 10 * (pagina - 1);
                int lenght = 10;

                var res = await _service.GetAll(skip,lenght);
                list = res.Registros;
                ViewBag.totalpaginas = (Math.Ceiling((decimal)res.CantidadRegistros / 10));
            }
            catch (Exception)
            {

            }
            return View(list);
        }
        //METODO MOSTRAR VISTA DE AGREGAR ARTISTAS
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //METODO PARA AGREGAR ARTISTAS
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(ArtistasViewModel artistasViewModel)
        {
            int msj = 0;
            try
            {
                if (ModelState.IsValid)
                {
                    //ESTO ES PARA GUARDAR LA FOTO CON EL NOMBRE DE LA PERSONA QUE SE REGISTRO
                    string[] nombre = artistasViewModel.fotoView.FileName.Split('.');
                    string foto = artistasViewModel.nombre + "-" + artistasViewModel.apellidos + "." + nombre[1];
                    //OBTENGO LOS DATOS;
                    Artistas artista = new Artistas();
                    artista.nombre = artistasViewModel.nombre;
                    artista.apellidos = artistasViewModel.apellidos;
                    artista.bibligrafia = artistasViewModel.bibligrafia;
                    artista.foto = foto.Replace(" ",string.Empty);
                    //GUARDO EN LA BD  
                    await _service.Insert(artista);
                    //GUARDO LA FOTO EN CARPETA
                    var filename = Path.Combine(_enviroment.ContentRootPath, "wwwroot/Artistas", artista.foto);
                    artista = null;
                    using FileStream stream = new FileStream(filename, FileMode.Create);
                    await artistasViewModel.fotoView.CopyToAsync(stream);

                    msj = 1;
                }
            }
            catch (Exception)
            {
                msj = 2;
            }
            return Json(msj);
        }
        //METODO PARA ELIMINAR ARTISTAS
        [HttpPost]
        public async Task<IActionResult> Delete(int cedula, string foto)
        {
            int msj = 0;
            try
            {
                if (cedula != 0 && foto != "")
                {
                    await _service.Delete(cedula);
                    var filename = Path.Combine(_enviroment.ContentRootPath, "wwwroot/Artistas", foto);
                    System.IO.File.Delete(filename);
                    msj = 1;
                }
            }
            catch (Exception ex)
            {
                msj = 2;
            }
            return Json(msj);
        }
        //METODO PARA EDITAR
        [HttpGet]
        public async Task<IActionResult> Edit(int cedula)
        {
            EditArtistaViewModel artistasViewModel = null;
            try
            {
                if (cedula != 0)
                {
                    Artistas artista = await _service.getArtistaById(cedula);
                    artistasViewModel = _mapper.Map<EditArtistaViewModel>(artista);
                }
            }
            catch (Exception)
            {

            }
            return View(artistasViewModel);
        }
        //METODO PARA ACTUALIZAR
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(EditArtistaViewModel artistasViewModel)
        {
            int msj = 0;
            try
            {
                if (ModelState.IsValid)
                {
                    Artistas artista = _mapper.Map<Artistas>(artistasViewModel);
                    await _service.Update(artista);

                    msj = 1;
                }
            }
            catch (Exception)
            {
                msj = 2;
            }
            return Json(msj);
        }
    }
}
