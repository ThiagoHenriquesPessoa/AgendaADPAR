using AgendaADPAR.Views.AgendaViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaADPAR.Views
{
    public partial class AgendaForm : Form
    {
        
        public AgendaForm()
        {
            InitializeComponent();
        }
        private void AbrirFormPainel(object PnlForm)
        {
            if (this.pnl_Agenda.Controls.Count > 0)
            {
                this.pnl_Agenda.Controls.RemoveAt(0);
            }
            Form PF = PnlForm as Form;
            PF.TopLevel = false;
            PF.Dock = DockStyle.Fill;
            this.pnl_Agenda.Controls.Add(PF);
            this.pnl_Agenda.Tag = PF;
            PF.Show();
        }

        private void pnl_Janeiro_Click(object sender, EventArgs e)
        {
            tlp_AgendaAno.Visible = false;
            AbrirFormPainel(new CalendarioForm());
        }
    }
}
