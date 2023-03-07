using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana2
{
    public partial class Form1 : Form
    {
        Form2 ventana;

        public Form1()

        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventana = new Form2();
            ventana.ShowDialog();

            Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            string usuario = Microsoft.VisualBasic.Interacction.imputBox("Escribe el ususario", "Pedir ususario ");
            string password = Microsoft.VisualBasic.Interacction.imputBox





        }
        StreamWriter fichero;
        fichero = File.AppendText("Acesso , directo ");

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            {

            }
        }
    }
}