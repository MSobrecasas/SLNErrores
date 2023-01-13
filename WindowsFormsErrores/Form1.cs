using LibErrores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsErrores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCrear_Click(object sender, EventArgs e)
        {
            MenorUno();
            MayorCincuenta();
            NombreValido();
        }

        private static void MenorUno()
        {
            try
            {
                Medico medico = new Medico() { Nombre = "", Apellido = "", Matricula = 123 };
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error menor de 1");
            }
        }

        private static void MayorCincuenta()
        {
            try
            {
                Medico medico = new Medico() { Nombre = "111111111111111111111111111111111111111111111111111", Apellido = "", Matricula = 123 };
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error mayor de 50");
            }
        }
        private static void NombreValido()
        {
            try
            {
                Medico medico = new Medico() { Nombre = " Juan  ", Apellido = "Perez", Matricula = 123 };
                MessageBox.Show("Nombre: " + medico.Nombre + medico.Apellido + " Matricula: " + medico.Matricula, "Creado Correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
