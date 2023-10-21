using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecAcademiaEuropea
{
    public partial class ResgistroPersonal : Form
    {
        public ResgistroPersonal()
        {
            InitializeComponent();
        }
        NPersonal Personal = new NPersonal();
        public string FCedula;
        public string FNomAp;
        public string FDirec;
        public int FEdad;
        public int FCel;
        public string FCorreo;
        public string FNacionalidad;
        int idPersonal;
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal FP = new FormPrincipal();
            FP.Show();
        }

        private void ResgistroPersonal_Load(object sender, EventArgs e)
        {

        }
        private void MostrarPersonal()
        {
            DataTable dt = new DataTable();
            NEstudiantes funcion = new NEstudiantes();
            funcion.MostarEstudiante(dt);
            dtPersonal.DataSource = dt;
            Bases.DiseñoDtv(ref dtPersonal);
        }
        private void EliminarPersonal()
        {
            idPersonal = int.Parse(dtPersonal.SelectedCells[3].Value.ToString());
            Personal.EliminarPersonal(idPersonal);
        }
        private void dtPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtPersonal.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este estudiante?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    EliminarPersonal();
                    MostrarPersonal();
                }

            }
            if (e.ColumnIndex == dtPersonal.Columns["Editar"].Index)
            {
                CapturarDatos();
                BtnEditar.Visible = true;
                BtnGuardar.Visible = false;
            }

        }

        private void CapturarDatos()
        {

            idPersonal = int.Parse(dtPersonal.SelectedCells[3].Value.ToString());
            TxtCedulaPer.Text = dtPersonal.SelectedCells[4].Value.ToString();
            txtNomPer.Text = dtPersonal.SelectedCells[5].Value.ToString();
            TxtDirecPer.Text = dtPersonal.SelectedCells[6].Value.ToString();
            TxtEdadPer.Text = dtPersonal.SelectedCells[7].Value.ToString();
            TxtTelefPer.Text = dtPersonal.SelectedCells[8].Value.ToString();
            TxtCorreoPer.Text = dtPersonal.SelectedCells[9].Value.ToString();
            ComNacionalidadPer.Text = dtPersonal    .SelectedCells[10].Value.ToString();

        }

    }
}
