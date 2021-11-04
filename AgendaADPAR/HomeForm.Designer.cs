
namespace AgendaADPAR
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.tlp_Home01 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_HomeSuperiorDireito = new System.Windows.Forms.Panel();
            this.btl_HomeMaximizar = new System.Windows.Forms.Panel();
            this.btn_HomeFechar = new System.Windows.Forms.Panel();
            this.btn_HomeMinimizar = new System.Windows.Forms.Panel();
            this.btn_HomeNormal = new System.Windows.Forms.Panel();
            this.tlp_Home02 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_HomeSupeiorEsquerdo = new System.Windows.Forms.Panel();
            this.ms_HomeMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IgrejasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interiorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp_Home03 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Principal = new System.Windows.Forms.Panel();
            this.tlp_Home01.SuspendLayout();
            this.pnl_HomeSuperiorDireito.SuspendLayout();
            this.tlp_Home02.SuspendLayout();
            this.ms_HomeMenuPrincipal.SuspendLayout();
            this.tlp_Home03.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Home01
            // 
            this.tlp_Home01.BackColor = System.Drawing.Color.Transparent;
            this.tlp_Home01.ColumnCount = 2;
            this.tlp_Home01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Home01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlp_Home01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Home01.Controls.Add(this.pnl_HomeSuperiorDireito, 1, 0);
            this.tlp_Home01.Controls.Add(this.tlp_Home02, 0, 0);
            this.tlp_Home01.Controls.Add(this.ms_HomeMenuPrincipal, 0, 1);
            this.tlp_Home01.Controls.Add(this.tlp_Home03, 0, 2);
            this.tlp_Home01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Home01.Location = new System.Drawing.Point(0, 0);
            this.tlp_Home01.Name = "tlp_Home01";
            this.tlp_Home01.RowCount = 4;
            this.tlp_Home01.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlp_Home01.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlp_Home01.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Home01.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_Home01.Size = new System.Drawing.Size(936, 545);
            this.tlp_Home01.TabIndex = 0;
            // 
            // pnl_HomeSuperiorDireito
            // 
            this.pnl_HomeSuperiorDireito.Controls.Add(this.btl_HomeMaximizar);
            this.pnl_HomeSuperiorDireito.Controls.Add(this.btn_HomeFechar);
            this.pnl_HomeSuperiorDireito.Controls.Add(this.btn_HomeMinimizar);
            this.pnl_HomeSuperiorDireito.Controls.Add(this.btn_HomeNormal);
            this.pnl_HomeSuperiorDireito.Location = new System.Drawing.Point(855, 3);
            this.pnl_HomeSuperiorDireito.Name = "pnl_HomeSuperiorDireito";
            this.pnl_HomeSuperiorDireito.Size = new System.Drawing.Size(78, 26);
            this.pnl_HomeSuperiorDireito.TabIndex = 1;
            // 
            // btl_HomeMaximizar
            // 
            this.btl_HomeMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btl_HomeMaximizar.BackgroundImage")));
            this.btl_HomeMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btl_HomeMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btl_HomeMaximizar.Location = new System.Drawing.Point(27, 0);
            this.btl_HomeMaximizar.Name = "btl_HomeMaximizar";
            this.btl_HomeMaximizar.Size = new System.Drawing.Size(23, 26);
            this.btl_HomeMaximizar.TabIndex = 5;
            this.btl_HomeMaximizar.Click += new System.EventHandler(this.btn_HomeMaximizar_Click);
            // 
            // btn_HomeFechar
            // 
            this.btn_HomeFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HomeFechar.BackgroundImage")));
            this.btn_HomeFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HomeFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HomeFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_HomeFechar.Location = new System.Drawing.Point(55, 0);
            this.btn_HomeFechar.Name = "btn_HomeFechar";
            this.btn_HomeFechar.Size = new System.Drawing.Size(23, 26);
            this.btn_HomeFechar.TabIndex = 2;
            this.btn_HomeFechar.Click += new System.EventHandler(this.btn_HomeFechar_Click);
            // 
            // btn_HomeMinimizar
            // 
            this.btn_HomeMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HomeMinimizar.BackgroundImage")));
            this.btn_HomeMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HomeMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HomeMinimizar.Location = new System.Drawing.Point(0, 0);
            this.btn_HomeMinimizar.Name = "btn_HomeMinimizar";
            this.btn_HomeMinimizar.Size = new System.Drawing.Size(23, 26);
            this.btn_HomeMinimizar.TabIndex = 3;
            this.btn_HomeMinimizar.Click += new System.EventHandler(this.btn_HomeMinimizar_Click);
            // 
            // btn_HomeNormal
            // 
            this.btn_HomeNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HomeNormal.BackgroundImage")));
            this.btn_HomeNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HomeNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HomeNormal.Location = new System.Drawing.Point(28, 0);
            this.btn_HomeNormal.Name = "btn_HomeNormal";
            this.btn_HomeNormal.Size = new System.Drawing.Size(23, 26);
            this.btn_HomeNormal.TabIndex = 3;
            this.btn_HomeNormal.Visible = false;
            this.btn_HomeNormal.Click += new System.EventHandler(this.btl_HomeNormal_Click);
            // 
            // tlp_Home02
            // 
            this.tlp_Home02.ColumnCount = 2;
            this.tlp_Home02.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp_Home02.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Home02.Controls.Add(this.pnl_HomeSupeiorEsquerdo, 0, 0);
            this.tlp_Home02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Home02.Location = new System.Drawing.Point(3, 3);
            this.tlp_Home02.Name = "tlp_Home02";
            this.tlp_Home02.RowCount = 1;
            this.tlp_Home02.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Home02.Size = new System.Drawing.Size(846, 26);
            this.tlp_Home02.TabIndex = 2;
            // 
            // pnl_HomeSupeiorEsquerdo
            // 
            this.pnl_HomeSupeiorEsquerdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_HomeSupeiorEsquerdo.BackgroundImage")));
            this.pnl_HomeSupeiorEsquerdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_HomeSupeiorEsquerdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_HomeSupeiorEsquerdo.Location = new System.Drawing.Point(3, 3);
            this.pnl_HomeSupeiorEsquerdo.Name = "pnl_HomeSupeiorEsquerdo";
            this.pnl_HomeSupeiorEsquerdo.Size = new System.Drawing.Size(74, 20);
            this.pnl_HomeSupeiorEsquerdo.TabIndex = 0;
            // 
            // ms_HomeMenuPrincipal
            // 
            this.ms_HomeMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.ms_HomeMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ms_HomeMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.EditarToolStripMenuItem,
            this.DepartamentosToolStripMenuItem,
            this.IgrejasToolStripMenuItem,
            this.interiorToolStripMenuItem,
            this.agendaToolStripMenuItem1});
            this.ms_HomeMenuPrincipal.Location = new System.Drawing.Point(0, 32);
            this.ms_HomeMenuPrincipal.Name = "ms_HomeMenuPrincipal";
            this.ms_HomeMenuPrincipal.Size = new System.Drawing.Size(852, 24);
            this.ms_HomeMenuPrincipal.TabIndex = 3;
            this.ms_HomeMenuPrincipal.Text = "MenuPrincipal";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // EditarToolStripMenuItem
            // 
            this.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem";
            this.EditarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.EditarToolStripMenuItem.Text = "Editar";
            // 
            // DepartamentosToolStripMenuItem
            // 
            this.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem";
            this.DepartamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.DepartamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // IgrejasToolStripMenuItem
            // 
            this.IgrejasToolStripMenuItem.Name = "IgrejasToolStripMenuItem";
            this.IgrejasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.IgrejasToolStripMenuItem.Text = "Igrejas";
            // 
            // interiorToolStripMenuItem
            // 
            this.interiorToolStripMenuItem.Name = "interiorToolStripMenuItem";
            this.interiorToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.interiorToolStripMenuItem.Text = "Interior";
            // 
            // agendaToolStripMenuItem1
            // 
            this.agendaToolStripMenuItem1.Name = "agendaToolStripMenuItem1";
            this.agendaToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.agendaToolStripMenuItem1.Text = "Agenda";
            this.agendaToolStripMenuItem1.Click += new System.EventHandler(this.agendaToolStripMenuItem1_Click);
            // 
            // tlp_Home03
            // 
            this.tlp_Home03.ColumnCount = 2;
            this.tlp_Home03.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp_Home03.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Home03.Controls.Add(this.pnl_Principal, 1, 0);
            this.tlp_Home03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Home03.Location = new System.Drawing.Point(3, 83);
            this.tlp_Home03.Name = "tlp_Home03";
            this.tlp_Home03.RowCount = 1;
            this.tlp_Home03.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Home03.Size = new System.Drawing.Size(846, 409);
            this.tlp_Home03.TabIndex = 4;
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Principal.Location = new System.Drawing.Point(83, 3);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(760, 403);
            this.pnl_Principal.TabIndex = 0;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 545);
            this.Controls.Add(this.tlp_Home01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.ms_HomeMenuPrincipal;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.tlp_Home01.ResumeLayout(false);
            this.tlp_Home01.PerformLayout();
            this.pnl_HomeSuperiorDireito.ResumeLayout(false);
            this.tlp_Home02.ResumeLayout(false);
            this.ms_HomeMenuPrincipal.ResumeLayout(false);
            this.ms_HomeMenuPrincipal.PerformLayout();
            this.tlp_Home03.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Home01;
        private System.Windows.Forms.Panel pnl_HomeSuperiorDireito;
        private System.Windows.Forms.Panel btn_HomeMinimizar;
        private System.Windows.Forms.Panel btn_HomeFechar;
        private System.Windows.Forms.Panel btl_HomeMaximizar;
        private System.Windows.Forms.Panel btn_HomeNormal;
        private System.Windows.Forms.TableLayoutPanel tlp_Home02;
        private System.Windows.Forms.Panel pnl_HomeSupeiorEsquerdo;
        private System.Windows.Forms.MenuStrip ms_HomeMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IgrejasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interiorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tlp_Home03;
        private System.Windows.Forms.Panel pnl_Principal;
    }
}