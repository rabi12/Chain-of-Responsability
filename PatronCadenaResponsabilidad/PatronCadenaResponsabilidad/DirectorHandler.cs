using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCadenaResponsabilidad
{
    class DirectorHandler: AbstractHandler
    {
        public override object Handle(SolicitudCompra request)
        {
            if (request.monto<=50000)
            {
                return "Compra de: "+request.concepto+" \"AUTORIZADA\" por Director (Director).\n";
            }
            else
            {
                return "Compra de: " + request.concepto + " \"RECHAZADA\" por Director (Director).\n";
                //return base.Handle(request);
            }
        }
    }
}
