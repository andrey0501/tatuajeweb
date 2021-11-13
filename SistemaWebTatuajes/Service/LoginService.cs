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
    public class LoginService : ILoginService
    {
        private ILoginRepository _repo;
        private IEncriptar _encriptar;

        public LoginService(ILoginRepository repo, IEncriptar encriptar)
        {
            _repo = repo;
            _encriptar = encriptar;
        }

        public async Task<Usuarios> IniciarSesion(Usuarios usuarios)
        {
            usuarios.contrasena = await _encriptar.Encrypt(usuarios.contrasena);
            return await _repo.IniciarSesion(usuarios);
        }

        public async Task<string> SendMail(Usuarios usuarios)
        {
            return await _repo.SendMail(usuarios);
        }

        public async Task UpdatePassword(Usuarios usu)
        {
            usu.contrasena = await _encriptar.Encrypt(usu.contrasena);
            await _repo.UpdatePassword(usu);
        }

        public async Task<string> VerifyToken(string token)
        {
            return await _repo.VerifyToken(token);
        }
    }
}
