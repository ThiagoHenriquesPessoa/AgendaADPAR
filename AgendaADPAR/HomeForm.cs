using AgendaADPAR.Views;
using System;
using System.Windows.Forms;

namespace AgendaADPAR
{
    public partial class HomeForm : Form
    {
        AgendaForm Af = new AgendaForm();
        public HomeForm()
        {
            InitializeComponent();
        }

        public void AbrirFormPainel(object PnlForm)
        {
            if (this.pnl_Principal.Controls.Count > 0)
            {
                this.pnl_Principal.Controls.RemoveAt(0);
            }
            Form PF = PnlForm as Form;
            PF.TopLevel = false;
            PF.Dock = DockStyle.Fill;
            this.pnl_Principal.Controls.Add(PF);
            this.pnl_Principal.Tag = PF;
            PF.Show();
        }


        private void btl_HomeNormal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btl_HomeMaximizar.Visible = true;
            btn_HomeNormal.Visible = false;
        }

        private void btn_HomeFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_HomeMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_HomeMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_HomeNormal.Visible = true;
            btl_HomeMaximizar.Visible = false;
        }

        private void agendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormPainel(new AgendaForm());
        }

        private void cargosAdmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormPainel(new DiretoriaAssessoriaForm());
        }

        private void DepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormPainel(new DepartamentosCoordenacoesForm());
        }

        private void ParnamirimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormPainel(new ParnamirimForm());
        }
    }
}
