using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;


namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void AddCliente()
        {
            var cliente = new Cliente()
            {
                idPersona = "12345",
                nombre = "Valentina",
                apellidos = "Perez",
                telefono = "300545232",
                direccion = "Barranquilla"
            };
            _repoCliente.AddCliente(cliente);
            
        }
    }
}
