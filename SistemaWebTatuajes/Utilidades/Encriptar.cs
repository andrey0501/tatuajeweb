using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Utilidades
{
    public class Encriptar: IEncriptar
    {
        //METODO PARA ENCRIPTAR LA CONTRASEÑA
        public async Task<string> Encrypt(string text)
        {

            var encriptar = new Task<string>(() =>
            {
                SHA256 sha256 = SHA256Managed.Create();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] stream = null;
                StringBuilder sb = new StringBuilder();
                stream = sha256.ComputeHash(encoding.GetBytes(text));
                for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
                return sb.ToString();
            });
            encriptar.Start();
            text = await encriptar;
            encriptar.Dispose();
            return text;
        }

    }
}
