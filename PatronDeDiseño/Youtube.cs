using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño
{
    public class Youtube : ISuscriptor
    {
        private string nombreUsuario;
        public string NombreUsuario { get { return nombreUsuario; } }
        public Youtube(String nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario;
        }
        public void actualizar(double temperatura)
        {
            Console.WriteLine("temperatura: " + temperatura + "\nse ha recibido la actualizacion por youtube " + this.nombreUsuario);
        }
    }
}
