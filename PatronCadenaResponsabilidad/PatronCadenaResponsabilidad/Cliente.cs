using System;
using System.Collections.Generic;
using System.Text;

namespace PatronCadenaResponsabilidad
{
    class Cliente
    {
        IHandler cadenaResponsabilidad;

        public Cliente()
        {
            cadenaResponsabilidad=configurarCadenaResponsabilidad();
        }

        private IHandler configurarCadenaResponsabilidad()
        {
            var coordinador = new CoordinadorHandler();
            var gerente = new GerenteHandler();
            var subdirector = new SubdirectorHandler();
            var director = new DirectorHandler();

            coordinador.SetNext(gerente).SetNext(subdirector).SetNext(director);
            return coordinador;
        }

        // The client code is usually suited to work with a single handler. In
        // most cases, it is not even aware that the handler is part of a chain.
        public void evaluarSolicitudes(List<SolicitudCompra> solicitudes)
        {
           
            Console.WriteLine("Atencion de Solicitudes: ");
            foreach (var solicitud in  solicitudes)
            {
                
                var result = this.cadenaResponsabilidad.Handle(solicitud);

                if (result != null)
                {
                    Console.Write(result);
                }
                else
                {
                    Console.WriteLine("No esta configurado.");
                }
            }
        }
    }
}
