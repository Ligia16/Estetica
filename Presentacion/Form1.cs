using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        Servicios servicios = new Servicios();
        Registrar registrar = new Registrar();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            servicios.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            bool succes = int.TryParse(txtcontraseña.Text, out int Repuesta);
            if(!succes)
            {

                errorProvider1.SetError(txtcontraseña, "Solo valido valores numericos");
                e.Cancel = true;
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtcontraseña, "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registrar.Show();
        }
    }
}
