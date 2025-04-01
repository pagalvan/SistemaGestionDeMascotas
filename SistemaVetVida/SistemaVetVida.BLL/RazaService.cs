using SistemaVetVida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.BLL
{
    public class RazaService : IRazaService
    {
        private readonly IEspecieService _especieService;
        // En una implementación real, aquí se inyectaría el repositorio de datos
        // private readonly IRazaRepository _repository;

        public RazaService(IEspecieService especieService)
        {
            _especieService = especieService ?? throw new ArgumentNullException(nameof(especieService));
            // _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Raza ObtenerRazaPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de la raza debe ser mayor que cero", nameof(id));

            // Implementación simulada
            var raza = new Raza(id, "Raza de ejemplo", "Descripción de ejemplo", 1);
            raza.Especie = _especieService.ObtenerEspeciePorId(raza.Id_Especie);
            return raza;
        }

        public List<Raza> ObtenerTodasLasRazas()
        {
            // Implementación simulada
            var razas = new List<Raza>
            {
                new Raza(1, "Labrador", "Perro de tamaño grande", 1),
                new Raza(2, "Siamés", "Gato de pelo corto", 2),
                new Raza(3, "Bulldog", "Perro de tamaño mediano", 1)
            };

            // Asignar especies a cada raza
            foreach (var raza in razas)
            {
                raza.Especie = _especieService.ObtenerEspeciePorId(raza.Id_Especie);
            }

            return razas;
        }

        public List<Raza> ObtenerRazasPorEspecie(int idEspecie)
        {
            if (idEspecie <= 0)
                throw new ArgumentException("El ID de la especie debe ser mayor que cero", nameof(idEspecie));

            // Verificar que la especie existe
            var especie = _especieService.ObtenerEspeciePorId(idEspecie);
            if (especie == null)
                throw new ArgumentException($"No existe una especie con el ID {idEspecie}", nameof(idEspecie));

            // Implementación simulada
            var todasLasRazas = ObtenerTodasLasRazas();
            return todasLasRazas.Where(r => r.Id_Especie == idEspecie).ToList();
        }

        public bool AgregarRaza(Raza raza)
        {
            if (raza == null)
                throw new ArgumentNullException(nameof(raza), "La raza no puede ser nula");

            if (string.IsNullOrWhiteSpace(raza.Nombre))
                throw new ArgumentException("El nombre de la raza es requerido", nameof(raza));

            if (raza.Id_Especie <= 0)
                throw new ArgumentException("Se requiere una especie válida", nameof(raza));

            // Verificar que la especie existe
            var especie = _especieService.ObtenerEspeciePorId(raza.Id_Especie);
            if (especie == null)
                throw new ArgumentException($"No existe una especie con el ID {raza.Id_Especie}", nameof(raza));

            // Implementación real: return _repository.Add(raza);
            return true;
        }

        public bool ActualizarRaza(Raza raza)
        {
            if (raza == null)
                throw new ArgumentNullException(nameof(raza), "La raza no puede ser nula");

            if (raza.Id_Raza <= 0)
                throw new ArgumentException("ID de raza inválido", nameof(raza));

            if (string.IsNullOrWhiteSpace(raza.Nombre))
                throw new ArgumentException("El nombre de la raza es requerido", nameof(raza));

            if (raza.Id_Especie <= 0)
                throw new ArgumentException("Se requiere una especie válida", nameof(raza));

            // Verificar que la especie existe
            var especie = _especieService.ObtenerEspeciePorId(raza.Id_Especie);
            if (especie == null)
                throw new ArgumentException($"No existe una especie con el ID {raza.Id_Especie}", nameof(raza));

            // Implementación real: return _repository.Update(raza);
            return true;
        }

        public bool EliminarRaza(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de la raza debe ser mayor que cero", nameof(id));

            // Implementación real: return _repository.Delete(id);
            return true;
        }
    }
}
