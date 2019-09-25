namespace SistemaGourmet
{
    partial class TelaAlteraReceita
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlteraReceita));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDificuldadeAlteraReceita = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTempoPreparo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTxtModoPreparo = new System.Windows.Forms.RichTextBox();
            this.cmbCategoriaReceita = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridSelecaoIngrediente = new System.Windows.Forms.DataGridView();
            this.columnIdIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSelecaoIngrediente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnNomeIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnValorIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantidadeIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUnidadeIngrediente = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorReceita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRendimentoReceita = new System.Windows.Forms.TextBox();
            this.txtNomeReceita = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnConfirmaAlteracao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelaAlteracao = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastarIngredientesReceita = new System.Windows.Forms.Button();
            this.ttpTempo = new System.Windows.Forms.ToolTip(this.components);
            this.ttpDataGrid = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecaoIngrediente)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CadastarIngredientesReceita);
            this.groupBox1.Controls.Add(this.cmbDificuldadeAlteraReceita);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTempoPreparo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.richTxtModoPreparo);
            this.groupBox1.Controls.Add(this.cmbCategoriaReceita);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dataGridSelecaoIngrediente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtValorReceita);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRendimentoReceita);
            this.groupBox1.Controls.Add(this.txtNomeReceita);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 398);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // cmbDificuldadeAlteraReceita
            // 
            this.cmbDificuldadeAlteraReceita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDificuldadeAlteraReceita.FormattingEnabled = true;
            this.cmbDificuldadeAlteraReceita.Location = new System.Drawing.Point(138, 173);
            this.cmbDificuldadeAlteraReceita.Name = "cmbDificuldadeAlteraReceita";
            this.cmbDificuldadeAlteraReceita.Size = new System.Drawing.Size(118, 25);
            this.cmbDificuldadeAlteraReceita.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(67, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 57;
            this.label11.Text = "Tempo";
            // 
            // txtTempoPreparo
            // 
            this.txtTempoPreparo.BackColor = System.Drawing.Color.White;
            this.txtTempoPreparo.Location = new System.Drawing.Point(72, 170);
            this.txtTempoPreparo.Name = "txtTempoPreparo";
            this.txtTempoPreparo.Size = new System.Drawing.Size(60, 28);
            this.txtTempoPreparo.TabIndex = 56;
            this.txtTempoPreparo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttpTempo.SetToolTip(this.txtTempoPreparo, "O tempo é em minutos");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(295, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 25);
            this.label9.TabIndex = 55;
            this.label9.Text = "Modo de preparo";
            // 
            // richTxtModoPreparo
            // 
            this.richTxtModoPreparo.BackColor = System.Drawing.Color.White;
            this.richTxtModoPreparo.Location = new System.Drawing.Point(300, 52);
            this.richTxtModoPreparo.Name = "richTxtModoPreparo";
            this.richTxtModoPreparo.Size = new System.Drawing.Size(250, 146);
            this.richTxtModoPreparo.TabIndex = 54;
            this.richTxtModoPreparo.Text = "";
            // 
            // cmbCategoriaReceita
            // 
            this.cmbCategoriaReceita.BackColor = System.Drawing.Color.White;
            this.cmbCategoriaReceita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaReceita.FormattingEnabled = true;
            this.cmbCategoriaReceita.Location = new System.Drawing.Point(138, 114);
            this.cmbCategoriaReceita.Name = "cmbCategoriaReceita";
            this.cmbCategoriaReceita.Size = new System.Drawing.Size(118, 25);
            this.cmbCategoriaReceita.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(133, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 52;
            this.label10.Text = "Categoria";
            // 
            // dataGridSelecaoIngrediente
            // 
            this.dataGridSelecaoIngrediente.AllowUserToAddRows = false;
            this.dataGridSelecaoIngrediente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridSelecaoIngrediente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSelecaoIngrediente.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSelecaoIngrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSelecaoIngrediente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdIngrediente,
            this.columnSelecaoIngrediente,
            this.columnNomeIngrediente,
            this.columnValorIngrediente,
            this.columnQuantidadeIngrediente,
            this.columnUnidadeIngrediente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSelecaoIngrediente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSelecaoIngrediente.GridColor = System.Drawing.Color.White;
            this.dataGridSelecaoIngrediente.Location = new System.Drawing.Point(6, 204);
            this.dataGridSelecaoIngrediente.Name = "dataGridSelecaoIngrediente";
            this.dataGridSelecaoIngrediente.Size = new System.Drawing.Size(544, 157);
            this.dataGridSelecaoIngrediente.TabIndex = 51;
            this.ttpDataGrid.SetToolTip(this.dataGridSelecaoIngrediente, "Você deve adicionar um ingrediente por vez.");
            // 
            // columnIdIngrediente
            // 
            this.columnIdIngrediente.HeaderText = "ID";
            this.columnIdIngrediente.Name = "columnIdIngrediente";
            this.columnIdIngrediente.ReadOnly = true;
            this.columnIdIngrediente.Visible = false;
            // 
            // columnSelecaoIngrediente
            // 
            this.columnSelecaoIngrediente.HeaderText = "-";
            this.columnSelecaoIngrediente.Name = "columnSelecaoIngrediente";
            this.columnSelecaoIngrediente.ReadOnly = true;
            this.columnSelecaoIngrediente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnSelecaoIngrediente.Width = 20;
            // 
            // columnNomeIngrediente
            // 
            this.columnNomeIngrediente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNomeIngrediente.HeaderText = "Nome do ingrediente";
            this.columnNomeIngrediente.Name = "columnNomeIngrediente";
            this.columnNomeIngrediente.ReadOnly = true;
            // 
            // columnValorIngrediente
            // 
            this.columnValorIngrediente.HeaderText = "Valor";
            this.columnValorIngrediente.Name = "columnValorIngrediente";
            this.columnValorIngrediente.ReadOnly = true;
            // 
            // columnQuantidadeIngrediente
            // 
            this.columnQuantidadeIngrediente.HeaderText = "Quant";
            this.columnQuantidadeIngrediente.Name = "columnQuantidadeIngrediente";
            this.columnQuantidadeIngrediente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnQuantidadeIngrediente.Width = 70;
            // 
            // columnUnidadeIngrediente
            // 
            this.columnUnidadeIngrediente.HeaderText = "un";
            this.columnUnidadeIngrediente.Items.AddRange(new object[] {
            "g",
            "kg",
            "l",
            "ml",
            "un"});
            this.columnUnidadeIngrediente.Name = "columnUnidadeIngrediente";
            this.columnUnidadeIngrediente.ReadOnly = true;
            this.columnUnidadeIngrediente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnUnidadeIngrediente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnUnidadeIngrediente.Width = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Dificuldade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Valor";
            // 
            // txtValorReceita
            // 
            this.txtValorReceita.BackColor = System.Drawing.Color.White;
            this.txtValorReceita.Enabled = false;
            this.txtValorReceita.Location = new System.Drawing.Point(6, 170);
            this.txtValorReceita.Name = "txtValorReceita";
            this.txtValorReceita.ReadOnly = true;
            this.txtValorReceita.Size = new System.Drawing.Size(60, 28);
            this.txtValorReceita.TabIndex = 36;
            this.txtValorReceita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Rendimento";
            // 
            // txtRendimentoReceita
            // 
            this.txtRendimentoReceita.BackColor = System.Drawing.Color.White;
            this.txtRendimentoReceita.Location = new System.Drawing.Point(6, 111);
            this.txtRendimentoReceita.Name = "txtRendimentoReceita";
            this.txtRendimentoReceita.Size = new System.Drawing.Size(126, 28);
            this.txtRendimentoReceita.TabIndex = 34;
            this.txtRendimentoReceita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeReceita
            // 
            this.txtNomeReceita.BackColor = System.Drawing.Color.White;
            this.txtNomeReceita.Location = new System.Drawing.Point(6, 52);
            this.txtNomeReceita.Name = "txtNomeReceita";
            this.txtNomeReceita.Size = new System.Drawing.Size(250, 28);
            this.txtNomeReceita.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome da receita";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 90);
            this.label1.TabIndex = 38;
            this.label1.Text = "Alterar Receita";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfirmaAlteracao,
            this.btnCancelaAlteracao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 473);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 84);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnConfirmaAlteracao.AutoSize = false;
            this.btnConfirmaAlteracao.BackColor = System.Drawing.Color.White;
            this.btnConfirmaAlteracao.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnConfirmaAlteracao.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(122, 80);
            this.btnConfirmaAlteracao.Text = "Confirmar";
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.BtnConfirmaAlteracao_Click);
            // 
            // btnCancelaAlteracao
            // 
            this.btnCancelaAlteracao.AutoSize = false;
            this.btnCancelaAlteracao.BackColor = System.Drawing.Color.White;
            this.btnCancelaAlteracao.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCancelaAlteracao.Name = "btnCancelaAlteracao";
            this.btnCancelaAlteracao.Size = new System.Drawing.Size(122, 80);
            this.btnCancelaAlteracao.Text = "Cancelar";
            this.btnCancelaAlteracao.Click += new System.EventHandler(this.BtnCancelaAlteracao_Click);
            // 
            // CadastarIngredientesReceita
            // 
            this.CadastarIngredientesReceita.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastarIngredientesReceita.Location = new System.Drawing.Point(6, 367);
            this.CadastarIngredientesReceita.Name = "CadastarIngredientesReceita";
            this.CadastarIngredientesReceita.Size = new System.Drawing.Size(544, 25);
            this.CadastarIngredientesReceita.TabIndex = 41;
            this.CadastarIngredientesReceita.Text = "Selecione os ingredientes";
            this.CadastarIngredientesReceita.UseVisualStyleBackColor = true;
            this.CadastarIngredientesReceita.Click += new System.EventHandler(this.CadastarIngredientesReceita_Click);
            // 
            // ttpTempo
            // 
            this.ttpTempo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpTempo.ToolTipTitle = "Unidade";
            // 
            // ttpDataGrid
            // 
            this.ttpDataGrid.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpDataGrid.ToolTipTitle = "OBSERVAÇÃO: ";
            // 
            // TelaAlteraReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TelaAlteraReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receita - Alteração";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaAlteraReceita_FormClosing);
            this.Load += new System.EventHandler(this.TelaAlteraReceita_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecaoIngrediente)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorReceita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRendimentoReceita;
        private System.Windows.Forms.TextBox txtNomeReceita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnConfirmaAlteracao;
        private System.Windows.Forms.ToolStripMenuItem btnCancelaAlteracao;
        private System.Windows.Forms.DataGridView dataGridSelecaoIngrediente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCategoriaReceita;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTxtModoPreparo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTempoPreparo;
        private System.Windows.Forms.ComboBox cmbDificuldadeAlteraReceita;
        private System.Windows.Forms.Button CadastarIngredientesReceita;
        private System.Windows.Forms.ToolTip ttpTempo;
        private System.Windows.Forms.ToolTip ttpDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdIngrediente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnSelecaoIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNomeIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnValorIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantidadeIngrediente;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnUnidadeIngrediente;
    }
}