
using Microsoft.AspNetCore.Hosting;
using SistemaWebTatuajes.IRepository;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Service
{
    public class TatuajeService : ITatuajeService
    {
        private ITatuajeRepository _repo;
        private IWebHostEnvironment _enviroment;

        public TatuajeService(ITatuajeRepository repo, IWebHostEnvironment enviroment)
        {
            _repo = repo;
            _enviroment = enviroment;
        }

        public async Task DeleteTatuajes(int Id)
        {
            await _repo.DeleteTatuajes(Id);
        }

        public async Task DeleteTatuajes(int Id, string nombre)
        {
            try
            {
                await _repo.DeleteTatuajes(Id);
                var fotoTatuaje = Path.Combine(_enviroment.ContentRootPath, "wwwroot/Tipos", nombre);
                File.Delete(fotoTatuaje);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Tatuajes>> GetById(int id_artista)
        {
            return await _repo.GetById(id_artista);
        }

        public async Task Insert(int id_artista, string[] nom_tatuajes)
        {
            await _repo.Insert(id_artista, nom_tatuajes);
        }
    }
}
