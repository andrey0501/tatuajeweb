using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.EnviarCorreos
{
    public interface IMasterEmail
    {
        Task SendEmail(string mensaje,string asunto,List<string> emails);
    }
}
