using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemaGourmet
{
    public partial class TelaRegistroReceita : Form
    {
        //Atributos
        public Form telaInicioRegistro;//Para preservar o objeto telaInicial

        public TelaRegistroReceita()
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
            
            try
            {
                

                if ((!txtNomeReceita.Text.Equals(""))  //nenhum valor pode ficar em branco.
                 && (!cmbDificuldadeRegistroReceita.SelectedItem.Equals("")) 
                 && (!txtTempoPreparo.Text.Equals("")) 
                 && (!txtRendimentoReceita.Text.Equals("")) 
                 && (!richTxtModoPreparo.Text.Equals("")) 
                 && (!cmbCategoriaReceita.SelectedItem.ToString().Equals(""))
                    )
                {
                    //Criando o objeto
                    Receita receita = new Receita();
                    //receita.Ingrediente = new Ingrediente();
                    //Atribuindo novos valores.
                    receita.Nome = Convert.ToString(txtNomeReceita.Text);
                    receita.Porcoes = double.Parse(txtRendimentoReceita.Text.ToString());
                    receita.TempoPreparacao = int.Parse(txtTempoPreparo.Text.ToString());
                    receita.Categoria = Convert.ToString(cmbCategoriaReceita.SelectedItem);
                    receita.Dificuldade = int.Parse(cmbDificuldadeRegistroReceita.SelectedItem.ToString());
                    receita.Preparo = Convert.ToString(richTxtModoPreparo.Text);

                    double valorTotal = 0;

                    if (receita.Cadastrar())
                    {

                        foreach (DataGridViewRow row in dataGridSelecaoIngrediente.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells["columnSelecaoIngrediente"].Value) == true
                                && receita.ObterReceita()
                                )
                            {
                                //Atribuindo os valores para o objeto receita.ingrediente
                                receita.Ingrediente.Id = int.Parse(row.Cells["columnIdIngrediente"].Value.ToString());                                
                                receita.Ingrediente.Quantidade = double.Parse(row.Cells["columnQuantidadeIngrediente"].Value.ToString());
                                receita.Ingrediente.UnidadeMedidaPreco = row.Cells["columnUnidadeIngrediente"].Value.ToString();
                                receita.Ingrediente.Preco = double.Parse(row.Cells["columnValorIngrediente"].Value.ToString());

                                receita.CadastrarIngrediente();
                                valorTotal += receita.Ingrediente.Preco;

                            }                            
                        }
                        //Cadastrando o custo total da receita.
                        //MessageBox.Show("ID do item cadastrado: "+receita.Id.ToString());//Tentando rastrear onde o codigo está falhando.
                        receita.Custo = valorTotal;
                        receita.AlterarCusto();

                        MessageBox.Show("Cadastro de receita bem sucedido.");
                        TelaReceita telaReceita = new TelaReceita() { telaInicio = telaInicioRegistro };
                        telaReceita.Show();
                        telaInicioRegistro.Hide();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar a nova receita", "Erro no registro", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos", "Erro no registro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível cadastrar a nova receita\n" + ex.Message, "Erro no registro", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }
        }

        private void BtnCancelaRegistro_Click(object sender, EventArgs e)
        {
            TelaReceita telaReceita = new TelaReceita() { telaInicio = telaInicioRegistro };
            telaReceita.Show();
            telaInicioRegistro.Hide();
            this.Hide();
        }

        private void TelaRegistroReceita_Load(object sender, EventArgs e)
        {
            try
            {
                //Preenchendo os comboboxes
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
                cmbDificuldadeRegistroReceita.DataSource = new string[] {
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

                //Gerando os objetos necesários para as operações
                //Receita receita = new Receita();
                Ingrediente listaIngrediente = new Ingrediente();

                //objetos para acionar busca
                //receita.Id = idReceitaAltera;
                //ingrediente.Id = 1;


                MySqlDataReader reader = listaIngrediente.Listar();


                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dataGridSelecaoIngrediente.Rows.Add();

                        dataGridSelecaoIngrediente.Rows[n].Cells["columnIdIngrediente"].Value = reader["id"];
                        dataGridSelecaoIngrediente.Rows[n].Cells["columnNomeIngrediente"].Value = reader["nome"];
                        dataGridSelecaoIngrediente.Rows[n].Cells["columnValorIngrediente"].Value = reader["preco"];
                        dataGridSelecaoIngrediente.Rows[n].Cells["columnQuantidadeIngrediente"].Value = reader["quantidade"];
                        dataGridSelecaoIngrediente.Rows[n].Cells["columnUnidadeIngrediente"].Value = reader["unidade"];
                    }

                    //Ordenando lista pelo nome dos ingredientes.
                    DataGridViewColumn columnToSort = dataGridSelecaoIngrediente.Columns["columnNomeIngrediente"];
                    dataGridSelecaoIngrediente.Sort(columnToSort, ListSortDirection.Ascending);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível carregar todos os dados do ingrediente\n" + ex.Message, "Erro no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
        }

        private void TelaRegistroReceita_FormClosing(object sender, FormClosingEventArgs e)
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