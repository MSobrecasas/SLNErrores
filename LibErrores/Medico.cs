using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibErrores
{
    public class Medico
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new Exception("El nombre no puede ser menor que 1");
                }
                if (value.Trim().Length > 50)
                {
                    throw new Exception("El nombre no puede ser mayor que 50");
                }
                nombre = value.Trim();
            }
        }

        private string apellido;
        public string Apellido { get; set; }

        private int matricula;
        public int Matricula { get; set; }
    }
}
