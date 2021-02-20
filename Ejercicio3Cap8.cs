using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cap8_9
{
    public partial class Ejercicio3Cap8 : Form
    {
        public Ejercicio3Cap8()
        {
            InitializeComponent();
        }

        private void ActualTimer_Tick(object sender, EventArgs e)
        {
            HoraLabel.Text = DateTime.Now.ToString("HH:mm:sstt");
            FechaLabel.Text = DateTime.Now.ToLongDateString();
        }
    }
}
