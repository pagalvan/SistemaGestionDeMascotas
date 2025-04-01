using SistemaVetVida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.BLL
{
    public interface IHistorialMedicoService
    {
        HistorialMedico ObtenerHistorialPorId(int id);
        List<HistorialMedico> ObtenerHistorialPorMascota(int idMascota);
        bool AgregarHistorial(HistorialMedico historial);
        bool ActualizarHistorial(HistorialMedico historial);
        bool EliminarHistorial(int id);
    }
}
