using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using SistemaWebTatuajes.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace SistemaWebTatuajes.Service
{
    public class ArtistaService : IArtistaService
    {
        private IArtistaRepository _repo;
        private IWebHostEnvironment _enviroment;

        public ArtistaService(IArtistaRepository repo, IWebHostEnvironment enviroment)
        {
            _repo = repo;
            _enviroment = enviroment;
        }

        public async Task Delete(int Id_Artista, string foto)
        {
            try
            {
                List<string> obj = await _repo.Delete(Id_Artista);
                var filename = Path.Combine(_enviroment.ContentRootPath, "wwwroot/Artistas", foto);
                System.IO.File.Delete(filename);

                if (obj != null)
                {
                    foreach (var i in obj)
                    {
                        var fotoTatuaje = Path.Combine(_enviroment.ContentRootPath, "wwwroot/Tipos", i);
                        System.IO.File.Delete(fotoTatuaje);
                    }
                }
              
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<Paginador<List<Artistas>>> GetAll(int? skip, int lenght)
        {
            return await _repo.GetAll(skip, lenght);
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
