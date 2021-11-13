using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.ViewModel
{
    public class UsuarioViewModel
    {

        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(20, ErrorMessage = "Este campo permite un máximo de 20 caracteres.")]
        public string nom_Usuario { get; set; }

        [Display(Name = "Nombre Completo")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(40, ErrorMessage = "Este campo permite un máximo de 40 caracteres.")]
        public string nombre_Completo { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este campo permite un máximo de 30 caracteres.")]
        [RegularExpression(@"\w+@\w+\.([a-z]{2,4})", ErrorMessage = "Por favor ingrese un email válido")]
        public string email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*([A-Za-z]){1,})(?=.*[0-9]{1,}).{6,20}$", ErrorMessage = "La contrseña debe estar formada de números y letras, y debe tener entre 6 y 20 caracteres.")]
        public string contrasena { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Id_Rol { get; set; }

    }
}
