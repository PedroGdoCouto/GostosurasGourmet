namespace SistemaGourmet
{
    partial class TelaDetalheIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDetalheIngrediente));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboUnidadeIngrediente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorIngrediente = new System.Windows.Forms.TextBox();
            this.txtNomeIngrediente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidadeIngrediente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlteraIngrediente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeletaIngrediente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVoltaIngrediente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.label1.Text = "Ingredientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboUnidadeIngrediente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtValorIngrediente);
            this.groupBox1.Controls.Add(this.txtNomeIngrediente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQuantidadeIngrediente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 86);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // cboUnidadeIngrediente
            // 
            this.cboUnidadeIngrediente.AllowDrop = true;
            this.cboUnidadeIngrediente.BackColor = System.Drawing.Color.White;
            this.cboUnidadeIngrediente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadeIngrediente.FormattingEnabled = true;
            this.cboUnidadeIngrediente.Location = new System.Drawing.Point(507, 55);
            this.cboUnidadeIngrediente.Name = "cboUnidadeIngrediente";
            this.cboUnidadeIngrediente.Size = new System.Drawing.Size(43, 25);
            this.cboUnidadeIngrediente.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Valor";
            // 
            // txtValorIngrediente
            // 
            this.txtValorIngrediente.BackColor = System.Drawing.Color.White;
            this.txtValorIngrediente.Location = new System.Drawing.Point(300, 52);
            this.txtValorIngrediente.Name = "txtValorIngrediente";
            this.txtValorIngrediente.Size = new System.Drawing.Size(120, 28);
            this.txtValorIngrediente.TabIndex = 36;
            this.txtValorIngrediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeIngrediente
            // 
            this.txtNomeIngrediente.BackColor = System.Drawing.Color.White;
            this.txtNomeIngrediente.Location = new System.Drawing.Point(6, 52);
            this.txtNomeIngrediente.Name = "txtNomeIngrediente";
            this.txtNomeIngrediente.Size = new System.Drawing.Size(250, 28);
            this.txtNomeIngrediente.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Quantidade";
            // 
            // txtQuantidadeIngrediente
            // 
            this.txtQuantidadeIngrediente.BackColor = System.Drawing.Color.White;
            this.txtQuantidadeIngrediente.Location = new System.Drawing.Point(426, 52);
            this.txtQuantidadeIngrediente.Name = "txtQuantidadeIngrediente";
            this.txtQuantidadeIngrediente.Size = new System.Drawing.Size(75, 28);
            this.txtQuantidadeIngrediente.TabIndex = 34;
            this.txtQuantidadeIngrediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome do ingrediente";
            // 
            // btnAlteraIngrediente
            // 
            this.btnAlteraIngrediente.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAlteraIngrediente.AutoSize = false;
            this.btnAlteraIngrediente.BackColor = System.Drawing.Color.White;
            this.btnAlteraIngrediente.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlteraIngrediente.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAlteraIngrediente.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAlteraIngrediente.Name = "btnAlteraIngrediente";
            this.btnAlteraIngrediente.Size = new System.Drawing.Size(123, 80);
            this.btnAlteraIngrediente.Text = "Alterar";
            this.btnAlteraIngrediente.Click += new System.EventHandler(this.BtnAlteraIngrediente_Click_1);
            // 
            // btnDeletaIngrediente
            // 
            this.btnDeletaIngrediente.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDeletaIngrediente.AutoSize = false;
            this.btnDeletaIngrediente.BackColor = System.Drawing.Color.White;
            this.btnDeletaIngrediente.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletaIngrediente.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnDeletaIngrediente.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnDeletaIngrediente.Name = "btnDeletaIngrediente";
            this.btnDeletaIngrediente.Size = new System.Drawing.Size(122, 80);
            this.btnDeletaIngrediente.Text = "Excluir";
            this.btnDeletaIngrediente.Click += new System.EventHandler(this.BtnDeletaIngrediente_Click);
            // 
            // btnVoltaIngrediente
            // 
            this.btnVoltaIngrediente.AutoSize = false;
            this.btnVoltaIngrediente.BackColor = System.Drawing.Color.White;
            this.btnVoltaIngrediente.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltaIngrediente.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnVoltaIngrediente.Name = "btnVoltaIngrediente";
            this.btnVoltaIngrediente.Size = new System.Drawing.Size(122, 80);
            this.btnVoltaIngrediente.Text = "Voltar";
            this.btnVoltaIngrediente.Click += new System.EventHandler(this.BtnVoltaIngrediente_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAlteraIngrediente,
            this.btnDeletaIngrediente,
            this.btnVoltaIngrediente});
            this.menuStrip1.Location = new System.Drawing.Point(0, 473);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 84);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TelaDetalheIngrediente
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
            this.Name = "TelaDetalheIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrediente - Detalhamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaDetalheIngrediente_FormClosing);
            this.Load += new System.EventHandler(this.TelaDetalheIngrediente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboUnidadeIngrediente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorIngrediente;
        private System.Windows.Forms.TextBox txtNomeIngrediente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidadeIngrediente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem btnAlteraIngrediente;
        private System.Windows.Forms.ToolStripMenuItem btnDeletaIngrediente;
        private System.Windows.Forms.ToolStripMenuItem btnVoltaIngrediente;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}