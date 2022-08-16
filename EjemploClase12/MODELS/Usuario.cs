using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase12.MODELS
{
    internal class Usuario
    {

        public class Usuarios
        {


            public Usuarios()
            {
                this.Id = 0;
                this.Nombre = String.Empty;
                this.Apellido = String.Empty;
                this.NombreUsuario = String.Empty;
                this.Mail = String.Empty;
                this.Password = String.Empty;



            }

            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string NombreUsuario { get; set; }
            public string Mail { get; set; }
            public string Password { get; set; }


        }



















    }




}

}        