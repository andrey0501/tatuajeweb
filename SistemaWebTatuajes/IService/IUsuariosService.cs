using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.IService
{
    public interface IUsuariosService
    {
        Task Insert(Usuarios usuarios);
        Task<Paginador<List<Usuarios>>> GetUsuarios(int? skip, int lenght);
        Task<Usuarios> GetUsuarioById(int idUsuario);
        Task Update(Usuarios usu);
        Task Delete(int id_usuario);
    }
}
