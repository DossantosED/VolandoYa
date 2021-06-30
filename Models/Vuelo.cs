using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolandoYa.Models
{
    public class Vuelo
    {
        public int id { get; set; }

        public Aerolinea Aerolineas { get; set; }
        public Destino Destinos { get; set; }

        public String Destino { get; set; }

        public String Aerolinea { get; set; }

        [Display(Name = "Fecha de salida")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public DateTime Fecha_salida { get; set; }

        [Display(Name = "Fecha de vuelta")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public DateTime Fecha_Vuelta { get; set; }

        [Display(Name = "Lugares disponibles")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public int Lugares_Disponibles { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        public double Precio { get; set; }

    }
}
