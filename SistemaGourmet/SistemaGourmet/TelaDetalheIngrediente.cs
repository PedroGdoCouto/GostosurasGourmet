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
    public partial class TelaDetalheIngrediente : Form
    {
        //Trazer o id do ingrediente para nova tela.
        public int idIngredienteDetalhe;
        public Form telaInicialDetalhe;


        public TelaDetalheIngrediente()
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

        private void BtnAlteraIngrediente_Click_1(object sender, EventArgs e)
        {
            //Resgatando o objeto
            Ingrediente ingrediente = new Ingrediente();
            ingrediente.Id = idIngredienteDetalhe;

            //Atribuindo novos valores.
            ingrediente.Nome = txtNomeIngrediente.Text;
            ingrediente.Preco = double.Parse(txtValorIngrediente.Text);
            ingrediente.Quantidade = double.Parse(txtQuantidadeIngrediente.Text);
            ingrediente.UnidadeMedidaPreco = cboUnidadeIngrediente.SelectedItem.ToString();

            if ((!txtNomeIngrediente.Text.Equals("")) &&
                (!txtValorIngrediente.Text.Equals("")) &&
                (!txtQuantidadeIngrediente.Text.Equals("")) &&
                (!cboUnidadeIngrediente.SelectedItem.ToString().Equals(""))
                )
            {
                if (ingrediente.Alterar())
                {
                    MessageBox.Show("Alteração realizada com sucesso", "Alteração realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    TelaIngrediente telaIngrediente = new TelaIngrediente() { telaInicio = telaInicialDetalhe };
                    telaIngrediente.Show();
                    telaInicialDetalhe.Hide();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar os dados", "Erro na alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Erro na alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
        }

        private void BtnDeletaIngrediente_Click(object sender, EventArgs e)
        {
            // Confirma se o usuário realmente deseja sair do sistema
            DialogResult apagar = MessageBox.Show("Deseja realmente excluir esse ingrediente do banco de dados?", "Excluir ingrediente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (apagar.ToString().ToUpper() == "YES")
            {
                //Resgatando o objeto
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.Id = idIngredienteDetalhe;
                if (ingrediente.Apagar())
                {
                    MessageBox.Show("Exclusão do ingrediente foi bem sucedida", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

                    //Voltando para tela de ingredientes.
                    TelaIngrediente telaIngrediente = new TelaIngrediente() { telaInicio = telaInicialDetalhe };
                    telaIngrediente.Show();
                    telaInicialDetalhe.Hide();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o ingrediente", "Erro na exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                }
            }
        }

        private void BtnVoltaIngrediente_Click(object sender, EventArgs e)
        {
            TelaIngrediente telaIngrediente = new TelaIngrediente() { telaInicio=telaInicialDetalhe};
            telaIngrediente.Show();
            telaInicialDetalhe.Hide();
            this.Hide();
        }

        private void TelaDetalheIngrediente_Load(object sender, EventArgs e)
        {
            try
            {
                //Preenchendo o combobox
                cboUnidadeIngrediente.DataSource = new string[] {
                            "g",
                            "kg",
                            "ml",
                            "l",
                            "un"
                };
                //Resgatando o objeto
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.Id = idIngredienteDetalhe;

                if (ingrediente.ObterIngrediente())
                {
                    txtNomeIngrediente.Text = ingrediente.Nome;
                    txtValorIngrediente.Text = ingrediente.Preco.ToString();
                    txtQuantidadeIngrediente.Text = ingrediente.Quantidade.ToString();
                    cboUnidadeIngrediente.SelectedItem = ingrediente.UnidadeMedidaPreco;
                }
                else
                {
                    MessageBox.Show("Não foi possível carregar todos os dados do ingrediente", "Erro no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível carregar todos os dados do ingrediente\n" + ex.Message, "Erro no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
        }

        private void TelaDetalheIngrediente_FormClosing(object sender, FormClosingEventArgs e)
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
