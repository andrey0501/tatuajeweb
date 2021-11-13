using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Utilidades
{
    public interface IEncriptar
    {
        public Task<string> Encrypt(string text);
    }
}
