using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.Entities
{
    public class Propietario
    {
        public int Id_Propietario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Propiedad de navegación
        public List<Mascota> Mascotas { get; set; }

        public Propietario()
        {
            Mascotas = new List<Mascota>();
            FechaRegistro = DateTime.Now;
        }

        public Propietario(int id, string nombre, string apellido, string telefono)
        {
            Id_Propietario = id;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Mascotas = new List<Mascota>();
            FechaRegistro = DateTime.Now;
        }

        public string NombreCompleto
        {
            get { return $"{Nombre} {Apellido}"; }
        }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
