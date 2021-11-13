using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SistemaWebTatuajes.EnviarCorreos;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using SistemaWebTatuajes.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Controllers
{
    public class HomeController : Controller
    {
        private IPromocionService _service;
        private IArtistaService _serviceArtista;
        private ITatuajeService _serviceTatuaje;
        private IMasterEmail _mail;
        private ICalificaService _serviceCalifica;
        private IMapper _mapper;

        public HomeController(IPromocionService service, IArtistaService serviceArtista, 
            ITatuajeService serviceTatuaje, IMasterEmail mail, IMapper mapper, ICalificaService serviceCalifica)
        {
            _service = service;
            _serviceArtista = serviceArtista;
            _serviceTatuaje = serviceTatuaje;
            _mail = mail;
            _mapper = mapper;
            _serviceCalifica = serviceCalifica;
        }

        [HttpGet]// TRAE LA LISTA DE PROMOCIONES
        public async Task<IActionResult> Index()
        {
            List<Promociones> promo = new List<Promociones>();
            try
            {
                promo = await _service.getPromociones();
                
            }
            catch (Exception ex)
            {

            }
            return View(promo);
        }
        //MUESTRA LA PAGINA DE ARTISTAS
        [HttpGet]
        public async Task<IActionResult> Artistas(int? pagina)
        {
            List<Artistas> list = null;
            try
            {
                if (pagina == null) pagina = 1;
                int? skip = 10 * (pagina - 1);
                int lenght = 10;

                var res = await _serviceArtista.GetAll(skip, lenght);
                list = res.Registros;
                ViewBag.totalpaginas = (Math.Ceiling((decimal)res.CantidadRegistros / 10));
            }
            catch (Exception)
            {

            }
            return View(list);
        }
        [HttpGet]
        public IActionResult Contact()//OBTIENE LA VISTA DE CONTACTOS
        {
            return View();
        }
        //METODO PARA VER LOS TATUAJES DE UN ARTISTA
        [HttpGet]
        public async Task<IActionResult> Tatuajes(int cedula)
        {
            List<Tatuajes> list = null ;
            try
            {
                if (cedula != 0)
                {
                    list = await _serviceTatuaje.GetById(cedula);
                }
            }
            catch (Exception)
            {

            }
            return View(list);
        }
        //METODO PARA ENVIAR MAIL
        [HttpPost]
        public async Task<IActionResult> EnviarMail(string name,string email,string subject, string message)
        {
            try
            {
                if (name != null && email != null && subject != null && message != null)
                {
                    List<string> list = new List<string>();
                    list.Add(email);
                    await _mail.SendEmail(message, subject + " "+name,list);
                    return StatusCode(200);
                }else return StatusCode(500);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        //METODO QUE MUESTRA LA VISTA DE CALIFICAR
        [HttpGet]
        public IActionResult Calificar()
        {
            return View();
        }
        //METODO PARA CALIFICAR
        [HttpPost]
        public async Task<IActionResult> Insert(CalificaViewModel calificaViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Califica califica = _mapper.Map<Califica>(calificaViewModel);
                    await _serviceCalifica.Insert(califica);
                    return StatusCode(200);
                }
                else return StatusCode(500);

            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
