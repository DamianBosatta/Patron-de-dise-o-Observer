using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño
{
    public class Mail : ISuscriptor
    {
        private string correoElectonico;
        public string CorreoElectronico { get { return correoElectonico; } }
        public Mail(String correo)
        {
            this.correoElectonico = correo;
        }
        public void actualizar(double temperatura)
        {
            Console.WriteLine("temperatura: " + temperatura + "\nse ha recibido la actualizacion por mail " + this.correoElectonico);
        }
    }
}