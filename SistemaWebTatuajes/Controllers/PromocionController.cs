using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using SistemaWebTatuajes.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Controllers
{
    [Authorize(Roles ="Administrador")]
    public class PromocionController : Controller
    {
        private IPromocionService _service;
        private IMapper _mapper;

        public PromocionController(IPromocionService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        //METODO QUE RETORNA LA VISTA DE PROMOCIONES
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Promociones> list = new List<Promociones>();
            try
            {
                var res = await _service.getPromociones();
                if (res != null)
                {
                    list = new List<Promociones>();
                    list = res;
                }
            }
            catch (Exception)
            {

            }
            return View(list);
        }
        //METODO QUE MUESTRA LA VISTA PARA AGREGAR UNA  PROMOCION
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //METODO PARA AGREGAR UNA PROMOCION
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(PromocionesViewModel promocionViewModel)
        {
            int msj = 0;
            try
            {
                if (ModelState.IsValid)
                {
                    Promociones promo = _mapper.Map<Promociones>(promocionViewModel);
                    await _service.Insert(promo);
                    msj = 1;
                }

            } catch (Exception)
            {
                msj = 2;
            }
            return Json(msj);
        }
        //METODO QUE MUESTRA LA VISTA PARA AGREGAR UNA  PROMOCION
        [HttpGet]
        public async Task<IActionResult> Edit(int idPromocion)
        {
            
            try
            {
                if (idPromocion != 0)
                {
                    Promociones promo = await _service.getPromoById(idPromocion);
                    EditPromocionViewModel editpromo = _mapper.Map<EditPromocionViewModel>(promo);
                    return View(editpromo);
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Lo sentimos ocurrió un error al procesar su solicitud.");
            }
           
            return View();

        }
        //METODO PARA ACTUALIZAR UNA PROMOCION
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(EditPromocionViewModel editPromocionViewModel)
        {
            int msj = 0;
            try
            {
                if (ModelState.IsValid)
                {
                    Promociones promo = _mapper.Map<Promociones>(editPromocionViewModel);
                    await _service.Update(promo);
                    msj = 1;
                }
            }
            catch (Exception)
            {
                msj = 2;
            }
            return Json(msj);
        }
        //METODO PARA ELIMINAR UNA PROMOCION
        [HttpPost]     
        public async Task<IActionResult> Delete(int id_Promocion)
        {
            int msj = 0;
            try
            {
                if (id_Promocion != 0)
                {
                    
                    await _service.Delete(id_Promocion);
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
