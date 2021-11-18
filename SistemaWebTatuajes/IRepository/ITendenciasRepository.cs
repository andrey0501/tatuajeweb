using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.IRepository
{
    public interface ITendenciasRepository
    {
        Task Insert(Tendencias tendencias);
        Task<List<Tendencias>> Get();
        Task<string> Delete(int id);
    }
}
