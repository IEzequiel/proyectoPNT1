// See https://aka.ms/new-console-template for more information
using System.Linq;

namespace CodeFirst
{
    class Test
    {
        static void Main(string[] args)
        {
            /*
            using (var context = new EscuelaContext())
            {
                // Agregar un curso
                var c = new Curso()
                {
                    Nombre = "La huerta en macetas",
                    Duracion = 12
                };
                context.Cursos.Add(c);
                context.SaveChanges();
                Console.WriteLine("Curso agregado!");
                // Agregar un estudiante
                var e = new Estudiante()
                {
                    Nombre = "Analia",
                    Apellido = "Perez",
                    HobbyFavorito = Hobby.Ajedrez,
                    Curso = c
                };
                context.Estudiantes.Add(e);
                context.SaveChanges();
            }
                Console.WriteLine("Estudiante agregado!");
                Console.ReadKey();
            */
            using (var context = new EscuelaContext())
            {
                var estudiante = from s in context.Estudiantes
                                 orderby s.Nombre
                                 select s;
                foreach (var item in estudiante)
                {
                    Console.WriteLine($"Estudiante {item.Nombre} {item.Apellido}");
                }
                Console.ReadKey();
            }

        }
    }
}