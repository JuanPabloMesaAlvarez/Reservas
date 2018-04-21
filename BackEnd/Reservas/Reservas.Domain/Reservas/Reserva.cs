using Reservas.Domain.Productos;
using Reservas.Domain.PuntosServicio;
using Reservas.Domain.Servicios;
using Reservas.Domain.Usuarios;
using Reservas.Domain.Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Reservas
{
    enum ESTADO
    {
        EnEspera = 0,
        Recibido = 1,
        EnProceso = 2,
        Terminado = 3
    }

    class Reserva
    {
        public Guid ReservaId { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }
        public ESTADO Estado { get; set; }
        public bool RecogeCliente { get; set; }
        public string RecogeOtro { get; set; }
        public Cliente Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public PuntoServicio PuntoServicio { get; set; }

        public IEnumerable<Servicio> Servicios { get; set; }
        public IEnumerable<Producto> Productos { get; set; }
    }
}
