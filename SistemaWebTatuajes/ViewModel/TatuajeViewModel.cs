using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.ViewModel
{
    public class TatuajeViewModel
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Id_Artista { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public IFormFile[] tatuajes {get;set;}

    }
}
