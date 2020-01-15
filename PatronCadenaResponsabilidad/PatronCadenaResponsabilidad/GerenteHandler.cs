using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCadenaResponsabilidad
{
    class GerenteHandler: AbstractHandler
    {
        public override object Handle(SolicitudCompra request)
        {
            if (request.monto<=10000)
            {
                return "Compra de: "+request.concepto+" \"AUTORIZADA\" por Director (Gerente).\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
