using SistemaVetVida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.BLL
{
    public interface IEspecieService
    {
        Especie ObtenerEspeciePorId(int id);
        List<Especie> ObtenerTodasLasEspecies();
        bool AgregarEspecie(Especie especie);
        bool ActualizarEspecie(Especie especie);
        bool EliminarEspecie(int id);
    }
}
