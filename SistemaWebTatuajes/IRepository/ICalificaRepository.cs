using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.IRepository
{
    public interface ICalificaRepository
    {
        Task Insert(Califica califica);
        Task<Paginador<List<Califica>>> GetAll(int? skip, int lenght);
    }
}
