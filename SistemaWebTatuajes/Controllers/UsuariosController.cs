using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using SistemaWebTatuajes.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Controllers
{
    [Authorize(Roles ="Administrador")]//EL ADMINISTRADOR SOLO PUEDE TENER ACCESO A ESA VISTA
    public class UsuariosController : Controller
    {
        private IUsuariosService _service;
        private IMapper _mapper;

        //CONSTRUCTOR
        public UsuariosController(IUsuariosService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        /*METODO QUE ME RETORNA LA LISTA DE VISTA DEL USUARIO*/
        [HttpGet]
        public async Task<IActionResult> Index(int? pagina)
        {
            List<Usuarios> list = new List<Usuarios>();
            try
            {
                if (pagina == null) pagina = 1;
                int? skip = 10 * (pagina - 1);
                int lenght = 10;

                var res = await _service.GetUsuarios(skip, lenght);
                list = res.Registros;
                ViewBag.totalpaginas = (Math.Ceiling((decimal)res.CantidadRegistros / 10));
            }
            catch (Exception)
            {

            }

            return View(list);
        }
        /*METODO QUE ME RETORNA LA VISTA PARA CREAR EL USUARIO*/
        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            lst.Add(new SelectListItem() { Text = "Seleccione", Value = "" });
            lst.Add(new SelectListItem() { Text = "Administrador", Value = "1" });
            lst.Add(new SelectListItem() { Text = "Usuario", Value = "2" });

            ViewBag.Roles = lst;

            return View();
        }
        [HttpGet]/*METODO QUE TRAE LOS DATOS DE UN USUARIO PARA SER EDITADO*/
        public async Task<IActionResult> Edit(int id_Usuario)
        {
            if (id_Usuario != 0)
            {
                EditUsuarioViewModel editUsuario = null;
                try
                {
                    Usuarios usuario = await _service.GetUsuarioById(id_Usuario);
                    editUsuario = _mapper.Map<EditUsuarioViewModel>(usuario);
                    List<SelectListItem> lst = new List<SelectListItem>();
                    lst.Add(new SelectListItem() { Text = "Seleccione", Value = "" });
                    lst.Add(new SelectListItem() { Text = "Administrador", Value = "1" });
                    lst.Add(new SelectListItem() { Text = "Usuario", Value = "2" });
                    ViewBag.Roles = lst;
                }
                catch (Exception)
                {

                }
                return View(editUsuario);
            }
            return RedirectToAction("Index","Usuarios");
        }
        /*METODO PARA INSERTAR UN USUARIO*/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(UsuarioViewModel usuarioViewModel)
        {
            int msj = 0;
            try
            {
                if (ModelState.IsValid)
                {
                    Usuarios usu = _mapper.Map<Usuarios>(usuarioViewModel);
                    await _service.Insert(usu);
                    msj = 1;
                }
            }
            catch (Exception)
            {
                msj = 2;
            }

            return Json(msj);
        }
        //METODO PARA ACTUALIZAR USUARIOS
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(EditUsuarioViewModel editUsuarioViewModel)
        {
            int msj = 0;
            try
            {
                if (ModelState.IsValid)
                {
                    Usuarios usu = _mapper.Map<Usuarios>(editUsuarioViewModel);
                    await _service.Update(usu);
                    msj = 1;
                }
            }
            catch(Exception)
            {
                msj = 2;
            }
            return Json(msj);
        }
        //METODO PARA ELIMINAR UN USUARIO
        [HttpPost]     
        public async Task<IActionResult> Delete(int id_usuario)
        {
            int msj = 0;
            try
            {
                if (id_usuario != 0)
                {
                    await _service.Delete(id_usuario);
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
