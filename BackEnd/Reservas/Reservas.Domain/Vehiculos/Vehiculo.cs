using Reservas.Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Vehiculos
{
    class Vehiculo
    {
        public Guid VehiculoId { get; set; }
        public string Placa { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }
        public Cliente Propietario { get; set; }
    }
}
