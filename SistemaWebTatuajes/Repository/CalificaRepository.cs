using Dapper;
using SistemaWebTatuajes.IRepository;
using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Repository
{
    public class CalificaRepository : Conexion, ICalificaRepository
    {
        //METODO PARA LISTAR LOS COMENTARIOS(CALIFICACIONES)
        public async Task<Paginador<List<Califica>>> GetAll(int? skip, int lenght)
        {
            Paginador<List<Califica>> paginas = new Paginador<List<Califica>>();
            using (var conn = getConexion())
            {
                var query = "SELECT * FROM CALIFICA LIMIT @SKIP,@LENGHT";
                paginas.Registros = (List<Califica>)await conn.QueryAsync<Califica>(query,new { SKIP = skip, LENGHT = lenght },commandType:CommandType.Text);
                query = "SELECT COUNT(*) FROM CALIFICA";
                paginas.CantidadRegistros = await conn.ExecuteScalarAsync<int>(query, commandType: CommandType.Text);
            }
            return paginas;
        }
        //METOD PARA INSERTAR COMENTARIOS
        public async Task Insert(Califica califica)
        {
            using (var conn = getConexion())
            {
                var query = "INSERT INTO CALIFICA(CALIFICACION,COMENTARIO)VALUES(@CALIFICACION,@COMENTARIO)";
                await conn.ExecuteAsync(query,new { CALIFICACION = califica.calificacion, COMENTARIO = califica.comentario}, commandType: CommandType.Text);
            }
        }
    }
}
