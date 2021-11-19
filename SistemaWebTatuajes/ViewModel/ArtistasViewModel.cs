using Microsoft.AspNetCore.Http;
using SistemaWebTatuajes.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.ViewModel
{
    public class ArtistasViewModel
    {
        
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(20,ErrorMessage ="Este campo permite un máximo de 20 caracteres.")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(25, ErrorMessage = "Este campo permite un máximo de 25 caracteres.")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(1000, ErrorMessage = "Este campo permite un máximo de 1000 caracteres.")]
        public string bibligrafia { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [ValidarExtension(new []{"image/png","image/jpg","image/jpeg","image/JPEG" })]
        public IFormFile fotoView { get; set; }
    }
}
