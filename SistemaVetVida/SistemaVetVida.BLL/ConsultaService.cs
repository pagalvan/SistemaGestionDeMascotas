using SistemaVetVida.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVetVida.BLL
{
    public class ConsultaService : IConsultaService
    {
        private readonly IMascotaService _mascotaService;
        private readonly IVeterinarioService _veterinarioService;
        // En una implementación real, aquí se inyectaría el repositorio de datos
        // private readonly IConsultaRepository _repository;

        public ConsultaService(IMascotaService mascotaService, IVeterinarioService veterinarioService)
        {
            _mascotaService = mascotaService ?? throw new ArgumentNullException(nameof(mascotaService));
            _veterinarioService = veterinarioService ?? throw new ArgumentNullException(nameof(veterinarioService));
            // _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Consulta ObtenerConsultaPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de la consulta debe ser mayor que cero", nameof(id));

            // Implementación simulada
            var consulta = new Consulta(id, 1, 1, "Revisión anual")
            {
                Fecha = DateTime.Now.AddDays(-5),
                Diagnostico = "Mascota saludable",
                Tratamiento = "Ninguno requerido",
                Costo = 50.00m,
                Estado = "Completada"
            };
            consulta.Mascota = _mascotaService.ObtenerMascotaPorId(consulta.Id_Mascota);
            consulta.Veterinario = _veterinarioService.ObtenerVeterinarioPorId(consulta.Id_Veterinario);
            return consulta;
        }

        public List<Consulta> ObtenerTodasLasConsultas()
        {
            // Implementación simulada
            var consultas = new List<Consulta>
            {
                new Consulta(1, 1, 1, "Revisión anual")
                {
                    Fecha = DateTime.Now.AddDays(-5),
                    Diagnostico = "Mascota saludable",
                    Tratamiento = "Ninguno requerido",
                    Costo = 50.00m,
                    Estado = "Completada"
                },
                new Consulta(2, 2, 2, "Vacunación")
                {
                    Fecha = DateTime.Now.AddDays(-3),
                    Diagnostico = "Requiere vacunas",
                    Tratamiento = "Aplicación de vacunas",
                    Costo = 75.00m,
                    Estado = "Completada"
                },
                new Consulta(3, 3, 3, "Problema de piel")
                {
                    Fecha = DateTime.Now.AddDays(-1),
                    Diagnostico = "Dermatitis",
                    Tratamiento = "Medicación tópica",
                    Costo = 100.00m,
                    Estado = "En seguimiento"
                }
            };

            // Asignar mascotas y veterinarios a cada consulta
            foreach (var consulta in consultas)
            {
                consulta.Mascota = _mascotaService.ObtenerMascotaPorId(consulta.Id_Mascota);
                consulta.Veterinario = _veterinarioService.ObtenerVeterinarioPorId(consulta.Id_Veterinario);
            }

            return consultas;
        }

        public List<Consulta> ObtenerConsultasPorMascota(int idMascota)
        {
            if (idMascota <= 0)
                throw new ArgumentException("El ID de la mascota debe ser mayor que cero", nameof(idMascota));

            // Verificar que la mascota existe
            var mascota = _mascotaService.ObtenerMascotaPorId(idMascota);
            if (mascota == null)
                throw new ArgumentException($"No existe una mascota con el ID {idMascota}", nameof(idMascota));

            // Implementación simulada
            var todasLasConsultas = ObtenerTodasLasConsultas();
            return todasLasConsultas.Where(c => c.Id_Mascota == idMascota).ToList();
        }

        public List<Consulta> ObtenerConsultasPorVeterinario(int idVeterinario)
        {
            if (idVeterinario <= 0)
                throw new ArgumentException("El ID del veterinario debe ser mayor que cero", nameof(idVeterinario));

            // Verificar que el veterinario existe
            var veterinario = _veterinarioService.ObtenerVeterinarioPorId(idVeterinario);
            if (veterinario == null)
                throw new ArgumentException($"No existe un veterinario con el ID {idVeterinario}", nameof(idVeterinario));

            // Implementación simulada
            var todasLasConsultas = ObtenerTodasLasConsultas();
            return todasLasConsultas.Where(c => c.Id_Veterinario == idVeterinario).ToList();
        }

        public List<Consulta> ObtenerConsultasPorFecha(DateTime fecha)
        {
            // Implementación simulada
            var todasLasConsultas = ObtenerTodasLasConsultas();
            return todasLasConsultas.Where(c => c.Fecha.Date == fecha.Date).ToList();
        }

        public bool AgregarConsulta(Consulta consulta)
        {
            if (consulta == null)
                throw new ArgumentNullException(nameof(consulta), "La consulta no puede ser nula");

            if (consulta.Id_Mascota <= 0)
                throw new ArgumentException("Se requiere una mascota válida", nameof(consulta));

            if (consulta.Id_Veterinario <= 0)
                throw new ArgumentException("Se requiere un veterinario válido", nameof(consulta));

            if (string.IsNullOrWhiteSpace(consulta.Motivo))
                throw new ArgumentException("El motivo de la consulta es requerido", nameof(consulta));

            // Verificar que la mascota existe
            var mascota = _mascotaService.ObtenerMascotaPorId(consulta.Id_Mascota);
            if (mascota == null)
                throw new ArgumentException($"No existe una mascota con el ID {consulta.Id_Mascota}", nameof(consulta));

            // Verificar que el veterinario existe
            var veterinario = _veterinarioService.ObtenerVeterinarioPorId(consulta.Id_Veterinario);
            if (veterinario == null)
                throw new ArgumentException($"No existe un veterinario con el ID {consulta.Id_Veterinario}", nameof(consulta));

            // Implementación real: return _repository.Add(consulta);
            return true;
        }

        public bool ActualizarConsulta(Consulta consulta)
        {
            if (consulta == null)
                throw new ArgumentNullException(nameof(consulta), "La consulta no puede ser nula");

            if (consulta.Id_Consulta <= 0)
                throw new ArgumentException("ID de consulta inválido", nameof(consulta));

            if (consulta.Id_Mascota <= 0)
                throw new ArgumentException("Se requiere una mascota válida", nameof(consulta));

            if (consulta.Id_Veterinario <= 0)
                throw new ArgumentException("Se requiere un veterinario válido", nameof(consulta));

            if (string.IsNullOrWhiteSpace(consulta.Motivo))
                throw new ArgumentException("El motivo de la consulta es requerido", nameof(consulta));

            // Verificar que la mascota existe
            var mascota = _mascotaService.ObtenerMascotaPorId(consulta.Id_Mascota);
            if (mascota == null)
                throw new ArgumentException($"No existe una mascota con el ID {consulta.Id_Mascota}", nameof(consulta));

            // Verificar que el veterinario existe
            var veterinario = _veterinarioService.ObtenerVeterinarioPorId(consulta.Id_Veterinario);
            if (veterinario == null)
                throw new ArgumentException($"No existe un veterinario con el ID {consulta.Id_Veterinario}", nameof(consulta));

            // Implementación real: return _repository.Update(consulta);
            return true;
        }

        public bool EliminarConsulta(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de la consulta debe ser mayor que cero", nameof(id));

            // Implementación real: return _repository.Delete(id);
            return true;
        }
    }
}
