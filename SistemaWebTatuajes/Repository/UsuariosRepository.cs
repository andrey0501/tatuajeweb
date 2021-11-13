using SistemaWebTatuajes.IRepository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using SistemaWebTatuajes.Models;

namespace SistemaWebTatuajes.Repository
{
    public class UsuariosRepository : Conexion, IUsuariosRepository
    {
        //METODO PARA INSERTAR UN USUARIO
        public async Task Insert(Usuarios usuarios)
        {
            using (var conn = getConexion())
            {
                var query = "INSERT INTO USUARIOS(NOM_USUARIO,NOMBRE_COMPLETO,EMAIL,CONTRASENA,ID_ROL) VALUES(@NOM_USUARIO,@NOMBRE_COMPLETO,@EMAIL,@CONTRASENA,@ID_ROL)";

                await conn.ExecuteAsync(query, new
                {
                    NOM_USUARIO = usuarios.nom_Usuario,
                    NOMBRE_COMPLETO = usuarios.nombre_Completo,
                    EMAIL = usuarios.email,
                    CONTRASENA = usuarios.contrasena,
                    ID_ROL = usuarios.Id_Rol

                }, commandType: CommandType.Text);
            }
        }
        //METODO PARA LISTAR LOS USUARIOS POR PAGINADOR DE USUARIOS
        public async Task<Paginador<List<Usuarios>>> GetUsuarios(int? skip, int lenght)
        {
            Paginador<List<Usuarios>> paginas = new Paginador<List<Usuarios>>();
            using (var conn = getConexion())
            {
                var query = "SELECT * FROM USUARIOS";
                paginas.Registros = (List<Usuarios>)await conn.QueryAsync<Usuarios>(query, commandType: CommandType.Text);
                query = "SELECT COUNT(*) FROM USUARIOS";
                paginas.CantidadRegistros = await conn.ExecuteScalarAsync<int>(query, commandType: CommandType.Text);
            }
            return paginas;

        }
        //METODO PARA EDITAR(OBTIENE EL USUARIO POR EL ID_USUARIO)
        public async Task<Usuarios> GetUsuarioById(int idUsuario)
        {
            Usuarios usuario = null;
            using (var conn = getConexion())
            {
                var query = "SELECT * FROM USUARIOS WHERE ID_USUARIO = @ID_USUARIO";
                usuario = await conn.QueryFirstOrDefaultAsync<Usuarios>(query, new
                {
                    ID_USUARIO = idUsuario
                }, commandType: CommandType.Text);
            }
            return usuario;
        }
        //METODO PARA ACTUALIZAR UN USUARIO
        public async Task Update(Usuarios usu)
        {
            using (var conn = getConexion())
            {
                var query = "UPDATE USUARIOS SET NOM_USUARIO = @NOM_USUARIO, NOMBRE_COMPLETO = @NOMBRE_COMPLETO, EMAIL = @EMAIL, ID_ROL = @ID_ROL WHERE ID_USUARIO = @ID_USUARIO";

                await conn.ExecuteAsync(query, new
                {
                    NOM_USUARIO = usu.nom_Usuario,
                    NOMBRE_COMPLETO = usu.nombre_Completo,
                    EMAIL = usu.email,
                    ID_ROL = usu.Id_Rol,
                    ID_USUARIO = usu.id_Usuario

                }, commandType: CommandType.Text) ;
            }
        }
        //METODO PARA ELIMINAR UN USUARIO
        public async Task Delete(int id_usuario)
        {
            using (var conn = getConexion())
            {
                var query = "DELETE FROM USUARIOS WHERE ID_USUARIO = @ID_USUARIO AND ID_ROL = @ID_ROL";

                await conn.ExecuteAsync(query, new
                {
                    ID_USUARIO = id_usuario,
                    ID_ROL = 2
                }, commandType: CommandType.Text) ;
            }
        }
    }
}
