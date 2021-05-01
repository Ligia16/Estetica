using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class TarjetaDebito: IMetodoPago
    {
        public int Id { get; set; }
        public double ValorCancelar { get; set; }
        public string Tipo { get; set; }

        public double Saldo { get; set; }
        public string EstadoPago { get; set; }
        public string GenerarPago()
        {
            if (Saldo > ValorCancelar)
            {
                EstadoPago = "APROBADO";
                return "Pago Satisfactorio";
            }
            else
            {
                EstadoPago = "DESAPROBADO";
                return "Saldo Insuficiente";
            }

        }
    }
}
