using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.IRepository
{
    public interface IPromocionRepository
    {
        Task<List<Promociones>> getPromociones();
        Task Delete(int idPromocion);
        Task Insert(Promociones promo);
        Task<Promociones> getPromoById(int idPromocion);
        Task Update(Promociones promo);
    }
}
