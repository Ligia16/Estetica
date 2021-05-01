using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Efectivo : IMetodoPago
    {

        public int Id { get; set; }
        public double ValorCancelar { get; set; }
        public string Tipo { get; set; }

        public double ValorRecibido { get; set; }
        public double ValorEntregado { get; set; }
        public string EstadoPago { get; set; }

        public string GenerarPago()
        {
            if (ValorRecibido > ValorCancelar)
            {
                ValorEntregado = ValorRecibido - ValorCancelar;
                EstadoPago = "APROBADO";
                return "Su cambio es: " + ValorEntregado + ", Pago Satisfactorio";

            }
            else
            {
                EstadoPago = "DESAPROBADO";
                return "Valor recibido insificiente";
            }
        }
    }
}
