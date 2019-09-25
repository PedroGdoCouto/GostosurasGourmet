namespace SistemaGourmet
{
    partial class TelaReceita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaReceita));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnReceitaVoltaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelecao = new System.Windows.Forms.Button();
            this.rdoTodasReceitas = new System.Windows.Forms.RadioButton();
            this.lblEscolhaOpcao = new System.Windows.Forms.Label();
            this.rdoTempoPreparo = new System.Windows.Forms.RadioButton();
            this.dataGridReceita = new System.Windows.Forms.DataGridView();
            this.txtColumnIdReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnNomeReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnValorReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnDificuldadeReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnTempoPreparoReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnRendimentoReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdoDificuldadeReceita = new System.Windows.Forms.RadioButton();
            this.cboOrdenacao = new System.Windows.Forms.ComboBox();
            this.rdoCategoriaReceita = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceita)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 90);
            this.label1.TabIndex = 31;
            this.label1.Text = "Receitas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReceitaVoltaMenu,
            this.btnRegistrar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 473);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 84);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnReceitaVoltaMenu
            // 
            this.btnReceitaVoltaMenu.AutoSize = false;
            this.btnReceitaVoltaMenu.BackColor = System.Drawing.Color.White;
            this.btnReceitaVoltaMenu.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceitaVoltaMenu.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnReceitaVoltaMenu.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnReceitaVoltaMenu.Name = "btnReceitaVoltaMenu";
            this.btnReceitaVoltaMenu.Size = new System.Drawing.Size(122, 80);
            this.btnReceitaVoltaMenu.Text = "Menu";
            this.btnReceitaVoltaMenu.Click += new System.EventHandler(this.BtnReceitaVoltaMenu_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRegistrar.AutoSize = false;
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(122, 80);
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelecao);
            this.groupBox1.Controls.Add(this.rdoTodasReceitas);
            this.groupBox1.Controls.Add(this.lblEscolhaOpcao);
            this.groupBox1.Controls.Add(this.rdoTempoPreparo);
            this.groupBox1.Controls.Add(this.dataGridReceita);
            this.groupBox1.Controls.Add(this.rdoDificuldadeReceita);
            this.groupBox1.Controls.Add(this.cboOrdenacao);
            this.groupBox1.Controls.Add(this.rdoCategoriaReceita);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 398);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // btnSelecao
            // 
            this.btnSelecao.Location = new System.Drawing.Point(241, 165);
            this.btnSelecao.Name = "btnSelecao";
            this.btnSelecao.Size = new System.Drawing.Size(81, 23);
            this.btnSelecao.TabIndex = 40;
            this.btnSelecao.Text = "Selecione";
            this.btnSelecao.UseVisualStyleBackColor = true;
            this.btnSelecao.Click += new System.EventHandler(this.btnSelecao_Click);
            // 
            // rdoTodasReceitas
            // 
            this.rdoTodasReceitas.AutoSize = true;
            this.rdoTodasReceitas.Location = new System.Drawing.Point(328, 77);
            this.rdoTodasReceitas.Name = "rdoTodasReceitas";
            this.rdoTodasReceitas.Size = new System.Drawing.Size(127, 21);
            this.rdoTodasReceitas.TabIndex = 39;
            this.rdoTodasReceitas.Text = "Todas as receitas";
            this.rdoTodasReceitas.UseVisualStyleBackColor = true;
            this.rdoTodasReceitas.CheckedChanged += new System.EventHandler(this.rdoTodasReceitas_CheckedChanged);
            // 
            // lblEscolhaOpcao
            // 
            this.lblEscolhaOpcao.AutoSize = true;
            this.lblEscolhaOpcao.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaOpcao.Location = new System.Drawing.Point(1, 135);
            this.lblEscolhaOpcao.Name = "lblEscolhaOpcao";
            this.lblEscolhaOpcao.Size = new System.Drawing.Size(175, 25);
            this.lblEscolhaOpcao.TabIndex = 38;
            this.lblEscolhaOpcao.Text = "Escolha uma opção";
            // 
            // rdoTempoPreparo
            // 
            this.rdoTempoPreparo.AutoSize = true;
            this.rdoTempoPreparo.Location = new System.Drawing.Point(187, 77);
            this.rdoTempoPreparo.Name = "rdoTempoPreparo";
            this.rdoTempoPreparo.Size = new System.Drawing.Size(135, 21);
            this.rdoTempoPreparo.TabIndex = 37;
            this.rdoTempoPreparo.Text = "Tempo de preparo";
            this.rdoTempoPreparo.UseVisualStyleBackColor = true;
            this.rdoTempoPreparo.CheckedChanged += new System.EventHandler(this.rdoTempoPreparo_CheckedChanged);
            // 
            // dataGridReceita
            // 
            this.dataGridReceita.AllowUserToAddRows = false;
            this.dataGridReceita.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridReceita.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridReceita.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReceita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtColumnIdReceita,
            this.txtColumnNomeReceita,
            this.txtColumnValorReceita,
            this.txtColumnDificuldadeReceita,
            this.txtColumnTempoPreparoReceita,
            this.txtColumnRendimentoReceita});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridReceita.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridReceita.GridColor = System.Drawing.Color.White;
            this.dataGridReceita.Location = new System.Drawing.Point(6, 194);
            this.dataGridReceita.Name = "dataGridReceita";
            this.dataGridReceita.ReadOnly = true;
            this.dataGridReceita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReceita.Size = new System.Drawing.Size(544, 198);
            this.dataGridReceita.TabIndex = 2;
            this.dataGridReceita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridReceita_CellContentClick);
            // 
            // txtColumnIdReceita
            // 
            this.txtColumnIdReceita.HeaderText = "ID";
            this.txtColumnIdReceita.Name = "txtColumnIdReceita";
            this.txtColumnIdReceita.ReadOnly = true;
            this.txtColumnIdReceita.Visible = false;
            // 
            // txtColumnNomeReceita
            // 
            this.txtColumnNomeReceita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtColumnNomeReceita.HeaderText = "Nome da receita";
            this.txtColumnNomeReceita.Name = "txtColumnNomeReceita";
            this.txtColumnNomeReceita.ReadOnly = true;
            // 
            // txtColumnValorReceita
            // 
            this.txtColumnValorReceita.HeaderText = "Custo";
            this.txtColumnValorReceita.Name = "txtColumnValorReceita";
            this.txtColumnValorReceita.ReadOnly = true;
            this.txtColumnValorReceita.Width = 60;
            // 
            // txtColumnDificuldadeReceita
            // 
            this.txtColumnDificuldadeReceita.HeaderText = "Dificuldade";
            this.txtColumnDificuldadeReceita.Name = "txtColumnDificuldadeReceita";
            this.txtColumnDificuldadeReceita.ReadOnly = true;
            this.txtColumnDificuldadeReceita.Width = 80;
            // 
            // txtColumnTempoPreparoReceita
            // 
            this.txtColumnTempoPreparoReceita.HeaderText = "Tempo";
            this.txtColumnTempoPreparoReceita.Name = "txtColumnTempoPreparoReceita";
            this.txtColumnTempoPreparoReceita.ReadOnly = true;
            this.txtColumnTempoPreparoReceita.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtColumnTempoPreparoReceita.Width = 50;
            // 
            // txtColumnRendimentoReceita
            // 
            this.txtColumnRendimentoReceita.HeaderText = "Rendimento";
            this.txtColumnRendimentoReceita.Name = "txtColumnRendimentoReceita";
            this.txtColumnRendimentoReceita.ReadOnly = true;
            this.txtColumnRendimentoReceita.Width = 90;
            // 
            // rdoDificuldadeReceita
            // 
            this.rdoDificuldadeReceita.AutoSize = true;
            this.rdoDificuldadeReceita.Location = new System.Drawing.Point(93, 77);
            this.rdoDificuldadeReceita.Name = "rdoDificuldadeReceita";
            this.rdoDificuldadeReceita.Size = new System.Drawing.Size(88, 21);
            this.rdoDificuldadeReceita.TabIndex = 36;
            this.rdoDificuldadeReceita.Text = "Dificuldade";
            this.rdoDificuldadeReceita.UseVisualStyleBackColor = true;
            this.rdoDificuldadeReceita.CheckedChanged += new System.EventHandler(this.rdoDificuldadeReceita_CheckedChanged);
            // 
            // cboOrdenacao
            // 
            this.cboOrdenacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenacao.FormattingEnabled = true;
            this.cboOrdenacao.Location = new System.Drawing.Point(6, 163);
            this.cboOrdenacao.Name = "cboOrdenacao";
            this.cboOrdenacao.Size = new System.Drawing.Size(229, 25);
            this.cboOrdenacao.TabIndex = 1;
            // 
            // rdoCategoriaReceita
            // 
            this.rdoCategoriaReceita.AutoSize = true;
            this.rdoCategoriaReceita.Checked = true;
            this.rdoCategoriaReceita.Location = new System.Drawing.Point(6, 77);
            this.rdoCategoriaReceita.Name = "rdoCategoriaReceita";
            this.rdoCategoriaReceita.Size = new System.Drawing.Size(81, 21);
            this.rdoCategoriaReceita.TabIndex = 35;
            this.rdoCategoriaReceita.TabStop = true;
            this.rdoCategoriaReceita.Text = "Categoria";
            this.rdoCategoriaReceita.UseVisualStyleBackColor = true;
            this.rdoCategoriaReceita.CheckedChanged += new System.EventHandler(this.rdoCategoriaReceita_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecione o filtro";
            // 
            // TelaReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TelaReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receita - Pesquisa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaReceita_FormClosing);
            this.Load += new System.EventHandler(this.TelaReceita_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnReceitaVoltaMenu;        
        private System.Windows.Forms.ToolStripMenuItem btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEscolhaOpcao;
        private System.Windows.Forms.RadioButton rdoTempoPreparo;
        private System.Windows.Forms.DataGridView dataGridReceita;
        private System.Windows.Forms.RadioButton rdoDificuldadeReceita;
        private System.Windows.Forms.ComboBox cboOrdenacao;
        private System.Windows.Forms.RadioButton rdoCategoriaReceita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoTodasReceitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnIdReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnNomeReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnValorReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnDificuldadeReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnTempoPreparoReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnRendimentoReceita;
        private System.Windows.Forms.Button btnSelecao;
    }
}