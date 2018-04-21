using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Productos
{
    class Producto
    {
        public Guid ProductoId { get; set; }
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
    }
}
