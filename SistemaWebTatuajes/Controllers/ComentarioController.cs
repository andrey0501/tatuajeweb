using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Controllers
{
    [Authorize(Roles ="Administrador")]
    public class ComentarioController : Controller
    {
        private ICalificaService _service;

        public ComentarioController(ICalificaService service)
        {
            _service = service;
        }


        //METODO PARA QUE EL ADMINISTRADOR PUEDA VER LOS COMENTARIOS
        public async Task<IActionResult> Index(int? pagina)
        {
            List<Califica> list = new List<Califica>();
            try
            {
                if (pagina == null) pagina = 1;
                int? skip = 10 * (pagina - 1);
                int lenght = 10;

                var res = await _service.GetAll(skip, lenght);
                list = res.Registros;
                ViewBag.totalpaginas = (Math.Ceiling((decimal)res.CantidadRegistros / 10));
            }
            catch (Exception)
            {

            }
            return View(list);
        }
    }
}
