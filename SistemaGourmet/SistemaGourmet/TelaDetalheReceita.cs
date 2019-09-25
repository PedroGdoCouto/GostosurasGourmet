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
    public partial class TelaDetalheReceita : Form
    {
        //Atributos
        public Form telaInicioDetalhe;
        public int idReceitaDetalhe;

        public TelaDetalheReceita()
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

        private void BtnAlteraReceita_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!txtNomeReceita.Text.Equals(""))  //nenhum valor pode ficar em branco.                                                         
                  &&(!cmbDificuldadeReceita.SelectedItem.Equals("")) 
                  &&(!txtTempoPreparo.Text.Equals("")) 
                  &&(!txtRendimentoReceita.Text.Equals("")) 
                  &&(!richTxtModoPreparo.Text.Equals("")) 
                  &&(!cmbCategoriaReceita.SelectedItem.ToString().Equals(""))
                    )
                {
                    //Resgatando o objeto
                    Receita receita = new Receita();
                    receita.Id = idReceitaDetalhe;

                    //Atribuindo novos valores ao objeto.
                    receita.Nome = txtNomeReceita.Text;
                    receita.Custo = double.Parse(txtValorReceita.Text);
                    receita.Porcoes = double.Parse(txtRendimentoReceita.Text);
                    receita.TempoPreparacao = int.Parse(txtTempoPreparo.Text);
                    receita.Categoria = cmbCategoriaReceita.SelectedItem.ToString();
                    receita.Dificuldade = int.Parse(cmbDificuldadeReceita.SelectedItem.ToString());
                    receita.Preparo = richTxtModoPreparo.Text;

                    if (receita.Alterar()) //Altera o valor dos dados primários
                    {                           
                        foreach (DataGridViewRow row in dataGridSelecaoIngrediente.Rows) //Altera os dados da lista de ingrediente.
                        {
                            if (Convert.ToBoolean(row.Cells["columnSelecaoIngrediente"].Value) == false)
                            { // Tirar ingrediente que estava cadastrado na receita e foi retirado pelo usuário.
                              // MessageBox.Show("Apagando ingredientes na lista da receita.");
                                receita.ApagarIngrediente();
                            }
                            else  if (Convert.ToBoolean(row.Cells["columnSelecaoIngrediente"].Value) == true)
                            {
                                //Criando o  objeto.
                                // receita.ObterReceita();

                                //Atribuindo os valores para o objeto receita.ingrediente
                                receita.Ingrediente.Id = int.Parse(row.Cells["columnIdIngrediente"].Value.ToString());                                
                                receita.Ingrediente.Quantidade = double.Parse(row.Cells["columnQuantidadeIngrediente"].Value.ToString());
                                receita.Ingrediente.UnidadeMedidaPreco = row.Cells["columnUnidadeIngrediente"].Value.ToString();
                                receita.Ingrediente.Preco = double.Parse(row.Cells["columnValorIngrediente"].Value.ToString());

                                if(receita.ConfirmarIngredientesSelecionados())
                                {// Muda valores de item que ja está cadastrado previamente na receita.
                                 // MessageBox.Show("Alterando valor de ingredientes na lista.");
                                    receita.AlterarListaIngredientes();
;                                }
                                else
                                {//Cadastra novos ingredientes.
                                    receita.CadastrarIngrediente();
                                 // MessageBox.Show("cadastrando novos itens itens.");
                                }
                            }

                        }

                        MessageBox.Show("Alteração realizada com sucesso", "Alteração realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                        TelaReceita telaReceita = new TelaReceita() { telaInicio = telaInicioDetalhe };
                        telaInicioDetalhe.Hide();
                        telaReceita.Show();
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
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível alterar os dados\n" + ex.Message, "Erro na alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
        }

        private void BtnRegistroReceita_Click(object sender, EventArgs e)
        {

            TelaRegistroReceita registroReceita = new TelaRegistroReceita() { telaInicioRegistro = telaInicioDetalhe};
            registroReceita.Show();
            telaInicioDetalhe.Hide();
            this.Hide();
        }

        private void TelaDetalheReceita_Load(object sender, EventArgs e)
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

                cmbDificuldadeReceita.DataSource = new string[] {
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

                //Criando o objeto que guardará as incormações no banco de dados.
                Receita receita = new Receita();
                receita.Id = idReceitaDetalhe;
                if (receita.ObterReceita())
                {
                    //Atribuindo novos valores.
                    txtNomeReceita.Text = receita.Nome.ToString();
                    txtRendimentoReceita.Text = receita.Porcoes.ToString();                    
                    txtTempoPreparo.Text = receita.TempoPreparacao.ToString();
                    cmbCategoriaReceita.SelectedItem = receita.Categoria;
                    cmbDificuldadeReceita.SelectedItem = receita.Dificuldade.ToString();
                    richTxtModoPreparo.Text = receita.Preparo;

                    //Carregando dataGrid com a lista de ingredientes relacionados a receita.
                    MySqlDataReader reader = receita.ListarTodosIngredientes();

                    if (reader != null && (reader.HasRows))
                    {
                        while (reader.Read())
                        {
                            int n = dataGridSelecaoIngrediente.Rows.Add();

                            dataGridSelecaoIngrediente.Rows[n].Cells["columnIdIngrediente"].Value = reader["id"];
                            dataGridSelecaoIngrediente.Rows[n].Cells["columnNomeIngrediente"].Value = reader["nome"];
                            dataGridSelecaoIngrediente.Rows[n].Cells["columnValorIngrediente"].Value = reader["preco"];
                            dataGridSelecaoIngrediente.Rows[n].Cells["columnQuantidadeIngrediente"].Value = reader["quantidade"];
                            dataGridSelecaoIngrediente.Rows[n].Cells["columnUnidadeIngrediente"].Value = reader["unidade"];
                            dataGridSelecaoIngrediente.Rows[n].Cells["columnSelecaoIngrediente"].Value = false;

                            //Endereçando o id do ingrediente para trabalhar com selecionados
                            receita.Ingrediente.Id = int.Parse(dataGridSelecaoIngrediente.Rows[n].Cells["columnIdIngrediente"].Value.ToString());

                            if (receita.ConfirmarIngredientesSelecionados())
                            {
                                //Marcando a coluna do checkbox                                
                                dataGridSelecaoIngrediente.Rows[n].Cells["columnSelecaoIngrediente"].Value = true;
                            }
                        }
                        //Ordenando lista pelo nome dos ingredientes.
                        DataGridViewColumn columnToSort = dataGridSelecaoIngrediente.Columns["columnNomeIngrediente"];
                        dataGridSelecaoIngrediente.Sort(columnToSort, ListSortDirection.Ascending);
                    }
                    //Encerrando o primeiro reader.
                    reader.Close();
                    
                    //Abrindo o segundo reader.
                    //Carregando dataGrid com a lista de ingredientes relacionados a receita.
                    MySqlDataReader readerSelecionados = receita.ListarIngredientesSelecionados();

                    //Somando os valores de ingredientes para o custo
                    double valorTotal = 0;

                    if (readerSelecionados != null && (readerSelecionados.HasRows))
                    {
                        while (readerSelecionados.Read())
                        {
                            int n = dataGridSelecionados.Rows.Add();

                            dataGridSelecionados.Rows[n].Cells["columnIdIngredienteSelecionado"].Value = readerSelecionados["id"];
                            dataGridSelecionados.Rows[n].Cells["columnNomeIngredienteSelecionado"].Value = readerSelecionados["nome"];
                            dataGridSelecionados.Rows[n].Cells["columnValorIngredienteSelecionado"].Value = readerSelecionados["custo"];
                            dataGridSelecionados.Rows[n].Cells["columnQuantidadeIngredienteSelecionado"].Value = readerSelecionados["quantidade"];
                            dataGridSelecionados.Rows[n].Cells["columnUnidadeIngredienteSelecionado"].Value = readerSelecionados["unidade"];                                

                            //Endereçando o id do ingrediente para trabalhar com selecionados
                            //receita.Ingrediente.Id = int.Parse(dataGridSelecionados.Rows[n].Cells["columnIdIngredienteSelecionado"].Value.ToString());

                            //Somando o custo da receita.
                            valorTotal += Convert.ToDouble(dataGridSelecionados.Rows[n].Cells["columnValorIngredienteSelecionado"].Value);
                        }
                        //Ordenando lista pelo nome dos ingredientes.
                        DataGridViewColumn columnToSort = dataGridSelecionados.Columns["columnNomeIngredienteSelecionado"];
                        dataGridSelecionados.Sort(columnToSort, ListSortDirection.Ascending);
                    }
                    receita.Id = idReceitaDetalhe;
                    //Definindo o custo total da receita.
                    receita.Custo = valorTotal;
                    receita.AlterarCusto();
                    txtValorReceita.Text = receita.Custo.ToString();
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

        private void btnVoltaReceita_Click(object sender, EventArgs e)
        {
            TelaReceita telaReceita = new TelaReceita() { telaInicio = telaInicioDetalhe};
            telaReceita.Show();
            telaInicioDetalhe.Hide();
            this.Hide();
        }

        private void btnDeletaReceita_Click(object sender, EventArgs e)
        {
            // Confirma se o usuário realmente deseja sair do sistema
            DialogResult apagar = MessageBox.Show("Deseja realmente excluir essa receita do banco de dados?", "Excluir receita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (apagar.ToString().ToUpper() == "YES")
            {
                //Resgatando o objeto
                Receita receita = new Receita();
                receita.Id = idReceitaDetalhe;

                if (receita.Apagar())
                {
                    MessageBox.Show("Exclusão do ingrediente foi bem sucedida", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

                    //Voltando para tela de receitas.
                    TelaReceita telaReceita = new TelaReceita() { telaInicio = telaInicioDetalhe };
                    telaReceita.Show();
                    telaInicioDetalhe.Hide();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o ingrediente", "Erro na exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                }
 
            }
        }

        private void TelaDetalheReceita_FormClosing(object sender, FormClosingEventArgs e)
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
