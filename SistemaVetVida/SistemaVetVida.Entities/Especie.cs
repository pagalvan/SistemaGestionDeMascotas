using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.Entities
{
    public class Especie
    {
        public int Id_Especie { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Especie()
        {
        }

        public Especie(int id, string nombre, string descripcion)
        {
            Id_Especie = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
