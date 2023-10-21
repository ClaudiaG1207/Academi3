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
    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
            InitializeComponent();
        }

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Pagos pagos = new Pagos();
            pagos.Show();
        }
    }
}
