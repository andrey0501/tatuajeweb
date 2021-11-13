using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Models
{
    public class Artistas
    {
        public int Id_Artista { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string bibligrafia { get; set; }     
        public string foto { get; set; }
    }
}
