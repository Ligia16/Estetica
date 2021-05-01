using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class DetalleFactura
    {
        public int Id { get; set; }
        public double precio { get; set; }
        public int Cantidad { get; set; }
        public int IdFactura { get; set; }
        public int IServicio { get; set; }
        public DetalleFacturaServicio()
        {
        }
        public DetalleFacturaServicio(int id, double precio, int cantidad, int idFactura, int iServicio)
        {
            Id = id;
            this.precio = precio;
            Cantidad = cantidad;
            IdFactura = idFactura;
            IServicio = iServicio;
        }
    }
}
