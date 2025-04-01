using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.Entities
{
    public class Raza
    {
        public int Id_Raza { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Id_Especie { get; set; }

        // Propiedad de navegación
        public Especie Especie { get; set; }

        public Raza()
        {
        }

        public Raza(int id, string nombre, string descripcion, int idEspecie)
        {
            Id_Raza = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Id_Especie = idEspecie;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
