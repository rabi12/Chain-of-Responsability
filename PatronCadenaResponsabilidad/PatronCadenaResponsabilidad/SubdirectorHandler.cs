using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCadenaResponsabilidad
{
    class SubdirectorHandler: AbstractHandler
    {
        public override object Handle(SolicitudCompra request)
        {
            if (request.monto<=15000)
            {
                return "Compra de: "+request.concepto+" \"AUTORIZADA\" por Director (Subdirector).\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
