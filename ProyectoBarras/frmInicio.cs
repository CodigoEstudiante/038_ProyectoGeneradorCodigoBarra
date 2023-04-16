using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarras
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btngenerarmanualmente_Click(object sender, EventArgs e)
        {
            Form1 FormularioVista = new Form1();
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosing += Frm_Closing;
        }

        private void btngenerarmasivamente_Click(object sender, EventArgs e)
        {
            frmMasivo FormularioVista = new frmMasivo();
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosing += Frm_Closing;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninformacionrapida_Click(object sender, EventArgs e)
        {
            mdAcercade form = new mdAcercade();
            form.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ouo.io/RK1tRH");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
