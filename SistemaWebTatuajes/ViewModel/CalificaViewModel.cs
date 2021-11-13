using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.ViewModel
{
    public class CalificaViewModel
    {
        [Display(Name ="Calificación")]
        [Required(ErrorMessage ="Por favor ingrese la calificación")]
        public int calificacion { get; set; }

        [Display(Name = "Comentario")]
        [Required(ErrorMessage = "Por favor ingrese el comentario")]
        [MaxLength(200,ErrorMessage ="Este campo permite un máximo de 200 caracteres")]
        public string comentario { get; set; }
    }
}
