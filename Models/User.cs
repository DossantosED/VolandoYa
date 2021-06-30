using System;
using System.ComponentModel.DataAnnotations;


namespace VolandoYa.Models
{
    public class User
    {
        public int id { get; set; }
        [Display(Name="Usuario")]
        [Required(ErrorMessage = "Ingrese un nombre de usuario.")]
        [MinLength(4,ErrorMessage = "Ingrese al menos 4 caracteres")]
        public String user { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Ingrese un email.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido.")]
        public String email { get; set; }

        [Display(Name = "Contraseña")]
        [MinLength(4, ErrorMessage = "Ingrese al menos 4 caracteres")]
        [Required(ErrorMessage = "Ingrese una contraseña.")]
        public String password { get; set; }

    }
}
