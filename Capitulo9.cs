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
    public partial class Capitulo9 : Form
    {
        public Capitulo9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio1Cap9 ej1 = new Ejercicio1Cap9();
            ej1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ejercicio4Cap9 ej4 = new Ejercicio4Cap9();
            ej4.Show();
        }
    }
}
