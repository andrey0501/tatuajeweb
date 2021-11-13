using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Models
{
    public class Usuarios
    {

        public int id_Usuario { get; set; }
        public string nom_Usuario { get; set; }
        public string nombre_Completo { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
        public int Id_Rol { get; set; }
        public string token { get; set; }
    }
}
