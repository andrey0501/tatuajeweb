using SistemaWebTatuajes.IRepository;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Service
{
    public class TendenciasService : ITendenciasService
    {
        private readonly ITendenciasRepository _tendenciasRepository;

        public TendenciasService(ITendenciasRepository tendenciasRepository)
        {
            _tendenciasRepository = tendenciasRepository;
        }

        public async Task<string> Delete(int id)
        {
           return await _tendenciasRepository.Delete(id);
        }

        public async Task<List<Tendencias>> Get()
        {
            return await _tendenciasRepository.Get();
        }

        public async Task Insert(Tendencias tendencias)
        {
            await _tendenciasRepository.Insert(tendencias);
        }
    }
}
