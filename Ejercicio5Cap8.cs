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
    public partial class Ejercicio5Cap8 : Form
    {
        public Ejercicio5Cap8()
        {
            InitializeComponent();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Cadena1TextBox.Clear();
            Cadena2TextBox.Clear();
            ResultadoTextBox.Clear();
            Resultado2TextBox.Clear();
        }

        private void ResultadoButton_Click(object sender, EventArgs e)
        {
            if(string.Compare(Cadena1TextBox.Text,Cadena2TextBox.Text) < 0)
            {
                ResultadoTextBox.AppendText("1. " + Cadena1TextBox.Text);
                Resultado2TextBox.AppendText("2. " + Cadena2TextBox.Text);
            }
            else
            {
                ResultadoTextBox.AppendText("1. " + Cadena2TextBox.Text);
                Resultado2TextBox.AppendText("2. " + Cadena1TextBox.Text);
            }
        }
    }
}
