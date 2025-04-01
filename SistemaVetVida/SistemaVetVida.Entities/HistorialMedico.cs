using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.Entities
{
    public class HistorialMedico
    {
        public int Id_Historial { get; set; }
        public int Id_Mascota { get; set; }
        public int Id_Consulta { get; set; }

        // Propiedades de navegación
        public Mascota Mascota { get; set; }
        public Consulta Consulta { get; set; }

        public HistorialMedico()
        {
        }

        public HistorialMedico(int id, int idMascota, int idConsulta)
        {
            Id_Historial = id;
            Id_Mascota = idMascota;
            Id_Consulta = idConsulta;
        }
    }
}
