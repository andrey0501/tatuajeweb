using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.ViewModel
{
    public class PromocionesViewModel
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(200,ErrorMessage ="Este campo permite un máximo de 200 caracteres")]
        public string nom_Promocion { get; set; }
    }
}
