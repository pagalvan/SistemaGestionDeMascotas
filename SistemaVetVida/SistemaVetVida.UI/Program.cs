using SistemaVetVida.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVetVida.Entities;

namespace SistemaVetVida.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar servicios
            IEspecieService especieService = new EspecieService();
            IPropietarioService propietarioService = new PropietarioService();
            IRazaService razaService = new RazaService(especieService);
            IMascotaService mascotaService = new MascotaService(propietarioService, razaService);
            IVeterinarioService veterinarioService = new VeterinarioService();

            // Mostrar datos simulados
            Console.WriteLine("=== VETERINARIOS ===");
            var veterinarios = veterinarioService.ObtenerTodosLosVeterinarios();
            foreach (var vet in veterinarios)
            {
                Console.WriteLine($"ID: {vet.Id_Veterinario}, Nombre: {vet.Nombre} {vet.Apellido}");
                Console.WriteLine($"Especialidad: {vet.Especialidad}");
                Console.WriteLine($"Contacto: {vet.Telefono}, {vet.Email}");
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("\n=== ESPECIES ===");
            var especies = especieService.ObtenerTodasLasEspecies();
            foreach (var esp in especies)
            {
                Console.WriteLine($"ID: {esp.Id_Especie}, Nombre: {esp.Nombre}");
                Console.WriteLine($"Descripción: {esp.Descripcion}");
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
