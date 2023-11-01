using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA.Capas
{
    internal class Pedido
    {

        public DateTime Fecha { get; set; }

        public string NombreCliente { get; set; }

        public string Distrito { get; set; }

        public int Monto { get; set;}

        public Pedido(DateTime fecha, string NombreCliente, string Distrito, int Monto) { }


    }
}
