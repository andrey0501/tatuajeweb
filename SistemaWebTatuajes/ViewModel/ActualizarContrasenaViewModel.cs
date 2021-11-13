using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.ViewModel
{
    public class ActualizarContrasenaViewModel
    {
        [Required]
        public string token { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*([A-Za-z]){1,})(?=.*[0-9]{1,}).{6,20}$", ErrorMessage = "La contrseña debe estar formada de números y letras, y debe tener entre 6 y 20 caracteres.")]
        public string contrasena { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.Password)]
        [Compare("contrasena",ErrorMessage ="Las contraseñas no coinciden")]
        public string confirmarContrasena { get; set; }
    }
}
