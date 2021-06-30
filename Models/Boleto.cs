using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VolandoYa.Models
{
    public class Boleto
    {
        public int id { get; set; }
        public Persona persona { get; set; }

        public Destino destino { get; set; }

        public Double Precio { get; set; }

        public DateTime fecha_salida { get; set; }

        public DateTime fecha_vuelta { get; set; }

        public Aerolinea aerolinea { get; set; }
    }
}
