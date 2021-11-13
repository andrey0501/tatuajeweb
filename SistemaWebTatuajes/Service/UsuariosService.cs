using SistemaWebTatuajes.IRepository;
using SistemaWebTatuajes.IService;
using SistemaWebTatuajes.Models;
using SistemaWebTatuajes.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Service
{
    public class UsuariosService : IUsuariosService
    {
        private IUsuariosRepository _repo;
        private IEncriptar _encriptar;

        public UsuariosService(IUsuariosRepository repo, IEncriptar encriptar)
        {
            _repo = repo;
            _encriptar = encriptar;
        }

        public async Task Delete(int id_usuario)
        {
            await _repo.Delete(id_usuario);
        }

        public async Task<Usuarios> GetUsuarioById(int idUsuario)
        {
            return await _repo.GetUsuarioById(idUsuario);
        }

        public async Task<Paginador<List<Usuarios>>> GetUsuarios(int? skip, int lenght)
        {
            return await _repo.GetUsuarios(skip,lenght);
        }

        public async Task Insert(Usuarios usuarios)
        {
            usuarios.contrasena = await _encriptar.Encrypt(usuarios.contrasena);
            await _repo.Insert(usuarios);
        }

        public async Task Update(Usuarios usu)
        {
            await _repo.Update(usu);
        }
    }
}
