using SistemaVetVida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.BLL
{
    public class PropietarioService : IPropietarioService
    {
        // En una implementación real, aquí se inyectaría el repositorio de datos
        // private readonly IPropietarioRepository _repository;

        public PropietarioService()
        {
            // _repository = repository;
        }

        public Propietario ObtenerPropietarioPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del propietario debe ser mayor que cero", nameof(id));

            // Implementación simulada
            return new Propietario(id, "Juan", "Pérez", "555-123-4567")
            {
                Email = "juan.perez@example.com",
                Direccion = "Calle Principal 123"
            };
        }

        public List<Propietario> ObtenerTodosLosPropietarios()
        {
            // Implementación simulada
            var propietarios = new List<Propietario>
            {
                new Propietario(1, "Juan", "Pérez", "555-123-4567")
                {
                    Email = "juan.perez@example.com",
                    Direccion = "Calle Principal 123"
                },
                new Propietario(2, "María", "González", "555-987-6543")
                {
                    Email = "maria.gonzalez@example.com",
                    Direccion = "Avenida Central 456"
                },
                new Propietario(3, "Carlos", "Rodríguez", "555-456-7890")
                {
                    Email = "carlos.rodriguez@example.com",
                    Direccion = "Plaza Mayor 789"
                }
            };
            return propietarios;
        }

        public Propietario BuscarPropietarioPorTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono))
                throw new ArgumentException("El teléfono no puede estar vacío", nameof(telefono));

            // Implementación simulada
            var propietarios = ObtenerTodosLosPropietarios();
            return propietarios.FirstOrDefault(p => p.Telefono == telefono);
        }

        public bool AgregarPropietario(Propietario propietario)
        {
            if (propietario == null)
                throw new ArgumentNullException(nameof(propietario), "El propietario no puede ser nulo");

            if (string.IsNullOrWhiteSpace(propietario.Nombre))
                throw new ArgumentException("El nombre del propietario es requerido", nameof(propietario));

            if (string.IsNullOrWhiteSpace(propietario.Apellido))
                throw new ArgumentException("El apellido del propietario es requerido", nameof(propietario));

            if (string.IsNullOrWhiteSpace(propietario.Telefono))
                throw new ArgumentException("El teléfono del propietario es requerido", nameof(propietario));

            // Verificar si ya existe un propietario con el mismo teléfono
            var propietarioExistente = BuscarPropietarioPorTelefono(propietario.Telefono);
            if (propietarioExistente != null)
                throw new InvalidOperationException($"Ya existe un propietario con el teléfono {propietario.Telefono}");

            // Implementación real: return _repository.Add(propietario);
            return true;
        }

        public bool ActualizarPropietario(Propietario propietario)
        {
            if (propietario == null)
                throw new ArgumentNullException(nameof(propietario), "El propietario no puede ser nulo");

            if (propietario.Id_Propietario <= 0)
                throw new ArgumentException("ID de propietario inválido", nameof(propietario));

            if (string.IsNullOrWhiteSpace(propietario.Nombre))
                throw new ArgumentException("El nombre del propietario es requerido", nameof(propietario));

            if (string.IsNullOrWhiteSpace(propietario.Apellido))
                throw new ArgumentException("El apellido del propietario es requerido", nameof(propietario));

            if (string.IsNullOrWhiteSpace(propietario.Telefono))
                throw new ArgumentException("El teléfono del propietario es requerido", nameof(propietario));

            // Implementación real: return _repository.Update(propietario);
            return true;
        }

        public bool EliminarPropietario(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID del propietario debe ser mayor que cero", nameof(id));

            // Implementación real: return _repository.Delete(id);
            return true;
        }
    }
}
