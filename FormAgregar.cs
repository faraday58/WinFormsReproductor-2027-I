using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsReproductor_2027_I
{
    public partial class FormAgregar : Form
    {
        public delegate void DAgregarCancion(Modelo.Musica cancion);
        public event DAgregarCancion AgregarCancionEvent;
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cancion = new Modelo.Musica(
                textBox1.Text,
                textBox2.Text,
                textBox3.Text
                );

            AgregarCancionEvent(cancion);

        }
    }
}
