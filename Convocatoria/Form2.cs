using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convocatoria
{
    public partial class Form2 : Form
    {
        public static List<Docente> Datos_Docente = new List<Docente>();
        public static List<Estudiante> Datos_Estudiante = new List<Estudiante>();
        public static List<Matricula> Datos_Matricula = new List<Matricula>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnguardardoc_Click(object sender, EventArgs e)
        {
            Datos_Docente.Add(new Docente
            {
                Nombre = txtNombre.Text,
                Apellido = txtApe.Text,
                Fecha_Nacimiento = txtFecha.Text,
                Direccion = txtDireccion.Text,
                numero_celular = int.Parse(txtTelf.Text),
                Codigo_Docente = txtCodDoc.Text

            });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos_Estudiante.Add(new Estudiante
            {
                Nombre_Estudiante = txtEstNom.Text,
                Apellido = txtApellidoEst.Text,
                Fecha_Nacimiento = txtFechaEst.Text,
                numero_celular = int.Parse(txtCel.Text),
                Direccion = txtDir.Text,
                Codigo_Estudiantil = txtCodEst.Text,

            });

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtCdEst.Clear();
            txtCdDoce.Clear();
            txtNombreDoce.Clear();
            txtAsig.Clear();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            dgvDocente.DataSource = null;
            dgvDocente.DataSource = Datos_Docente;


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApe.Clear();
            txtFecha.Clear();
            txtDireccion.Clear();
            txtTelf.Clear();
            txtCodDoc.Clear();

        }

        private void btnLimpiarDc_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApe.Clear();
            txtFecha.Clear();
            txtDireccion.Clear();
            txtTelf.Clear();
            txtCodDoc.Clear();
        }

        private void btnMatri_Click(object sender, EventArgs e)
        {
            Datos_Matricula.Add(new Matricula
            {
                NomEst = txtNom.Text,
                CDEst = txtCdEst.Text,
                NomDocent = txtNombreDoce.Text,
                CDDocent = txtCdDoce.Text,
                Asig = txtAsig.Text,
                Nota = int.Parse(txtNota.Text)

            });

            txtNom.Clear();
            txtCdEst.Clear();
            txtNombreDoce.Clear();
            txtCdDoce.Clear();
            txtAsig.Clear();
            txtNota.Clear();

        }

        private void btnMostrarMat_Click(object sender, EventArgs e)
        {
            dgvMatricula.DataSource = null;
            dgvMatricula.DataSource = Datos_Matricula;
        }

        private void btnLinQ_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvEstudiante.DataSource = null;
            dgvEstudiante.DataSource = Datos_Estudiante;
        }
    }
}
