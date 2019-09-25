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
    public partial class TelaRegistroIngrediente : Form
    {
        public Form telaInicialRegistro;

        public TelaRegistroIngrediente()
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

        private void BtnConfirmaRegistro_Click(object sender, EventArgs e)
        {
            //Resgatando o objeto
            Ingrediente ingrediente = new Ingrediente();             

            if ((!txtNomeIngrediente.Text.Equals("")) &&
                (!txtValorIngrediente.Text.Equals("")) &&
                (!txtQuantidadeIngrediente.Text.Equals("")) &&
                (!cboUnidadeRegistroIngrediente.SelectedItem.ToString().Equals(""))
                )
            {
                //Atribuindo novos valores.
                ingrediente.Nome = txtNomeIngrediente.Text;
                ingrediente.Preco = double.Parse(txtValorIngrediente.Text);
                ingrediente.Quantidade = double.Parse(txtQuantidadeIngrediente.Text);
                ingrediente.UnidadeMedidaPreco = cboUnidadeRegistroIngrediente.SelectedItem.ToString();

                if (ingrediente.Cadastrar())
                {
                    MessageBox.Show("Registro realizado com sucesso", "Registro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar o novo ingrediente", "Erro no registro", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Erro no registro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            }
            TelaIngrediente telaIngrediente = new TelaIngrediente() { telaInicio=telaInicialRegistro};
            telaIngrediente.Show();
            telaInicialRegistro.Hide();
            this.Hide();
        }

        private void BtnCancelaRegistro_Click(object sender, EventArgs e)
        {
            TelaIngrediente telaIngrediente = new TelaIngrediente() { telaInicio = telaInicialRegistro };
            telaIngrediente.Show();
            telaInicialRegistro.Hide();
            this.Hide();
        }

        private void TelaRegistroIngrediente_Load(object sender, EventArgs e)
        {
            //Preenchendo o combobox
            cboUnidadeRegistroIngrediente.DataSource = new string[] {
                            "g",
                            "kg",
                            "ml",
                            "l",
                            "un"
                };
        }

        private void TelaRegistroIngrediente_FormClosing(object sender, FormClosingEventArgs e)
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
