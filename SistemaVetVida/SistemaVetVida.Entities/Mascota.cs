using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.Entities
{
    public class Mascota
    {
        public int Id_Mascota { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Color { get; set; }
        public string Sexo { get; set; }
        public decimal Peso { get; set; }
        public int Id_Propietario { get; set; }
        public int Id_Raza { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Propiedades de navegación
        public Propietario Propietario { get; set; }
        public Raza Raza { get; set; }
        public List<Consulta> Consultas { get; set; }
        public HistorialMedico HistorialMedico { get; set; }

        public Mascota()
        {
            Consultas = new List<Consulta>();
            Activo = true;
            FechaRegistro = DateTime.Now;
        }

        public Mascota(int id, string nombre, DateTime fechaNacimiento, string color, string sexo, decimal peso, int idPropietario, int idRaza)
        {
            Id_Mascota = id;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Color = color;
            Sexo = sexo;
            Peso = peso;
            Id_Propietario = idPropietario;
            Id_Raza = idRaza;
            Activo = true;
            FechaRegistro = DateTime.Now;
            Consultas = new List<Consulta>();
        }

        public int CalcularEdad()
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
            return edad;
        }

        public override string ToString()
        {
            return $"{Nombre} ({Raza?.Nombre})";
        }
    }
}
