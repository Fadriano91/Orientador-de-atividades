using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orientador_de_atividades
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnNovaTarefa_Click(object sender, EventArgs e)
        {
            frmNovaTarefa f = new frmNovaTarefa();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnNovoRecado_Click(object sender, EventArgs e)
        {
            frmNovoRecado f = new frmNovoRecado();  
            f.ShowDialog();
            f.Dispose();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmVisualizar f = new frmVisualizar();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            frmCalendario f = new frmCalendario();
            f.ShowDialog();
            f.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig f = new frmConfig();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
