using SistemaWebTatuajes.IRepository;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Service
{
    public class CalificaService : ICalificaService
    {
        private ICalificaRepository _repo;

        public CalificaService(ICalificaRepository repo)
        {
            _repo = repo;
        }

        public async Task<Paginador<List<Califica>>> GetAll(int? skip, int lenght)
        {
            return await _repo.GetAll(skip, lenght);
        }

        public async Task Insert(Califica califica)
        {
            await _repo.Insert(califica);
        }
    }
}
