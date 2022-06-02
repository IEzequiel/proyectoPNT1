using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Estudiante
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        // public int IdCurso { get; set; } 
        public Curso Curso { get; set; }
        public Hobby HobbyFavorito { get; set; }
    }
}
