using SistemaVetVida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.BLL
{
    public interface IPropietarioService
    {
        Propietario ObtenerPropietarioPorId(int id);
        List<Propietario> ObtenerTodosLosPropietarios();
        Propietario BuscarPropietarioPorTelefono(string telefono);
        bool AgregarPropietario(Propietario propietario);
        bool ActualizarPropietario(Propietario propietario);
        bool EliminarPropietario(int id);
    }
}
