using Microsoft.AspNetCore.Http;
using SistemaWebTatuajes.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.ViewModel
{
    public class TendenciasViewModel
    {
        [Display(Name="ID")]
        public int Id { get; set; }

        [Display(Name ="Nombre del tipo de tatuaje")]
        [Required(ErrorMessage  = "Este campo es obligatorio")]
        [MaxLength(50,ErrorMessage = "Máximo 50 caracteres")]
        public string Nombre { get; set; }

        [Display(Name = "Tatuaje")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [ValidarExtension(new[] { "image/png", "image/jpg", "image/jpeg", "image/JPEG" })]
        public IFormFile TipoTatuaje { get; set; }
    }
}
