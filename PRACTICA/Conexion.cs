using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PRACTICA
{
    internal class Conexion
    {
        public static SqlConnection conectar() {

            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-CIC1KCF;DATABASE=REGISTRO;integrated security=true");
            cn.Open();
            return cn;
        }
    }
}
