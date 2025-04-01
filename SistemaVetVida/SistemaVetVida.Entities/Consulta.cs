using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.Entities
{
    public class Consulta
    {
        public int Id_Consulta { get; set; }
        public int Id_Mascota { get; set; }
        public int Id_Veterinario { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public decimal Costo { get; set; }
        public string Estado { get; set; }

        // Propiedades de navegación
        public Mascota Mascota { get; set; }
        public Veterinario Veterinario { get; set; }

        public Consulta()
        {
            Fecha = DateTime.Now;
            Estado = "Pendiente";
        }

        public Consulta(int id, int idMascota, int idVeterinario, string motivo)
        {
            Id_Consulta = id;
            Id_Mascota = idMascota;
            Id_Veterinario = idVeterinario;
            Motivo = motivo;
            Fecha = DateTime.Now;
            Estado = "Pendiente";
        }

        public override string ToString()
        {
            return $"Consulta {Id_Consulta} - {Fecha.ToShortDateString()}";
        }
    }
}
