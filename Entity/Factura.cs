using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public int Id { get; set; }
        public double PrecioTotal
        {
            get { return CalcularTotal(); }
        }
        public DateTime Fecha { get; set; }
        public double Iva { get; set; }
        public string IdCliente { get; set; }
        public string IdPago { get; set; }

        public List<DetalleFacturaServicio> servicios;

        public Factura()
        {
            servicios = new List<DetalleFacturaServicio>();
        }

        public Factura(int id, DateTime fecha, double iva, string idCliente)
        {
            Id = id;
            Fecha = fecha;
            Iva = iva;
            IdCliente = idCliente;
            servicios = new List<DetalleFacturaServicio>();
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
