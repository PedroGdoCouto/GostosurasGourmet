using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGourmet
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.White; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.White; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.White; }
            }
            public override Color MenuItemBorder
            {
                get { return Color.OrangeRed; }
            }
        }

        private void BtnMenuIngrediente_Click_1(object sender, EventArgs e)
        {
            TelaIngrediente telaIngrediente = new TelaIngrediente() { telaInicio = this }; // Formulário "public" recebe a tela desta classe
            telaIngrediente.Show(); // Exibe a tela de ingredientes com o clique do usuário
            this.Hide(); // Esconde a tela inicial do programa
        }

        private void BtnMenuReceita_Click_1(object sender, EventArgs e)
        {
            TelaReceita telaReceita = new TelaReceita() { telaInicio = this }; // Formulário "public" recebe a tela desta classe
            telaReceita.Show(); // Exibe a tela de receitas com o clique do usuário
            this.Hide(); // Esconde a tela inicial do programa
        }

        private void BtnEncerraPrograma_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Confirma se o usuário realmente deseja sair do sistema
            DialogResult sair = MessageBox.Show("Deseja realmente sair do programa?", "Sair do programa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (sair.ToString().ToUpper() == "YES")
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}