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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Cap8Button_Click(object sender, EventArgs e)
        {
            Capitulo8 cap8 = new Capitulo8();
            cap8.Show();
        }

        private void Cap9Button_Click(object sender, EventArgs e)
        {
            Capitulo9 cap9 = new Capitulo9();
            cap9.Show();
        }
    }
}
