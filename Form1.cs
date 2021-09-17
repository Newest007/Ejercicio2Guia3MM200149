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
            btnlistado.Visible = false;
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            gbxreporte.Visible = true;
            btnreporte.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gbxnuevoalum.Visible = false;
            btnnuevo.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatosBásicos alum = new DatosBásicos();
            AlumnoCarnet datosalum = new AlumnoCarnet();
            alum.Carnet = txtcarnet.Text;
            datosalum.Carnet = txtcarnet.Text;
            alum.Nombre = txtnombre.Text;
            datosalum.Nombre = txtnombre.Text;
            alum.Apellido = txtapellido.Text;
            alum.Materia = txtmateria.Text;
            alum.Calificaciones = float.Parse(txtcalificaciones.Text);

            if(edit_indice > -1)
            {
                Datos[edit_indice] = alum;
                Alumno[edit_indice] = datosalum;
                edit_indice = -1;
            }
            else
            {
                Datos.Add(alum);
                Alumno.Add(datosalum);
            }

            ActualizarGrid();


            txtcarnet.Clear();
            txtmateria.Clear();
            txtnombre.Clear();
            txtcalificaciones.Clear();
            txtapellido.Clear();

            MessageBox.Show("Datos añadidos correctamente", "Éxito");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private List<DatosBásicos> Datos = new List<DatosBásicos>();
        private List<AlumnoCarnet> Alumno = new List<AlumnoCarnet>();
        private int edit_indice = -1;

        private void ActualizarGrid()
        {
            dtgestudiantes.DataSource = null;
            dtgestudiantes.DataSource = Alumno;
            dtgreporte.DataSource = null;
            dtgreporte.DataSource = Datos;

        }

        private void gbxlistado_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbxlistado.Visible = false;
            btnlistado.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnreporte.Visible = true;
            gbxreporte.Visible = false;
        }
    }
}
