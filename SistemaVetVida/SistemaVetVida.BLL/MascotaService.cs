using SistemaVetVida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.BLL
{
    public class MascotaService : IMascotaService
    {
        private readonly IPropietarioService _propietarioService;
        private readonly IRazaService _razaService;
        // En una implementación real, aquí se inyectaría el repositorio de datos
        // private readonly IMascotaRepository _repository;

        public MascotaService(IPropietarioService propietarioService, IRazaService razaService)
        {
            _propietarioService = propietarioService ?? throw new ArgumentNullException(nameof(propietarioService));
            _razaService = razaService ?? throw new ArgumentNullException(nameof(razaService));
            // _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Mascota ObtenerMascotaPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de la mascota debe ser mayor que cero", nameof(id));

            // Implementación simulada
            var mascota = new Mascota(id, "Firulais", new DateTime(2020, 1, 1), "Marrón", "Macho", 15.5m, 1, 1);
            mascota.Propietario = _propietarioService.ObtenerPropietarioPorId(mascota.Id_Propietario);
            mascota.Raza = _razaService.ObtenerRazaPorId(mascota.Id_Raza);
            return mascota;
        }

        public List<Mascota> ObtenerTodasLasMascotas()
        {
            // Implementación simulada
            var mascotas = new List<Mascota>
            {
                new Mascota(1, "Firulais", new DateTime(2020, 1, 1), "Marrón", "Macho", 15.5m, 1, 1),
                new Mascota(2, "Luna", new DateTime(2019, 5, 10), "Blanco", "Hembra", 4.2m, 2, 2),
                new Mascota(3, "Rocky", new DateTime(2021, 3, 15), "Negro", "Macho", 12.8m, 1, 3)
            };

            // Asignar propietarios y razas a cada mascota
            foreach (var mascota in mascotas)
            {
                mascota.Propietario = _propietarioService.ObtenerPropietarioPorId(mascota.Id_Propietario);
                mascota.Raza = _razaService.ObtenerRazaPorId(mascota.Id_Raza);
            }

            return mascotas;
        }

        public List<Mascota> ObtenerMascotasPorPropietario(int idPropietario)
        {
            if (idPropietario <= 0)
                throw new ArgumentException("El ID del propietario debe ser mayor que cero", nameof(idPropietario));

            // Verificar que el propietario existe
            var propietario = _propietarioService.ObtenerPropietarioPorId(idPropietario);
            if (propietario == null)
                throw new ArgumentException($"No existe un propietario con el ID {idPropietario}", nameof(idPropietario));

            // Implementación simulada
            var todasLasMascotas = ObtenerTodasLasMascotas();
            return todasLasMascotas.Where(m => m.Id_Propietario == idPropietario).ToList();
        }

        public bool AgregarMascota(Mascota mascota)
        {
            if (mascota == null)
                throw new ArgumentNullException(nameof(mascota), "La mascota no puede ser nula");

            if (string.IsNullOrWhiteSpace(mascota.Nombre))
                throw new ArgumentException("El nombre de la mascota es requerido", nameof(mascota));

            if (mascota.Id_Propietario <= 0)
                throw new ArgumentException("Se requiere un propietario válido", nameof(mascota));

            if (mascota.Id_Raza <= 0)
                throw new ArgumentException("Se requiere una raza válida", nameof(mascota));

            // Verificar que el propietario existe
            var propietario = _propietarioService.ObtenerPropietarioPorId(mascota.Id_Propietario);
            if (propietario == null)
                throw new ArgumentException($"No existe un propietario con el ID {mascota.Id_Propietario}", nameof(mascota));

            // Verificar que la raza existe
            var raza = _razaService.ObtenerRazaPorId(mascota.Id_Raza);
            if (raza == null)
                throw new ArgumentException($"No existe una raza con el ID {mascota.Id_Raza}", nameof(mascota));

            // Implementación real: return _repository.Add(mascota);
            return true;
        }

        public bool ActualizarMascota(Mascota mascota)
        {
            if (mascota == null)
                throw new ArgumentNullException(nameof(mascota), "La mascota no puede ser nula");

            if (mascota.Id_Mascota <= 0)
                throw new ArgumentException("ID de mascota inválido", nameof(mascota));

            if (string.IsNullOrWhiteSpace(mascota.Nombre))
                throw new ArgumentException("El nombre de la mascota es requerido", nameof(mascota));

            if (mascota.Id_Propietario <= 0)
                throw new ArgumentException("Se requiere un propietario válido", nameof(mascota));

            if (mascota.Id_Raza <= 0)
                throw new ArgumentException("Se requiere una raza válida", nameof(mascota));

            // Verificar que el propietario existe
            var propietario = _propietarioService.ObtenerPropietarioPorId(mascota.Id_Propietario);
            if (propietario == null)
                throw new ArgumentException($"No existe un propietario con el ID {mascota.Id_Propietario}", nameof(mascota));

            // Verificar que la raza existe
            var raza = _razaService.ObtenerRazaPorId(mascota.Id_Raza);
            if (raza == null)
                throw new ArgumentException($"No existe una raza con el ID {mascota.Id_Raza}", nameof(mascota));

            return true;
        }

        public bool EliminarMascota(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de la mascota debe ser mayor que cero", nameof(id));

            // Implementación real: return _repository.Delete(id);
            return true;
        }
    }
}
