using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.IService
{
    public interface IArtistaService
    {
        Task Insert(Artistas artista);
        Task<Paginador<List<Artistas>>> GetAll(int? skip, int lenght);
        Task Delete(int Id_Artista);
        Task Update(Artistas artista);
        Task<Artistas> getArtistaById(int Id_Artista);
        Task<List<ArtistaTatuaje>> getArtistas();
    }
}
