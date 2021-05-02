using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class IMetodoPago
    {
        int Id { get; set; }
        double ValorCancelar { get; set; }
        string Tipo { get; set; }
        string EstadoPago { get; set; }
        
    }
}
