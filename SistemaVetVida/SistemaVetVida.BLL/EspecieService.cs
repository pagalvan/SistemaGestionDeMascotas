using SistemaVetVida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.BLL
{
    public class EspecieService : IEspecieService
    {
        // En una implementación real, aquí se inyectaría el repositorio de datos
        // private readonly IEspecieRepository _repository;

        public EspecieService()
        {
            // _repository = repository;
        }

        public Especie ObtenerEspeciePorId(int id)
        {
            // Implementación real usaría: return _repository.GetById(id);
            // Implementación simulada para desarrollo:
            if (id <= 0)
                throw new ArgumentException("El ID de la especie debe ser mayor que cero", nameof(id));

            // Simulamos la obtención de datos
            return new Especie(id, "Especie de ejemplo", "Descripción de ejemplo");
        }

        public List<Especie> ObtenerTodasLasEspecies()
        {
            // Implementación simulada
            var especies = new List<Especie>
            {
                new Especie(1, "Perro", "Canino doméstico"),
                new Especie(2, "Gato", "Felino doméstico"),
                new Especie(3, "Ave", "Aves domésticas")
            };
            return especies;
        }

        public bool AgregarEspecie(Especie especie)
        {
            if (especie == null)
                throw new ArgumentNullException(nameof(especie), "La especie no puede ser nula");

            if (string.IsNullOrWhiteSpace(especie.Nombre))
                throw new ArgumentException("El nombre de la especie es requerido", nameof(especie));

            // Implementación real: return _repository.Add(especie);
            return true;
        }

        public bool ActualizarEspecie(Especie especie)
        {
            if (especie == null)
                throw new ArgumentNullException(nameof(especie), "La especie no puede ser nula");

            if (especie.Id_Especie <= 0)
                throw new ArgumentException("ID de especie inválido", nameof(especie));

            if (string.IsNullOrWhiteSpace(especie.Nombre))
                throw new ArgumentException("El nombre de la especie es requerido", nameof(especie));

            // Implementación real: return _repository.Update(especie);
            return true;
        }

        public bool EliminarEspecie(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de la especie debe ser mayor que cero", nameof(id));

            // Implementación real: return _repository.Delete(id);
            return true;
        }
    }
}
