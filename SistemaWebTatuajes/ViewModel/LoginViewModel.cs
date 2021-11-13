using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Por favor ingrese el usuario ó email")]
        [MaxLength(30)]
        public string nom_Usuario { get; set; }

        [Required(ErrorMessage = "Por favor ingrese la contraseña")]
        [DataType(DataType.Password)]
        [MaxLength(20)]
        public string contrasena { get; set; }
    }
}
