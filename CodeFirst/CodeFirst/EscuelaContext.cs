using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst
{
    //Esta clase es la conexión a DB que usara EntityFramework, + otras cosas
    // como el manejo de las clases de negocio a las Table de DB
    internal class EscuelaContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-GE740DJ;Database=EscuelaDB;Trusted_Connection=True");
        }
    }
    
}
