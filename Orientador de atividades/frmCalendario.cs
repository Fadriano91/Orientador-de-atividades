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
    public partial class frmCalendario : Form
    {
        public frmCalendario()
        {
            InitializeComponent();
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
    }
}
