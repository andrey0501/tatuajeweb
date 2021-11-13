using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.IService
{
    public interface IPromocionService
    {
        Task<List<Promociones>> getPromociones();
        Task Insert(Promociones promo);
        Task<Promociones> getPromoById(int idPromocion);
        Task Update(Promociones promo);
        Task Delete(int id_Promocion);
    }
}
