using SistemaVetVida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.BLL
{
    public interface IMascotaService
    {
        Mascota ObtenerMascotaPorId(int id);
        List<Mascota> ObtenerTodasLasMascotas();
        List<Mascota> ObtenerMascotasPorPropietario(int idPropietario);
        bool AgregarMascota(Mascota mascota);
        bool ActualizarMascota(Mascota mascota);
        bool EliminarMascota(int id);
    }
}
