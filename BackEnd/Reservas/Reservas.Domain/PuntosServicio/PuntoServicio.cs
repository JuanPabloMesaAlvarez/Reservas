using Reservas.Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.PuntosServicio
{
    class PuntoServicio
    {
        public Guid PuntoServicioId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Puestos { get; set; }
        public Usuario Encargado { get; set; }
    }
}
