using SistemaWebTatuajes.IRepository;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Service
{
    public class PromocionService:IPromocionService
    {
        private IPromocionRepository _repo;

        public PromocionService(IPromocionRepository repo)
        {
            _repo = repo;
        }

        public async Task Delete(int id_Promocion)
        {
            await _repo.Delete(id_Promocion);
        }

        public async Task<Promociones> getPromoById(int idPromocion)
        {
            return await _repo.getPromoById(idPromocion);
        }

        public async Task<List<Promociones>> getPromociones()
        {
            return await _repo.getPromociones();
        }

        public async Task Insert(Promociones promo)
        {
            await _repo.Insert(promo);
        }

        public async Task Update(Promociones promo)
        {
            await _repo.Update(promo);
        }
    }
}
