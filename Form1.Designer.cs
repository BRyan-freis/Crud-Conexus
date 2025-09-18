namespace CrudCreateConexus
{
    partial class frmCadastrodeClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrodeClientes));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientPanel2 = new GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new GradientPanel();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbCadastro = new System.Windows.Forms.TabPage();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtParticipante = new System.Windows.Forms.TextBox();
            this.lblNomeSocial = new System.Windows.Forms.Label();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.tbConsulta = new System.Windows.Forms.TabPage();
            this.lstCliente = new System.Windows.Forms.ListView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(475, 389);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(149, 42);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "Excluir Cliente";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel2.Angle = 90F;
            this.gradientPanel2.AutoSize = true;
            this.gradientPanel2.ColorBottom = System.Drawing.Color.MediumSlateBlue;
            this.gradientPanel2.ColorTop = System.Drawing.Color.SlateBlue;
            this.gradientPanel2.Controls.Add(this.label5);
            this.gradientPanel2.Controls.Add(this.panel1);
            this.gradientPanel2.Controls.Add(this.label4);
            this.gradientPanel2.Controls.Add(this.label3);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Location = new System.Drawing.Point(-4, -9);
            this.gradientPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(995, 74);
            this.gradientPanel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "Conexus";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(823, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 40);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(592, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(40, 20, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sobre Nós";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(520, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(40, 20, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Agenda ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(414, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(40, 20, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abordagem";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(352, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(40, 20, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.AutoSize = true;
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Aquamarine;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumSlateBlue;
            this.gradientPanel1.Controls.Add(this.btnExcluirCliente);
            this.gradientPanel1.Controls.Add(this.btnNovoCliente);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.tbControl);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(988, 453);
            this.gradientPanel1.TabIndex = 4;
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Location = new System.Drawing.Point(647, 401);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCliente.TabIndex = 10;
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovoCliente.AutoSize = true;
            this.btnNovoCliente.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNovoCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNovoCliente.Location = new System.Drawing.Point(301, 389);
            this.btnNovoCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(149, 42);
            this.btnNovoCliente.TabIndex = 6;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = false;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(87, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 39);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fluxo de Usuários";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbControl
            // 
            this.tbControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbControl.Controls.Add(this.tbCadastro);
            this.tbControl.Controls.Add(this.tbConsulta);
            this.tbControl.Location = new System.Drawing.Point(104, 147);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(810, 236);
            this.tbControl.TabIndex = 2;
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.txtHora);
            this.tbCadastro.Controls.Add(this.lblCPF);
            this.tbCadastro.Controls.Add(this.txtData);
            this.tbCadastro.Controls.Add(this.lblemail);
            this.tbCadastro.Controls.Add(this.txtParticipante);
            this.tbCadastro.Controls.Add(this.lblNomeSocial);
            this.tbCadastro.Controls.Add(this.txtTema);
            this.tbCadastro.Controls.Add(this.lblNomeCompleto);
            this.tbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastro.Size = new System.Drawing.Size(802, 210);
            this.tbCadastro.TabIndex = 0;
            this.tbCadastro.Text = "Dados de Clientes";
            this.tbCadastro.UseVisualStyleBackColor = true;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(143, 139);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(124, 26);
            this.txtHora.TabIndex = 7;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblCPF.Location = new System.Drawing.Point(61, 142);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(47, 21);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "Hora";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(143, 99);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(367, 26);
            this.txtData.TabIndex = 5;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblemail.Location = new System.Drawing.Point(59, 101);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(46, 21);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "Data";
            // 
            // txtParticipante
            // 
            this.txtParticipante.Location = new System.Drawing.Point(143, 61);
            this.txtParticipante.Name = "txtParticipante";
            this.txtParticipante.Size = new System.Drawing.Size(367, 26);
            this.txtParticipante.TabIndex = 3;
            // 
            // lblNomeSocial
            // 
            this.lblNomeSocial.AutoSize = true;
            this.lblNomeSocial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSocial.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblNomeSocial.Location = new System.Drawing.Point(28, 61);
            this.lblNomeSocial.Name = "lblNomeSocial";
            this.lblNomeSocial.Size = new System.Drawing.Size(103, 21);
            this.lblNomeSocial.TabIndex = 2;
            this.lblNomeSocial.Text = "Participante";
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(143, 22);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(367, 26);
            this.txtTema.TabIndex = 1;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblNomeCompleto.Location = new System.Drawing.Point(59, 22);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(51, 21);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Tema";
            // 
            // tbConsulta
            // 
            this.tbConsulta.Controls.Add(this.lstCliente);
            this.tbConsulta.Controls.Add(this.btnPesquisar);
            this.tbConsulta.Controls.Add(this.txtBuscar);
            this.tbConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbConsulta.Name = "tbConsulta";
            this.tbConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsulta.Size = new System.Drawing.Size(802, 210);
            this.tbConsulta.TabIndex = 1;
            this.tbConsulta.Text = "Consulta";
            this.tbConsulta.UseVisualStyleBackColor = true;
            // 
            // lstCliente
            // 
            this.lstCliente.ContextMenuStrip = this.contextMenuStrip1;
            this.lstCliente.HideSelection = false;
            this.lstCliente.Location = new System.Drawing.Point(9, 53);
            this.lstCliente.MultiSelect = false;
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(785, 152);
            this.lstCliente.TabIndex = 3;
            this.lstCliente.UseCompatibleStateImageBehavior = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(178, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(113, 36);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(11, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(155, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // frmCadastrodeClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(988, 453);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastrodeClientes";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.tbCadastro.PerformLayout();
            this.tbConsulta.ResumeLayout(false);
            this.tbConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbCadastro;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtParticipante;
        private System.Windows.Forms.Label lblNomeSocial;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TabPage tbConsulta;
        private System.Windows.Forms.Button btnSalvar;
        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.ListView lstCliente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

