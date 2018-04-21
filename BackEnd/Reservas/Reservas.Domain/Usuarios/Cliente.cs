using Reservas.Domain.Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Usuarios
{
    class Cliente : Usuario
    {
        public IEnumerable<Vehiculo> Vehiculos { get; set; }
    }
}
