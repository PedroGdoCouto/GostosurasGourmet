namespace SistemaGourmet
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnComecar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuIngrediente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuReceita = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEncerraPrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnComecar,
            this.btnEncerraPrograma});
            this.menuStrip1.Location = new System.Drawing.Point(0, 473);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 84);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnComecar
            // 
            this.btnComecar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnComecar.AutoSize = false;
            this.btnComecar.BackColor = System.Drawing.Color.White;
            this.btnComecar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuIngrediente,
            this.btnMenuReceita});
            this.btnComecar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComecar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnComecar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Padding = new System.Windows.Forms.Padding(10, 22, 10, 22);
            this.btnComecar.Size = new System.Drawing.Size(122, 80);
            this.btnComecar.Text = "Começar";
            // 
            // btnMenuIngrediente
            // 
            this.btnMenuIngrediente.BackColor = System.Drawing.Color.White;
            this.btnMenuIngrediente.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuIngrediente.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnMenuIngrediente.Name = "btnMenuIngrediente";
            this.btnMenuIngrediente.Size = new System.Drawing.Size(246, 26);
            this.btnMenuIngrediente.Text = "Menu de Ingredientes";
            this.btnMenuIngrediente.Click += new System.EventHandler(this.BtnMenuIngrediente_Click_1);
            // 
            // btnMenuReceita
            // 
            this.btnMenuReceita.BackColor = System.Drawing.Color.White;
            this.btnMenuReceita.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuReceita.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnMenuReceita.Name = "btnMenuReceita";
            this.btnMenuReceita.Size = new System.Drawing.Size(246, 26);
            this.btnMenuReceita.Text = "Menu de Receitas";
            this.btnMenuReceita.Click += new System.EventHandler(this.BtnMenuReceita_Click_1);
            // 
            // btnEncerraPrograma
            // 
            this.btnEncerraPrograma.AutoSize = false;
            this.btnEncerraPrograma.BackColor = System.Drawing.Color.White;
            this.btnEncerraPrograma.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerraPrograma.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnEncerraPrograma.Name = "btnEncerraPrograma";
            this.btnEncerraPrograma.Size = new System.Drawing.Size(122, 80);
            this.btnEncerraPrograma.Text = "Sair";
            this.btnEncerraPrograma.Click += new System.EventHandler(this.BtnEncerraPrograma_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sistema de Gerenciamento Simples";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 360);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gostosuras Gourmet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 557);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início - Bem-vindo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaInicial_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnComecar;
        private System.Windows.Forms.ToolStripMenuItem btnMenuIngrediente;
        private System.Windows.Forms.ToolStripMenuItem btnMenuReceita;
        private System.Windows.Forms.ToolStripMenuItem btnEncerraPrograma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

