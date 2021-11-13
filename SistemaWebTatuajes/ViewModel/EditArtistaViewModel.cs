using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.ViewModel
{
    public class EditArtistaViewModel
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Id_Artista { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(20, ErrorMessage = "Este campo permite un máximo de 20 caracteres.")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(25, ErrorMessage = "Este campo permite un máximo de 25 caracteres.")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(1000, ErrorMessage = "Este campo permite un máximo de 1000 caracteres.")]
        public string bibligrafia { get; set; }
    }
}
