using SistemaVetVida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.BLL
{
    public interface IConsultaService
    {
        Consulta ObtenerConsultaPorId(int id);
        List<Consulta> ObtenerTodasLasConsultas();
        List<Consulta> ObtenerConsultasPorMascota(int idMascota);
        List<Consulta> ObtenerConsultasPorVeterinario(int idVeterinario);
        List<Consulta> ObtenerConsultasPorFecha(DateTime fecha);
        bool AgregarConsulta(Consulta consulta);
        bool ActualizarConsulta(Consulta consulta);
        bool EliminarConsulta(int id);
    }
}
