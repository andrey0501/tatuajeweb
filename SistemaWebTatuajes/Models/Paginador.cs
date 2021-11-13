using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Models
{
    public class Paginador<T>
    {
        public int CantidadRegistros { get; set; }
        public T Registros { get; set; }
    }
}
