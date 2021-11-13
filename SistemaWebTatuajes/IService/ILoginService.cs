using SistemaWebTatuajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.IService
{
    public interface ILoginService
    {
        Task<Usuarios> IniciarSesion(Usuarios usuarios);
        Task<string> SendMail(Usuarios usuarios);
        Task UpdatePassword(Usuarios usu);
        Task<string> VerifyToken(string token);
    }
}
