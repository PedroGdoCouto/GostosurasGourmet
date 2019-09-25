namespace SistemaGourmet
{
    partial class TelaDetalheReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDetalheReceita));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAlteraReceita = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVoltaReceita = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeletaReceita = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeReceita = new System.Windows.Forms.TextBox();
            this.txtRendimentoReceita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorReceita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTxtModoPreparo = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridSelecaoIngrediente = new System.Windows.Forms.DataGridView();
            this.columnUnidadeIngrediente = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnQuantidadeIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnValorIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNomeIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSelecaoIngrediente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnIdIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCategoriaReceita = new System.Windows.Forms.ComboBox();
            this.txtTempoPreparo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDificuldadeReceita = new System.Windows.Forms.ComboBox();
            this.dataGridSelecionados = new System.Windows.Forms.DataGridView();
            this.columnUnidadeIngredienteSelecionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantidadeIngredienteSelecionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnValorIngredienteSelecionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNomeIngredienteSelecionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdIngredienteSelecionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecaoIngrediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecionados)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.label1.TabIndex = 34;
            this.label1.Text = "Receitas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAlteraReceita,
            this.btnVoltaReceita,
            this.btnDeletaReceita});
            this.menuStrip1.Location = new System.Drawing.Point(0, 608);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 84);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAlteraReceita
            // 
            this.btnAlteraReceita.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAlteraReceita.AutoSize = false;
            this.btnAlteraReceita.BackColor = System.Drawing.Color.White;
            this.btnAlteraReceita.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlteraReceita.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAlteraReceita.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAlteraReceita.Name = "btnAlteraReceita";
            this.btnAlteraReceita.Size = new System.Drawing.Size(123, 80);
            this.btnAlteraReceita.Text = "Alterar";
            this.btnAlteraReceita.Click += new System.EventHandler(this.BtnAlteraReceita_Click);
            // 
            // btnVoltaReceita
            // 
            this.btnVoltaReceita.AutoSize = false;
            this.btnVoltaReceita.BackColor = System.Drawing.Color.White;
            this.btnVoltaReceita.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltaReceita.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnVoltaReceita.Name = "btnVoltaReceita";
            this.btnVoltaReceita.Size = new System.Drawing.Size(122, 80);
            this.btnVoltaReceita.Text = "Voltar";
            this.btnVoltaReceita.Click += new System.EventHandler(this.btnVoltaReceita_Click);
            // 
            // btnDeletaReceita
            // 
            this.btnDeletaReceita.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDeletaReceita.AutoSize = false;
            this.btnDeletaReceita.BackColor = System.Drawing.Color.White;
            this.btnDeletaReceita.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletaReceita.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnDeletaReceita.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnDeletaReceita.Name = "btnDeletaReceita";
            this.btnDeletaReceita.Size = new System.Drawing.Size(122, 80);
            this.btnDeletaReceita.Text = "Excluir";
            this.btnDeletaReceita.Click += new System.EventHandler(this.btnDeletaReceita_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 25);
            this.label6.TabIndex = 63;
            this.label6.Text = "Lista de ingredientes desta receita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome da receita";
            // 
            // txtNomeReceita
            // 
            this.txtNomeReceita.BackColor = System.Drawing.Color.White;
            this.txtNomeReceita.Location = new System.Drawing.Point(6, 52);
            this.txtNomeReceita.Name = "txtNomeReceita";
            this.txtNomeReceita.Size = new System.Drawing.Size(250, 28);
            this.txtNomeReceita.TabIndex = 33;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Rendimento";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Dificuldade";
            // 
            // richTxtModoPreparo
            // 
            this.richTxtModoPreparo.BackColor = System.Drawing.Color.White;
            this.richTxtModoPreparo.Location = new System.Drawing.Point(300, 52);
            this.richTxtModoPreparo.Name = "richTxtModoPreparo";
            this.richTxtModoPreparo.Size = new System.Drawing.Size(250, 146);
            this.richTxtModoPreparo.TabIndex = 41;
            this.richTxtModoPreparo.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(295, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Modo de preparo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 25);
            this.label9.TabIndex = 52;
            this.label9.Text = "Lista geral de ingredientes";
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
            this.dataGridSelecaoIngrediente.Location = new System.Drawing.Point(6, 229);
            this.dataGridSelecaoIngrediente.Name = "dataGridSelecaoIngrediente";
            this.dataGridSelecaoIngrediente.Size = new System.Drawing.Size(544, 125);
            this.dataGridSelecaoIngrediente.TabIndex = 53;
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
            this.columnUnidadeIngrediente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnUnidadeIngrediente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnUnidadeIngrediente.Width = 45;
            // 
            // columnQuantidadeIngrediente
            // 
            this.columnQuantidadeIngrediente.HeaderText = "Quant";
            this.columnQuantidadeIngrediente.Name = "columnQuantidadeIngrediente";
            this.columnQuantidadeIngrediente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnQuantidadeIngrediente.Width = 70;
            // 
            // columnValorIngrediente
            // 
            this.columnValorIngrediente.HeaderText = "Valor";
            this.columnValorIngrediente.Name = "columnValorIngrediente";
            // 
            // columnNomeIngrediente
            // 
            this.columnNomeIngrediente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNomeIngrediente.HeaderText = "Nome do ingrediente";
            this.columnNomeIngrediente.Name = "columnNomeIngrediente";
            // 
            // columnSelecaoIngrediente
            // 
            this.columnSelecaoIngrediente.HeaderText = "-";
            this.columnSelecaoIngrediente.Name = "columnSelecaoIngrediente";
            this.columnSelecaoIngrediente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnSelecaoIngrediente.Width = 20;
            // 
            // columnIdIngrediente
            // 
            this.columnIdIngrediente.HeaderText = "ID";
            this.columnIdIngrediente.Name = "columnIdIngrediente";
            this.columnIdIngrediente.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(133, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 58;
            this.label10.Text = "Categoria";
            // 
            // cmbCategoriaReceita
            // 
            this.cmbCategoriaReceita.BackColor = System.Drawing.Color.White;
            this.cmbCategoriaReceita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaReceita.FormattingEnabled = true;
            this.cmbCategoriaReceita.Location = new System.Drawing.Point(138, 114);
            this.cmbCategoriaReceita.Name = "cmbCategoriaReceita";
            this.cmbCategoriaReceita.Size = new System.Drawing.Size(118, 25);
            this.cmbCategoriaReceita.TabIndex = 59;
            // 
            // txtTempoPreparo
            // 
            this.txtTempoPreparo.BackColor = System.Drawing.Color.White;
            this.txtTempoPreparo.Location = new System.Drawing.Point(72, 170);
            this.txtTempoPreparo.Name = "txtTempoPreparo";
            this.txtTempoPreparo.Size = new System.Drawing.Size(60, 28);
            this.txtTempoPreparo.TabIndex = 60;
            this.txtTempoPreparo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(67, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 61;
            this.label11.Text = "Tempo";
            // 
            // cmbDificuldadeReceita
            // 
            this.cmbDificuldadeReceita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDificuldadeReceita.FormattingEnabled = true;
            this.cmbDificuldadeReceita.Location = new System.Drawing.Point(138, 173);
            this.cmbDificuldadeReceita.Name = "cmbDificuldadeReceita";
            this.cmbDificuldadeReceita.Size = new System.Drawing.Size(118, 25);
            this.cmbDificuldadeReceita.TabIndex = 62;
            // 
            // dataGridSelecionados
            // 
            this.dataGridSelecionados.AllowUserToAddRows = false;
            this.dataGridSelecionados.AllowUserToDeleteRows = false;
            this.dataGridSelecionados.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSelecionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdIngredienteSelecionado,
            this.columnNomeIngredienteSelecionado,
            this.columnValorIngredienteSelecionado,
            this.columnQuantidadeIngredienteSelecionado,
            this.columnUnidadeIngredienteSelecionado});
            this.dataGridSelecionados.Location = new System.Drawing.Point(6, 394);
            this.dataGridSelecionados.Name = "dataGridSelecionados";
            this.dataGridSelecionados.ReadOnly = true;
            this.dataGridSelecionados.Size = new System.Drawing.Size(544, 125);
            this.dataGridSelecionados.TabIndex = 64;
            // 
            // columnUnidadeIngredienteSelecionado
            // 
            this.columnUnidadeIngredienteSelecionado.HeaderText = "Un";
            this.columnUnidadeIngredienteSelecionado.Name = "columnUnidadeIngredienteSelecionado";
            this.columnUnidadeIngredienteSelecionado.ReadOnly = true;
            this.columnUnidadeIngredienteSelecionado.Width = 45;
            // 
            // columnQuantidadeIngredienteSelecionado
            // 
            this.columnQuantidadeIngredienteSelecionado.HeaderText = "Quant";
            this.columnQuantidadeIngredienteSelecionado.Name = "columnQuantidadeIngredienteSelecionado";
            this.columnQuantidadeIngredienteSelecionado.ReadOnly = true;
            this.columnQuantidadeIngredienteSelecionado.Width = 90;
            // 
            // columnValorIngredienteSelecionado
            // 
            this.columnValorIngredienteSelecionado.HeaderText = "Valor";
            this.columnValorIngredienteSelecionado.Name = "columnValorIngredienteSelecionado";
            this.columnValorIngredienteSelecionado.ReadOnly = true;
            // 
            // columnNomeIngredienteSelecionado
            // 
            this.columnNomeIngredienteSelecionado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnNomeIngredienteSelecionado.HeaderText = "Nome";
            this.columnNomeIngredienteSelecionado.Name = "columnNomeIngredienteSelecionado";
            this.columnNomeIngredienteSelecionado.ReadOnly = true;
            this.columnNomeIngredienteSelecionado.Width = 266;
            // 
            // columnIdIngredienteSelecionado
            // 
            this.columnIdIngredienteSelecionado.HeaderText = "Id";
            this.columnIdIngredienteSelecionado.Name = "columnIdIngredienteSelecionado";
            this.columnIdIngredienteSelecionado.ReadOnly = true;
            this.columnIdIngredienteSelecionado.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridSelecionados);
            this.groupBox1.Controls.Add(this.cmbDificuldadeReceita);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTempoPreparo);
            this.groupBox1.Controls.Add(this.cmbCategoriaReceita);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dataGridSelecaoIngrediente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.richTxtModoPreparo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtValorReceita);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRendimentoReceita);
            this.groupBox1.Controls.Add(this.txtNomeReceita);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 525);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // TelaDetalheReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 692);
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
            this.Name = "TelaDetalheReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receita - Detalhamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaDetalheReceita_FormClosing);
            this.Load += new System.EventHandler(this.TelaDetalheReceita_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecaoIngrediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecionados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAlteraReceita;
        private System.Windows.Forms.ToolStripMenuItem btnVoltaReceita;
        private System.Windows.Forms.ToolStripMenuItem btnDeletaReceita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeReceita;
        private System.Windows.Forms.TextBox txtRendimentoReceita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorReceita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTxtModoPreparo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridSelecaoIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdIngrediente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnSelecaoIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNomeIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnValorIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantidadeIngrediente;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnUnidadeIngrediente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCategoriaReceita;
        private System.Windows.Forms.TextBox txtTempoPreparo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDificuldadeReceita;
        private System.Windows.Forms.DataGridView dataGridSelecionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdIngredienteSelecionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNomeIngredienteSelecionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnValorIngredienteSelecionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantidadeIngredienteSelecionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUnidadeIngredienteSelecionado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}