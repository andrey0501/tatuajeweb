using SistemaWebTatuajes.IRepository;
using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Threading.Tasks;
using System.Data;

namespace SistemaWebTatuajes.Repository
{
    public class TendenciasRepository : Conexion, ITendenciasRepository
    {
        //INSERTAR UNA TENDENCIA
        public async Task Insert(Tendencias tendencias)
        {
            using (var conn = getConexion())
            {
                var query = "INSERT INTO TENDENCIAS(TIPO,RUTA) VALUES(@TIPO,@RUTA)";
                await conn.ExecuteAsync(query, new { TIPO = tendencias.Tipo, RUTA = tendencias.Ruta }, commandType: CommandType.Text);
            }
        }

        //ELIMINAR UNA TENDENCIA
        public async Task<string> Delete(int id)
        {
            try
            {
                using (var conn = getConexion())
                {
                    var query = "SELECT RUTA FROM TENDENCIAS WHERE ID = @ID";
                    string res = await conn.QueryFirstOrDefaultAsync<string>(query, new { Id = id }, commandType: CommandType.Text);
                    query = "DELETE FROM TENDENCIAS WHERE ID = @ID";
                    await conn.ExecuteAsync(query, new { Id = id }, commandType: CommandType.Text);
                    return res;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        //LISTAR TENDENCIAS
        public async Task<List<Tendencias>> Get()
        {
            try
            {
                using (var conn = getConexion())
                {
                    var query = "SELECT * FROM TENDENCIAS";
                    var res = await conn.QueryAsync<Tendencias>(query, commandType: CommandType.Text);
                    return res.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
