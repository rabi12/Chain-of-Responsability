using System;
using System.Collections.Generic;

namespace PatronCadenaResponsabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            // The other part of the client code constructs the actual chain.
            List<SolicitudCompra> solicitudes = new List<SolicitudCompra>();
            solicitudes.Add(new SolicitudCompra("Celular", new decimal(2500.00)));
            solicitudes.Add(new SolicitudCompra("Aire Acondicionado", new decimal(7500.00)));
            solicitudes.Add(new SolicitudCompra("TV", new decimal(12500.00)));
            solicitudes.Add(new SolicitudCompra("LAPTOP", new decimal(25000.00)));
            solicitudes.Add(new SolicitudCompra("Coche", new decimal(100000.00)));

            Cliente cliente = new Cliente();
            cliente.evaluarSolicitudes(solicitudes);

            Console.ReadKey();
        }
    }
}
