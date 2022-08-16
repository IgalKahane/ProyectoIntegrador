using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase12.MODELS
{
    internal class ProductosVendidos
    {


        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int ProductoVendido_IdVenta { get; set; }
        public int IdVenta { get; private set; }
        public int ProductoVendido_Stock { get; set; }
        public int Stock { get; set; }
    }       
}
