using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Cita
    {
        public Cita()
        {
            servicios = new List<DetalleFacturaServicio>();
        }

        public int Id { get; set; }
        public DateTime FechaCita { get; set; }
        public double PrecioTotal
        {
            get { return CalcularTotal(); }
        }
        public int Estado { get; set; }
        public string IdCliente { get; set; }

        public List<DetalleFacturaServicio> servicios;

        public Cita(int id, DateTime fechaCita, int estado, string idCliente)
        {
            Id = id;
            FechaCita = fechaCita;
            Estado = estado;
            IdCliente = idCliente;
            servicios = new List<DetalleFacturaServicio>();
        }
        public void AgregarServicio(DetalleFacturaServicio servicio)
        {
            servicios.Add(servicio);
        }
        public double CalcularTotal()
        {
            double valor = 0;

            foreach (DetalleFacturaServicio detalle in servicios)
            {
                valor = valor + detalle.precio;
            }
            return valor;

        }
    }
}
