using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class DetalleCitaServicio
    {
        public int Id { get; set; }
        public double precio { get; set; }
        public int Cantidad { get; set; }
        public int IdCita { get; set; }
        public int IServicio { get; set; }
        public DetalleCitaServicio()
        {
        }

        public DetalleCitaServicio(int id, double precio, int cantidad, int idCita, int iServicio)
        {
            Id = id;
            this.precio = precio;
            Cantidad = cantidad;
            IdCita = idCita;
            IServicio = iServicio;
        }
    }
}
