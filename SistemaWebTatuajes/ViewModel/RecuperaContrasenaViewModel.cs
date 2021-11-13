using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.ViewModel
{
    public class RecuperaContrasenaViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este campo permite un máximo de 30 caracteres.")]
        [RegularExpression(@"\w+@\w+\.([a-z]{2,4})", ErrorMessage = "Por favor ingrese un email válido")]
        public string email { get; set; }
    }
}
