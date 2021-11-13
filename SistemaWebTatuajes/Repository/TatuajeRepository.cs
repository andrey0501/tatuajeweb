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
    public class TatuajeRepository : Conexion, ITatuajeRepository
    {
      
        //METODO PARA INSERTAR TATUAJES POR AUTOR
        public async Task Insert(int id_artista, string[] nom_tatuajes)
        {

            using (var conn = getConexion())
            {
                await conn.OpenAsync();
                using (var tran = await conn.BeginTransactionAsync())
                {
                    try
                    {
                        var query = "INSERT INTO TATUAJES(NOM_TATUAJE,ID_ARTISTA)VALUES(@NOM_TATUAJE,@ID_ARTISTA)";
                        for (int i = 0; i < nom_tatuajes.Length; i++)
                        {
                            await conn.ExecuteAsync(query, new
                            {
                                NOM_TATUAJE = nom_tatuajes[i],
                                ID_ARTISTA = id_artista
                            }, tran, commandType: CommandType.Text);
                        }
                        await tran.CommitAsync();
                    }
                    catch (Exception)
                    {
                        await tran.RollbackAsync();
                        throw;
                    }
                }
            }

        }
        //METODO PARA LISTAR TATUAJES POR CEDULA(ARTISTA) GALERIA DE ARTISTAS
        public async Task<List<Tatuajes>> GetById(int id_artista)
        {
            List<Tatuajes> list = null;
            using (var conn = getConexion())
            {
                var query = "SELECT * FROM TATUAJES WHERE ID_ARTISTA = @ID_ARTISTA";
                list = (List<Tatuajes>)await conn.QueryAsync<Tatuajes>(query,new { ID_ARTISTA = id_artista },commandType:CommandType.Text);
            }
            return list;
        }


    }
}
