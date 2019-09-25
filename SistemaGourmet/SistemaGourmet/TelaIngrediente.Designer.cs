namespace SistemaGourmet
{
    partial class TelaIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaIngrediente));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnIngredienteVoltaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIngredienteRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridIngrediente = new System.Windows.Forms.DataGridView();
            this.txtColumnIdIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnNomeIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnValorIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnQuantidadeIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColumnUnidadeIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIngrediente)).BeginInit();
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
            this.label1.TabIndex = 30;
            this.label1.Text = "Ingredientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnIngredienteVoltaMenu,
            this.btnIngredienteRegistrar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 473);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 84);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnIngredienteVoltaMenu
            // 
            this.BtnIngredienteVoltaMenu.AutoSize = false;
            this.BtnIngredienteVoltaMenu.BackColor = System.Drawing.Color.White;
            this.BtnIngredienteVoltaMenu.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngredienteVoltaMenu.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnIngredienteVoltaMenu.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnIngredienteVoltaMenu.Name = "BtnIngredienteVoltaMenu";
            this.BtnIngredienteVoltaMenu.ShowShortcutKeys = false;
            this.BtnIngredienteVoltaMenu.Size = new System.Drawing.Size(122, 80);
            this.BtnIngredienteVoltaMenu.Text = "Menu";
            this.BtnIngredienteVoltaMenu.Click += new System.EventHandler(this.BtnIngredienteVoltaMenu_Click_1);
            // 
            // btnIngredienteRegistrar
            // 
            this.btnIngredienteRegistrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnIngredienteRegistrar.AutoSize = false;
            this.btnIngredienteRegistrar.BackColor = System.Drawing.Color.White;
            this.btnIngredienteRegistrar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredienteRegistrar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnIngredienteRegistrar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnIngredienteRegistrar.Name = "btnIngredienteRegistrar";
            this.btnIngredienteRegistrar.ShowShortcutKeys = false;
            this.btnIngredienteRegistrar.Size = new System.Drawing.Size(122, 80);
            this.btnIngredienteRegistrar.Text = "Registrar";
            this.btnIngredienteRegistrar.Click += new System.EventHandler(this.btnIngredienteRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecione um ingrediente";
            // 
            // dataGridIngrediente
            // 
            this.dataGridIngrediente.AllowUserToAddRows = false;
            this.dataGridIngrediente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridIngrediente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridIngrediente.BackgroundColor = System.Drawing.Color.White;
            this.dataGridIngrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIngrediente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtColumnIdIngrediente,
            this.txtColumnNomeIngrediente,
            this.txtColumnValorIngrediente,
            this.txtColumnQuantidadeIngrediente,
            this.txtColumnUnidadeIngrediente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridIngrediente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridIngrediente.GridColor = System.Drawing.Color.White;
            this.dataGridIngrediente.Location = new System.Drawing.Point(6, 52);
            this.dataGridIngrediente.Name = "dataGridIngrediente";
            this.dataGridIngrediente.ReadOnly = true;
            this.dataGridIngrediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridIngrediente.Size = new System.Drawing.Size(544, 291);
            this.dataGridIngrediente.TabIndex = 2;
            this.dataGridIngrediente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridIngrediente_CellContentClick);
            // 
            // txtColumnIdIngrediente
            // 
            this.txtColumnIdIngrediente.HeaderText = "ID";
            this.txtColumnIdIngrediente.Name = "txtColumnIdIngrediente";
            this.txtColumnIdIngrediente.ReadOnly = true;
            this.txtColumnIdIngrediente.Visible = false;
            // 
            // txtColumnNomeIngrediente
            // 
            this.txtColumnNomeIngrediente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtColumnNomeIngrediente.HeaderText = "Nome do ingrediente";
            this.txtColumnNomeIngrediente.Name = "txtColumnNomeIngrediente";
            this.txtColumnNomeIngrediente.ReadOnly = true;
            // 
            // txtColumnValorIngrediente
            // 
            this.txtColumnValorIngrediente.HeaderText = "Valor";
            this.txtColumnValorIngrediente.Name = "txtColumnValorIngrediente";
            this.txtColumnValorIngrediente.ReadOnly = true;
            // 
            // txtColumnQuantidadeIngrediente
            // 
            this.txtColumnQuantidadeIngrediente.HeaderText = "Quant";
            this.txtColumnQuantidadeIngrediente.Name = "txtColumnQuantidadeIngrediente";
            this.txtColumnQuantidadeIngrediente.ReadOnly = true;
            this.txtColumnQuantidadeIngrediente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtColumnQuantidadeIngrediente.Width = 70;
            // 
            // txtColumnUnidadeIngrediente
            // 
            this.txtColumnUnidadeIngrediente.HeaderText = "un";
            this.txtColumnUnidadeIngrediente.Name = "txtColumnUnidadeIngrediente";
            this.txtColumnUnidadeIngrediente.ReadOnly = true;
            this.txtColumnUnidadeIngrediente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtColumnUnidadeIngrediente.Width = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridIngrediente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 349);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // TelaIngrediente
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
            this.Name = "TelaIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrediente - Pesquisa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaIngrediente_FormClosing);
            this.Load += new System.EventHandler(this.TelaIngrediente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIngrediente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnIngredienteRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridIngrediente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem BtnIngredienteVoltaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnIdIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnNomeIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnValorIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnQuantidadeIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtColumnUnidadeIngrediente;
    }
}