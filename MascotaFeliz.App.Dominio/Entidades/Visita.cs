using System;
namespace MascotaFeliz.App.Dominio
{
    public class Visita
    {
        public int id { get; set; }
        public Bicicleta Bicicleta { get; set; }
        public Empleado Empleado { get; set; }
        public string fechaVisita { get; set; }
        public string recomendaciones { get; set; }
        public string estado { get; set; }
    }
}