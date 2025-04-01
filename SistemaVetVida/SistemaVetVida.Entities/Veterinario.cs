using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.Entities
{
    public class Veterinario
    {
        public int Id_Veterinario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public string NumeroLicencia { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaContratacion { get; set; }

        // Propiedad de navegación
        public List<Consulta> Consultas { get; set; }

        public Veterinario()
        {
            Consultas = new List<Consulta>();
            Activo = true;
            FechaContratacion = DateTime.Now;
        }

        public Veterinario(int id, string nombre, string apellido, string especialidad, string numeroLicencia)
        {
            Id_Veterinario = id;
            Nombre = nombre;
            Apellido = apellido;
            Especialidad = especialidad;
            NumeroLicencia = numeroLicencia;
            Activo = true;
            FechaContratacion = DateTime.Now;
            Consultas = new List<Consulta>();
        }

        public string NombreCompleto
        {
            get { return $"Dr. {Nombre} {Apellido}"; }
        }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
