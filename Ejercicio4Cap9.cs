using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap8_9
{
    public partial class Ejercicio4Cap9 : Form
    {
        public Ejercicio4Cap9()
        {
            InitializeComponent();
        }

        private void Ejercicio4Cap9_Load(object sender, EventArgs e)
        {

        }

        enum Neumaticos
        {
            Asimetrico = 1, Diagonales, Tubuless, 
            Invierno, Ecologicos, Radiales, 
            ReCauchutados, Verano, PerfilBajo, TodoTerreno,
            Direccionales
        }

        private void ResultadoButton_Click(object sender, EventArgs e)
        {
            Neumaticos neumatico = Neumaticos.Asimetrico;
            int opcion = Convert.ToInt32(NumeroTextBox.Text);

            switch (opcion)
            {
                case 1:
                    ResultadoTextBox.Text = Convert.ToString(Neumaticos.Asimetrico);
                    break;

                case 2:
                    ResultadoTextBox.Text = Convert.ToString(Neumaticos.Diagonales);
                    break;

                case 3:
                    ResultadoTextBox.Text = Convert.ToString(Neumaticos.Tubuless);
                    break;

                case 4:
                    ResultadoTextBox.Text = Convert.ToString(Neumaticos.Invierno);
                    break;

                case 5:
                    ResultadoTextBox.Text = Convert.ToString(Neumaticos.Ecologicos);
                    break;

                case 6:
                    ResultadoTextBox.Text = Convert.ToString(Neumaticos.Radiales);
                    break;

                case 7:
                    ResultadoTextBox.Text = Convert.ToString(Neumaticos.ReCauchutados);
                    break;

                case 8:
                    ResultadoTextBox.Text = Convert.ToString(Neumaticos.Verano);
                    break;

                case 9:
                    ResultadoTextBox.Text = Convert.ToString(Neumaticos.PerfilBajo);
                    break;

                case 10:
                    ResultadoTextBox.Text = Convert.ToString(Neumaticos.TodoTerreno);
                    break;
                case 11:
                    ResultadoTextBox.Text = Convert.ToString(Neumaticos.Direccionales);
                    break;

                default:
                    MessageBox.Show("Debe ser un numero entre 1 y 11!", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
