using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2___Guía3_MM200149
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            gbxnuevoalum.Visible = true;
            btnnuevo.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbxlistado.Visible = true;
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            gbxreporte.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gbxnuevoalum.Visible = false;
            btnnuevo.Visible = true;
        }
    }
}
