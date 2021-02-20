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
    public partial class Capitulo8 : Form
    {
        public Capitulo8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ejercicio3Cap8 ej3 = new Ejercicio3Cap8();
            ej3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ejercicio5Cap8 ej5 = new Ejercicio5Cap8();
            ej5.Show();
        }
    }
}
