
using SistemaWebTatuajes.IRepository;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Service
{
    public class TatuajeService : ITatuajeService
    {
        private ITatuajeRepository _repo;

        public TatuajeService(ITatuajeRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Tatuajes>> GetById(int id_artista)
        {
            return await _repo.GetById(id_artista);
        }

        public async Task Insert(int id_artista, string[] nom_tatuajes)
        {
            await _repo.Insert(id_artista,nom_tatuajes);
        }
    }
}
