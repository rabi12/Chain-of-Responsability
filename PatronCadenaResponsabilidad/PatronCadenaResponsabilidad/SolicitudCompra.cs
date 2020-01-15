using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCadenaResponsabilidad
{
    public class SolicitudCompra
    {
        public decimal monto { get; set; }
        public string concepto { get; set; }

        public SolicitudCompra(string concepto,decimal monto)
        {
            this.concepto = concepto;
            this.monto = monto;
        }
    }
}
