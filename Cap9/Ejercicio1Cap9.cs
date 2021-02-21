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
    public partial class Ejercicio1Cap9 : Form
    {
        public Ejercicio1Cap9()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            PrecioTextBox.Clear();
            NombreTextBox.Clear();
            ArticulosListBox.Items.Clear();
        }

        public struct Productos
        {
            public string Nombre;
            public double Precio;

            public Productos(string Nombre, double Precio)
            {
                this.Nombre = Nombre;
                this.Precio = Precio;
            }
            public override string ToString()
            {
                StringBuilder cadena = new StringBuilder();
                cadena.AppendFormat($"Nombre: {Nombre} \tPrecio: {Convert.ToString(Precio)}");
                return cadena.ToString();
            }
        }

        Productos[] producto = new Productos[10];
        int contador = 0;

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            producto[contador].Precio = Convert.ToDouble(PrecioTextBox.Text);
            producto[contador].Nombre = NombreTextBox.Text;
            contador++;
            Limpiar();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            for (int i = 0; i < contador; i++)
            {
                ArticulosListBox.Items.Add(producto[i].ToString());
            }
        }
    }
}
