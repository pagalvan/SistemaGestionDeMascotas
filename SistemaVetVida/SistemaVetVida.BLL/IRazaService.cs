using SistemaVetVida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.BLL
{
    public interface IRazaService
    {
        Raza ObtenerRazaPorId(int id);
        List<Raza> ObtenerTodasLasRazas();
        List<Raza> ObtenerRazasPorEspecie(int idEspecie);
        bool AgregarRaza(Raza raza);
        bool ActualizarRaza(Raza raza);
        bool EliminarRaza(int id);
    }
}
