using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaGourmet
{
    public partial class TelaAlteraReceita : Form
    {
        public Form telaInicioAltera; //Para proteger o objeto telaInical
        public int idReceitaAltera;

        public TelaAlteraReceita()
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

        private void BtnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alteração realizada com sucesso", "Alteração realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }

        private void BtnCancelaAlteracao_Click(object sender, EventArgs e)
        {
            TelaReceita telaReceita = new TelaReceita() { telaInicio=telaInicioAltera};
            telaReceita.Show();
            telaInicioAltera.Hide();
            this.Hide();
        }

        private void TelaAlteraReceita_Load(object sender, EventArgs e)
        {
            try
            {
                //Preenchendo o combobox
                cmbCategoriaReceita.DataSource = new string[] {
                            "Bebida",
                            "Carne",
                            "Confeitaria",
                            "Marisco",
                            "Padaria",
                            "Pastelaria",
                            "Peixe",
                            "Salada",
                            "Sobremesa"
                };

                cmbDificuldadeAlteraReceita.DataSource = new string[] {
                            "1",
                            "2",
                            "3",
                            "4",
                            "5",
                            "6",
                            "7",
                            "8",
                            "9",
                            "10"
                };

                //Criando o objetos que guardará as incormações no banco de dados.
                Receita receita = new Receita();
                Ingrediente ingrediente = new Ingrediente();

                //objetos para acionar busca
                receita.Id = idReceitaAltera;               

                if (receita.ObterReceita())
                {
                    //Atribuindo novos valores.
                    txtNomeReceita.Text = receita.Nome.ToString();
                    txtRendimentoReceita.Text = receita.Porcoes.ToString();
                    txtValorReceita.Text = receita.Custo.ToString();
                    txtTempoPreparo.Text = receita.TempoPreparacao.ToString();
                    cmbCategoriaReceita.SelectedItem = receita.Categoria;
                    cmbDificuldadeAlteraReceita.SelectedItem = receita.Dificuldade.ToString();
                    richTxtModoPreparo.Text = receita.Preparo;

                    //Carregando dataGrid com a lista de ingredientes relacionados a receita.
                    MySqlDataReader reader = ingrediente.Listar();

                    if (reader != null && (reader.HasRows))
                    {
                        double valorTotal = 0;

                        while (reader.Read())
                        {
                            int n = dataGridSelecaoIngrediente.Rows.Add();

                            dataGridSelecaoIngrediente.Rows[n].Cells["columnIdIngrediente"].Value = reader["id"];
                            dataGridSelecaoIngrediente.Rows[n].Cells["columnNomeIngrediente"].Value = reader["nome"];
                            dataGridSelecaoIngrediente.Rows[n].Cells["columnValorIngrediente"].Value = reader["preco"];
                            dataGridSelecaoIngrediente.Rows[n].Cells["columnQuantidadeIngrediente"].Value = reader["quantidade"];
                            dataGridSelecaoIngrediente.Rows[n].Cells["columnUnidadeIngrediente"].Value = reader["unidade"];
                            if (true)
                            {
                                //Calculando custo da receita.
                                valorTotal += Convert.ToDouble(dataGridSelecaoIngrediente.Rows[n].Cells["columnValorIngrediente"].Value);
                            }
                            
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Não foi possível carregar todos os dados da receita", "Erro no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
        }

        private void CadastarIngredientesReceita_Click(object sender, EventArgs e)
        {
            Receita receita = new Receita();
            receita.Id = idReceitaAltera;
        }

        private void TelaAlteraReceita_FormClosing(object sender, FormClosingEventArgs e)
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
