using SistemaWebTatuajes.IRepository;
using SistemaWebTatuajes.Models;
using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace SistemaWebTatuajes.Repository
{
    public class PromocionRepository : Conexion, IPromocionRepository
    {
        //METODO PARA ELIMINAR PROMOCIONES
        public async Task Delete(int idPromocion)
        {
            using (var conn = getConexion())
            {
                var query = "DELETE FROM PROMOCIONES WHERE ID_PROMOCION = @ID_PROMOCION";
                await conn.ExecuteAsync(query,new { ID_PROMOCION = idPromocion },commandType:CommandType.Text);
            }
        }
        //METODO PARA OBTENER PROMOCION POR ID
        public async Task<Promociones> getPromoById(int idPromocion)
        {
            Promociones promo = null;
            using (var conn = getConexion())
            {
                var query = "SELECT * FROM PROMOCIONES WHERE ID_PROMOCION = @ID_PROMOCION";
                promo = await conn.QueryFirstOrDefaultAsync<Promociones>(query, new { ID_PROMOCION = idPromocion }, commandType: CommandType.Text);
            }
            return promo;
        }

        //METODO PARA LISTAR LAS PROMOCIONES
        public async Task<List<Promociones>> getPromociones()
        {
            List<Promociones> promo = null;
            using (var conn = getConexion())
            {
                var query = "SELECT * FROM PROMOCIONES";
                var res = await conn.QueryAsync<Promociones>(query, commandType: CommandType.Text);
                promo = res.ToList();
            }
            return promo;
        }
        //METODO PARA INSERTAR UNA PROMOCION
        public async Task Insert(Promociones promo)
        {
            using (var conn = getConexion())
            {
                var query = "INSERT INTO PROMOCIONES(NOM_PROMOCION) VALUES(@NOM_PROMOCION)";
                await conn.ExecuteAsync(query, new { NOM_PROMOCION = promo.nom_Promocion }, commandType: CommandType.Text);
            }
        }
        //METODO PARA ACTUALIZAR PROMOCIONES
        public async Task Update(Promociones promo)
        {
            using (var conn = getConexion())
            {
                var query = "UPDATE PROMOCIONES SET NOM_PROMOCION = @NOM_PROMOCION WHERE ID_PROMOCION = @ID_PROMOCION";
                await conn.ExecuteAsync(query, new { NOM_PROMOCION = promo.nom_Promocion ,ID_PROMOCION = promo.id_Promocion }, commandType: CommandType.Text);
            }
        }
    }
}
