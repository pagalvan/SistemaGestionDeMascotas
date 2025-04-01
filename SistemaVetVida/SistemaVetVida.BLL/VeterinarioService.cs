using SistemaVetVida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.BLL
{
    public class VeterinarioService : IVeterinarioService
    {
        // En una implementación real, aquí se inyectaría el repositorio de datos
        // private readonly IVeterinarioRepository _repository;

        public VeterinarioService()
        {
            // _repository = repository;
        }

        public Veterinario ObtenerVeterinarioPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del veterinario debe ser mayor que cero", nameof(id));

            // Implementación simulada
            return new Veterinario(id, "Ana", "Martínez", "Medicina General", "VET-12345")
            {
                Telefono = "555-789-0123",
                Email = "ana.martinez@vetvida.com"
            };
        }

        public List<Veterinario> ObtenerTodosLosVeterinarios()
        {
            // Implementación simulada
            var veterinarios = new List<Veterinario>
            {
                new Veterinario(1, "Ana", "Martínez", "Medicina General", "VET-12345")
                {
                    Telefono = "555-789-0123",
                    Email = "ana.martinez@vetvida.com"
                },
                new Veterinario(2, "Pedro", "Sánchez", "Cirugía", "VET-67890")
                {
                    Telefono = "555-234-5678",
                    Email = "pedro.sanchez@vetvida.com"
                },
                new Veterinario(3, "Laura", "Gómez", "Dermatología", "VET-54321")
                {
                    Telefono = "555-345-6789",
                    Email = "laura.gomez@vetvida.com"
                }
            };
            return veterinarios;
        }

        public List<Veterinario> ObtenerVeterinariosPorEspecialidad(string especialidad)
        {
            if (string.IsNullOrWhiteSpace(especialidad))
                throw new ArgumentException("La especialidad no puede estar vacía", nameof(especialidad));

            // Implementación simulada
            var todosLosVeterinarios = ObtenerTodosLosVeterinarios();
            return todosLosVeterinarios.Where(v => v.Especialidad.Equals(especialidad, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public bool AgregarVeterinario(Veterinario veterinario)
        {
            if (veterinario == null)
                throw new ArgumentNullException(nameof(veterinario), "El veterinario no puede ser nulo");

            if (string.IsNullOrWhiteSpace(veterinario.Nombre))
                throw new ArgumentException("El nombre del veterinario es requerido", nameof(veterinario));

            if (string.IsNullOrWhiteSpace(veterinario.Apellido))
                throw new ArgumentException("El apellido del veterinario es requerido", nameof(veterinario));

            if (string.IsNullOrWhiteSpace(veterinario.NumeroLicencia))
                throw new ArgumentException("El número de licencia del veterinario es requerido", nameof(veterinario));

            // Implementación real: return _repository.Add(veterinario);
            return true;
        }

        public bool ActualizarVeterinario(Veterinario veterinario)
        {
            if (veterinario == null)
                throw new ArgumentNullException(nameof(veterinario), "El veterinario no puede ser nulo");

            if (veterinario.Id_Veterinario <= 0)
                throw new ArgumentException("ID de veterinario inválido", nameof(veterinario));

            if (string.IsNullOrWhiteSpace(veterinario.Nombre))
                throw new ArgumentException("El nombre del veterinario es requerido", nameof(veterinario));

            if (string.IsNullOrWhiteSpace(veterinario.Apellido))
                throw new ArgumentException("El apellido del veterinario es requerido", nameof(veterinario));

            if (string.IsNullOrWhiteSpace(veterinario.NumeroLicencia))
                throw new ArgumentException("El número de licencia del veterinario es requerido", nameof(veterinario));

            // Implementación real: return _repository.Update(veterinario);
            return true;
        }

        public bool EliminarVeterinario(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del veterinario debe ser mayor que cero", nameof(id));

            // Implementación real: return _repository.Delete(id);
            return true;
        }
    }
}
