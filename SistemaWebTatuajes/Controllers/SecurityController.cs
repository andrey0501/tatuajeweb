using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using SistemaWebTatuajes.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Controllers
{
    public class SecurityController : Controller
    {
        private ILoginService _service;
        private IMapper _mapper;

        public SecurityController(ILoginService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        //METODO QUE MUESTRA LA VISTA DEL LOGIN
        [HttpGet]
        public IActionResult Index()
        {
            if (TempData["msj"] != null)
            {
                ModelState.AddModelError(string.Empty, TempData["msj"].ToString());
            }

            return View();
        }

        //METODO PARA INICIAR SESION
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IniciarSesion(LoginViewModel login)
        {
            int msj = 0;
            string role = null;
            try
            {
                if (ModelState.IsValid)
                {
                    Usuarios usuarios = _mapper.Map<Usuarios>(login);
                    var usuario = await _service.IniciarSesion(usuarios);
                    if (usuario != null)
                    {
                        if (usuario.Id_Rol == 1) role = "Administrador"; else role = "Usuario";
                        var claims = new List<Claim> { new Claim(ClaimTypes.Name, usuario.email), new Claim("NombreCompleto", usuario.nombre_Completo), new Claim(ClaimTypes.Role, role), };
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                        msj = 1;
                    }
                    else { msj = 2; }
                }
            }
            catch (Exception)
            {
                msj = 3;
            }
            
            return Json(msj);
        }

        //METODO PARA ENVIAR CORREO CON PASOS PARA RECUPERAR LA CONTRASENA
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendEmail(RecuperaContrasenaViewModel recupera)
        {
            int msj = 0;
            try
            {
                if (ModelState.IsValid)
                {
                    Usuarios usuarios = _mapper.Map<Usuarios>(recupera);
                    var respuesta = await _service.SendMail(usuarios);
                    if (respuesta != null) msj = 1; else msj = 2;
                }
            }
            catch (Exception)
            {
                msj = 3;
            }
            return Json(msj);

        }

        //METODO QUE MUESTRA LA VISTA DE ENVIAR EL EMAIL
        [HttpGet]
        public IActionResult Recovery()
        {
            return View();
        }

        //METODO QUE MUESTRA LA VISTA PARA ACTUALIZAR LA CONTRASENA
        [HttpGet]
        public async Task<IActionResult> ActualizarContrasena(string token)
        {
            try
            {
                if (token == null)
                {
                    return RedirectToAction("Index", "Security");
                }
                else
                {
                    string res = await _service.VerifyToken(token);
                    if (res == null)
                    {
                        TempData["msj"] = "El token ya fue utilizado.";
                        return RedirectToAction("Index", "Security");
                    }
                }
                ActualizarContrasenaViewModel actualizarContrasena = new ActualizarContrasenaViewModel();
                actualizarContrasena.token = token;
                return View(actualizarContrasena);
            }
            catch (Exception)
            {
                TempData["msj"] = "Lo sentimos ocurrió un error al procesar su solicitud.";
                return RedirectToAction("Index", "Security");
            }

        }

        //METODO PARA ACTUALIZAR LA CONTRASENA
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePassword(ActualizarContrasenaViewModel actualizarContrasenaViewModel)
        {
            int msj = 0;
            try
            {
                if (ModelState.IsValid)
                {
                    Usuarios usu = _mapper.Map<Usuarios>(actualizarContrasenaViewModel);
                    await _service.UpdatePassword(usu);
                    msj = 1;
                }
            }
            catch (Exception)
            {
                msj = 2;
            }
            return Json(msj);
        }

        //METODO PARA CERRAR CESSION
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Salir()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        //METODO PARA LOS PERMISOS( NO TIENE PERMISOS SEGUN EL ROL)
        [HttpGet]
        public IActionResult Permisos()
        {
            return View();
        }
    }
}
