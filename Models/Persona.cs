using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VolandoYa.Models
{
    public class Persona
    {
        public int id { get; set; }
        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public String Genero { get; set; }

    }
}
