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
    public partial class Registrar : Form
    {
        Form1 form1 = new Form1();

        public Registrar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1. Show();
        }

        private void txtcontra_Validating(object sender, CancelEventArgs e)
        {
            bool succes = int.TryParse(txtcontra.Text, out int Repuesta);
            if (!succes)
            {

                errorProvider1.SetError(txtcontra, "Solo valido valores numericos");
                e.Cancel = true;
            }
        }

        private void txtcontra_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtcontra, "");
        }
    }
 }

