using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.ViewModel
{
    public class EditUsuarioViewModel
    {
        [Display(Name = "ID")]
        [Required]
        public int id_Usuario { get; set; }

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

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Id_Rol { get; set; }

    }
}
