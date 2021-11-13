using SistemaWebTatuajes.IRepository;
using SistemaWebTatuajes.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace SistemaWebTatuajes.Repository
{
    public class ArtistaRepository : Conexion, IArtistaRepository
    {
        //METODO PARA ELIMINAR UN ARTISTA
        public async Task Delete(int id_artista)
        {
            using (var conn = getConexion())
            {
                var query = "DELETE FROM ARTISTAS WHERE ID_ARTISTA = @ID_ARTISTA";
                await conn.ExecuteAsync(query, new
                {
                    ID_ARTISTA = id_artista
                }, commandType: CommandType.Text);
            }
        }

        //METODO PARA LISTAR, (AGRUPA DATOS DE 10/10 PARA SER MOSTRADOS) evita traer grandes cantidades en bd de muchos registros
        public async Task<Paginador<List<Artistas>>> GetAll(int? skip, int lenght)
        {
            Paginador<List<Artistas>> paginas = new Paginador<List<Artistas>>();
            using (var conn = getConexion())
            {
                var query = "SELECT * FROM ARTISTAS LIMIT @SKIP,@LENGHT";
                paginas.Registros = (List<Artistas>)await conn.QueryAsync<Artistas>(query,new { SKIP = skip, LENGHT= lenght }, commandType: CommandType.Text);
                query = "SELECT COUNT(*) FROM ARTISTAS";
                paginas.CantidadRegistros = await conn.ExecuteScalarAsync<int>(query, commandType: CommandType.Text);
            }
            return paginas;
        }

        //METODO PARA OBTENER ARTISTA POR CEDULA
        public async Task<Artistas> getArtistaById(int Id_Artista)
        {
            Artistas artista = null;
            using (var conn = getConexion())
            {
                var query = "SELECT * FROM ARTISTAS WHERE ID_ARTISTA = @ID_ARTISTA";
                artista = (Artistas)await conn.QueryFirstOrDefaultAsync<Artistas>(query, new { ID_ARTISTA = Id_Artista }, commandType: CommandType.Text);
            }
            return artista;
        }

        //METODO PARA GUARDAR ARTISTAS
        public async Task Insert(Artistas artista)
        {
            using (var conn = getConexion())
            {
                var query = "INSERT INTO ARTISTAS(NOMBRE,APELLIDOS,BIBLIGRAFIA,FOTO) VALUES(@NOMBRE,@APELLIDOS,@BIBLIGRAFIA,@FOTO)";
                await conn.ExecuteAsync(query, new
                {
                    NOMBRE = artista.nombre,
                    APELLIDOS = artista.apellidos,
                    BIBLIGRAFIA = artista.bibligrafia,
                    FOTO = artista.foto
                }, commandType: CommandType.Text);
            }
        }

        //METODO PARA ACTUALIZAR LOS ARTISTAS 
        public async Task Update(Artistas artista)
        {
            using (var conn = getConexion())
            {
                var query = "UPDATE ARTISTAS SET NOMBRE = @NOMBRE, APELLIDOS = @APELLIDOS, BIBLIGRAFIA = @BIBLIGRAFIA WHERE ID_ARTISTA = @ID_ARTISTA";
                await conn.ExecuteAsync(query, new
                {
                    NOMBRE = artista.nombre,
                    APELLIDOS = artista.apellidos,
                    BIBLIGRAFIA = artista.bibligrafia,
                    ID_ARTISTA = artista.Id_Artista
                }, commandType: CommandType.Text);
            }
        }

        //METODO PARA MOSTRAR LOS ARTISTAS SIN PAGINAR, eje registro de tatuajes por artista, tatuajecontroller Linea35
        public async Task<List<ArtistaTatuaje>> getArtistas()
        {
            List<ArtistaTatuaje> list = null;
            using (var conn = getConexion())
            {
                var query = "SELECT ID_ARTISTA,NOMBRE FROM ARTISTAS";
                list = (List<ArtistaTatuaje>)await conn.QueryAsync<ArtistaTatuaje>(query, commandType: CommandType.Text);
            }
            return list;
        }
    }
}
