using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCadenaResponsabilidad
{
    class CoordinadorHandler: AbstractHandler
    {
        public override object Handle(SolicitudCompra request)
        {
            if (request.monto<=5000)
            {
                return "Compra de: "+request.concepto+" \"AUTORIZADA\" por Director (Coordinador).\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
