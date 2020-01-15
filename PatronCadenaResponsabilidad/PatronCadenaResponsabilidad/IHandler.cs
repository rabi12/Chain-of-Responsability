using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCadenaResponsabilidad
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(SolicitudCompra request);
    }
}
