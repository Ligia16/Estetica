using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public double Descuento { get; set; }
        public Servicio()
        {
        }
        public Servicio(int id, string nombre, double precio, double descuento)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Descuento = descuento;
        }

    }
}
