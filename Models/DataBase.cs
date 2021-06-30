using System.Collections.Generic;


namespace VolandoYa.Models
{
    public class DataBase
    {
        public static List<User> ListaUsuarios { get; set; } = new List<User>();

        public static List<Vuelo> ListaVuelos { get; set; } = new List<Vuelo>();


        public static string buscarUsuario(string usuario, string email)
        {
            string encontro = null;
            int i = 0;

            while (encontro == null && i< ListaUsuarios.Count )
            {
                if (usuario == ListaUsuarios[i].user) {
                    encontro = "user";
                }
                else if(email == ListaUsuarios[i].email)
                {
                    encontro = "email";
                }
                i++;
            }

            return encontro;

        }

    }
}
