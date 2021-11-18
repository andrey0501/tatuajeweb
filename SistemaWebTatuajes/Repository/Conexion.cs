using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaWebTatuajes.Repository
{
    public abstract class Conexion //SE CREA LA CONEXION A LA BD
    {
        private readonly String ConectionString = "Server=MYSQL5045.site4now.net; port=3306; database=db_a7a8ad_tatuaje; user id=a7a8ad_tatuaje; password=Andrey_Ch4v47714;";
        
        protected MySqlConnection getConexion()
        {
            return new MySqlConnection(ConectionString);
        }
    }
}
