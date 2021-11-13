using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using SistemaWebTatuajes.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Service
{
    public class ArtistaService : IArtistaService
    {
        private IArtistaRepository _repo;

        public ArtistaService(IArtistaRepository repo)
        {
            _repo = repo;
        }

        public async Task Delete(int Id_Artista)
        {
            await _repo.Delete(Id_Artista);
        }

        public async Task<Paginador<List<Artistas>>> GetAll(int? skip, int lenght)
        {
            return await _repo.GetAll(skip,lenght);
        }

        public async Task<Artistas> getArtistaById(int Id_Artista)
        {
            return await _repo.getArtistaById(Id_Artista);
        }

        public async Task<List<ArtistaTatuaje>> getArtistas()
        {
            return await _repo.getArtistas();
        }

        public async Task Insert(Artistas artista)
        {
            await _repo.Insert(artista);
        }

        public async Task Update(Artistas artista)
        {
            await _repo.Update(artista);
        }
    }
}
