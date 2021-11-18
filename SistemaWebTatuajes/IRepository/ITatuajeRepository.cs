using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.IRepository
{
    public interface ITatuajeRepository
    {
        Task Insert(int id_artista, string[] nom_tatuajes);
        Task<List<Tatuajes>> GetById(int id_artista);
        Task DeleteTatuajes(int Id);
    }
}
