using System;
namespace MascotaFeliz.App.Dominio
{
    public class Bicicleta
    {
        public int id { get; set; }
        public string color { get; set; }
        public string marca { get; set; }
        public string tipo { get; set; }
        public Cliente cliente { get; set; }
    }
}
