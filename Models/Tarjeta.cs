using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VolandoYa.Models
{
    public class Tarjeta
    {
        public int id { get; set; }
        public int Numero { get; set; }

        public String Titular { get; set; }

        public int CodigoSeguridad { get; set; }

        public String Vencimiento { get; set; }
    }
}
