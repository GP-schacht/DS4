using System;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void enunciado1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnunciado1 frmEnunciado1 = new frmEnunciado1
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frmEnunciado1.Show();
        }

        private void enunciado2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmEnunciado2 frmEnunciado2 = new frmEnunciado2
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frmEnunciado2.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
