using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.IRepository
{
    public interface IArtistaRepository
    {
        Task Insert(Artistas artista);
        Task<Paginador<List<Artistas>>> GetAll(int? skip, int lenght);
        Task<List<string>> Delete(int Id_Artista);
        Task<Artistas> getArtistaById(int Id_Artista);
        Task Update(Artistas artista);
        Task<List<ArtistaTatuaje>> getArtistas();
    }
}
