using Dapper;
using SistemaWebTatuajes.EnviarCorreos;
using SistemaWebTatuajes.IRepository;
using SistemaWebTatuajes.Models;
using SistemaWebTatuajes.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Repository
{
    public class LoginRepository : Conexion, ILoginRepository//METODO ENCRIPTA EL TOKEN 
    {
        private IEncriptar _encriptar;
        private IMasterEmail _masterEmail;

        public LoginRepository(IEncriptar encriptar, IMasterEmail masterEmail)
        {
            _encriptar = encriptar;
            _masterEmail = masterEmail;
        }


        //METODO PARA INICIAR SESION
        public async Task<Usuarios> IniciarSesion(Usuarios usuarios)
        {
            Usuarios usuario = null;
            using (var conn = getConexion())
            {
                var query = "SELECT * FROM USUARIOS WHERE CONTRASENA = @CONTRASENA AND NOM_USUARIO = @NOM_USUARIO OR EMAIL = @NOM_USUARIO";
                usuario = await conn.QueryFirstOrDefaultAsync<Usuarios>(query, new
                {
                    NOM_USUARIO = usuarios.nom_Usuario,
                    CONTRASENA = usuarios.contrasena
                }, commandType: CommandType.Text);
            }
            return usuario;
        }
        //METODO VERIFICA QUE EL EMAIL EXISTA, GENERA UN TOKEN Y ENVIA EL EMAIL PARA RESTABLECER CONTRASEÑA
        public async Task<string> SendMail(Usuarios usuarios)
        {
            string email, token, mensaje, asunto, url;
            List<string> list;


            try
            {
                using (var conn = getConexion())
                {
                    var query = "SELECT EMAIL FROM USUARIOS WHERE EMAIL = @EMAIL";
                    email = await conn.QueryFirstOrDefaultAsync<string>(query, new
                    {
                        EMAIL = usuarios.email
                    }, commandType: CommandType.Text);

                    if (email != null)
                    {
                        token = await _encriptar.Encrypt(Guid.NewGuid().ToString());
                        query = "UPDATE USUARIOS SET TOKEN = @TOKEN WHERE EMAIL = @EMAIL";
                        await conn.ExecuteAsync(query, new { TOKEN = token, EMAIL = usuarios.email }, commandType: CommandType.Text);
                        list = new List<string>();
                        list.Add(usuarios.email);
                        url = "http://andrey05-001-site1.itempurl.com/Security/ActualizarContrasena/?token=" + token;
                        asunto = "Notificacion TATTO";
                        mensaje = "<p>Se ha recibido una solicitud para restablecer la contraseña de su cuenta.<br>";
                        mensaje += "<a href=" + url + ">Restablecer la contraseña</a></p>";//va el url con el token encriptado
                        await _masterEmail.SendEmail(mensaje, asunto, list);
                    }
                }
                
            }
            catch (Exception)
            {
                email = null;
            }


            return email;
        }
        //METODO PARA ACTUALIZAR LA CONTRASENA(SE LE PASA EL EMAIL AL PARAMETRO NUEVOTOKEN PARA QUE GUARDE NULL EN LA BD)
        //Y HACE QUE SE GENERE UN NUEVO TOKEN
        public async Task UpdatePassword(Usuarios usu)
        {
            using (var conn = getConexion())
            {

                var query = "UPDATE USUARIOS SET CONTRASENA = @CONTRASENA, TOKEN = @NUEVOTOKEN WHERE TOKEN = @TOKEN";
                await conn.ExecuteAsync(query, new { CONTRASENA = usu.contrasena, NUEVOTOKEN = usu.email, TOKEN = usu.token }, commandType: CommandType.Text);
            }
        }
        //METODO PARA VERIFICAR QUE EXISTA EL TOKEN EN BD, YA QUE SI ESTÁ NULL ES PORQUE SE USÓ
        public async Task<string> VerifyToken(string token)
        {
            string res = null;
            using (var conn = getConexion())
            {

                var query = "SELECT EMAIL FROM USUARIOS WHERE TOKEN = @TOKEN";
                res =  await conn.QueryFirstOrDefaultAsync<string>(query, new { TOKEN = token }, commandType: CommandType.Text);
            }
            return res;
        }
    }
}
