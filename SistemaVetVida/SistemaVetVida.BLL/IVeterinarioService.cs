using SistemaVetVida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.BLL
{
    public interface IVeterinarioService
    {
        Veterinario ObtenerVeterinarioPorId(int id);
        List<Veterinario> ObtenerTodosLosVeterinarios();
        List<Veterinario> ObtenerVeterinariosPorEspecialidad(string especialidad);
        bool AgregarVeterinario(Veterinario veterinario);
        bool ActualizarVeterinario(Veterinario veterinario);
        bool EliminarVeterinario(int id);
    }
}
