using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaGourmet
{
    public partial class TelaReceita : Form
    {
        public Form telaInicio; // Formulário público para salvar o estado da tela desejada
        public TelaReceita()
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

        private void TelaReceita_Load(object sender, EventArgs e)
        {
            try
            {
                //Preenchendo o combobox
                cboOrdenacao.DataSource = new string[] {
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

                Receita receita = new Receita();

                MySqlDataReader reader;

                receita.Categoria = cboOrdenacao.SelectedItem.ToString();
                reader = receita.ListarPorCategoria();
                if (reader != null && (reader.HasRows))
                {
                    while (reader.Read())
                    {
                        int n = dataGridReceita.Rows.Add();
                        //Preenchendo o datagrid.
                        dataGridReceita.Rows[n].Cells["txtColumnIdReceita"].Value = reader["id"];
                        dataGridReceita.Rows[n].Cells["txtColumnNomeReceita"].Value = reader["nome"];
                        dataGridReceita.Rows[n].Cells["txtColumnValorReceita"].Value = reader["custo"];
                        dataGridReceita.Rows[n].Cells["txtColumnDificuldadeReceita"].Value = reader["dificuldade"];
                        dataGridReceita.Rows[n].Cells["txtColumnRendimentoReceita"].Value = reader["porcoes"];
                        dataGridReceita.Rows[n].Cells["txtColumnTempoPreparoReceita"].Value = reader["tempo"];


                        ToolTip DicaCadastro = new ToolTip();
                        DicaCadastro.ShowAlways = true;
                        DicaCadastro.SetToolTip(menuStrip1, "Clique aqui para cadastrar uma nova receita.");
                    }
                    //Ordenando pela coluna nome da receita.
                    DataGridViewColumn columnToSort = dataGridReceita.Columns["txtColumnNomeReceita"];
                    dataGridReceita.Sort(columnToSort, ListSortDirection.Ascending);
                }
                else
                {
                    // BD não está sendo acessado.
                    MessageBox.Show("Ainda não há receitas nesta categoria", "Erro na busca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados do ingrediente\n" + ex.Message, "Erro no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
        }
    
        private void BtnReceitaVoltaMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            TelaRegistroReceita registroReceita = new TelaRegistroReceita() { telaInicioRegistro = telaInicio };
            registroReceita.Show();
            telaInicio.Hide();
            this.Hide();
        }

        private void DataGridReceita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //solução para não gerar erro d clicque no cabeçalho.
            if (e.RowIndex == -1) return;

            //Passando o id da receita para carregar os dados do objeto na próxima tela.            
            int indice = int.Parse(dataGridReceita.Rows[e.RowIndex].Cells[0].Value.ToString());
            
            TelaDetalheReceita detalheReceita = new TelaDetalheReceita() { idReceitaDetalhe = indice, telaInicioDetalhe = telaInicio };
            detalheReceita.Show();
            telaInicio.Hide();
            this.Hide();
        }
  
        private void rdoCategoriaReceita_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Limpar o datagrid anterior.
                dataGridReceita.Rows.Clear();
                //Deixando botões visíveis.
                cboOrdenacao.Visible = true;
                btnSelecao.Visible = true;
                //Deixando label visível.
                lblEscolhaOpcao.Visible = true;

                //Preenchendo o combobox
                cboOrdenacao.DataSource = new string[] {
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

                Receita receita = new Receita();
                receita.Categoria = cboOrdenacao.SelectedItem.ToString();

                MySqlDataReader reader = receita.ListarPorCategoria();

                if (reader != null && (reader.HasRows))
                {
                    while (reader.Read())
                    {
                        int n = dataGridReceita.Rows.Add();
                        //Preenchendo o datagrid.
                        dataGridReceita.Rows[n].Cells["txtColumnIdReceita"].Value = reader["id"];
                        dataGridReceita.Rows[n].Cells["txtColumnNomeReceita"].Value = reader["nome"];
                        dataGridReceita.Rows[n].Cells["txtColumnValorReceita"].Value = reader["custo"];
                        dataGridReceita.Rows[n].Cells["txtColumnDificuldadeReceita"].Value = reader["dificuldade"];
                        dataGridReceita.Rows[n].Cells["txtColumnRendimentoReceita"].Value = reader["porcoes"];
                        dataGridReceita.Rows[n].Cells["txtColumnTempoPreparoReceita"].Value = reader["tempo"];
                    }
                    //Ordenando pela coluna nome da receita.
                    DataGridViewColumn columnToSort = dataGridReceita.Columns["txtColumnNomeReceita"];
                    dataGridReceita.Sort(columnToSort, ListSortDirection.Ascending);

                    ToolTip DicaCadastro = new ToolTip();
                    DicaCadastro.ShowAlways = true;
                    DicaCadastro.SetToolTip(menuStrip1, "Clique aqui para cadastrar uma nova receita.");
                }
                else
                {
                    MessageBox.Show("Não há receitas no banco de dados que atenda o critério escolhido."); // BD não está sendo acessado.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdoDificuldadeReceita_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Limpar o datagrid anterior.
                dataGridReceita.Rows.Clear();
                //Deixando botões visíveis.
                cboOrdenacao.Visible = true;
                btnSelecao.Visible = true;

                //Preenchendo ComboBox
                cboOrdenacao.DataSource = new string[] {
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

                Receita receita = new Receita();
                receita.Dificuldade = int.Parse(cboOrdenacao.SelectedItem.ToString());

                MySqlDataReader reader = receita.ListarPorDificuldade();

                if (reader != null && (reader.HasRows))
                {
                    while (reader.Read())
                    {
                        int n = dataGridReceita.Rows.Add();
                        //Preenchendo o datagrid.
                        dataGridReceita.Rows[n].Cells["txtColumnIdReceita"].Value = reader["id"];
                        dataGridReceita.Rows[n].Cells["txtColumnNomeReceita"].Value = reader["nome"];
                        dataGridReceita.Rows[n].Cells["txtColumnValorReceita"].Value = reader["custo"];
                        dataGridReceita.Rows[n].Cells["txtColumnDificuldadeReceita"].Value = reader["dificuldade"];
                        dataGridReceita.Rows[n].Cells["txtColumnRendimentoReceita"].Value = reader["porcoes"];
                        dataGridReceita.Rows[n].Cells["txtColumnTempoPreparoReceita"].Value = reader["tempo"];
                    }
                    //Ordenando pela coluna nome da receita.
                    DataGridViewColumn columnToSort = dataGridReceita.Columns["txtColumnNomeReceita"];
                    dataGridReceita.Sort(columnToSort, ListSortDirection.Ascending);
                }
                else
                {
                    MessageBox.Show("Não há receitas no banco de dados que atenda o critério escolhido."); // BD não está sendo acessado.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdoTempoPreparo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Limpar o datagrid anterior.
                dataGridReceita.Rows.Clear();
                //Deixando botões visíveis.
                cboOrdenacao.Visible = true;
                btnSelecao.Visible = true;

                //Preenchendo Combobox
                cboOrdenacao.DataSource = new string[] {
                            "20 minutos ou menos",
                            "21 a 40 minutos",
                            "41 a 60 minutos",
                            "61 minutos ou mais"
                    };

                //Criando objetos.
                Receita receita = new Receita();

                //MessageBox.Show("Antes dos IFs\n\nString: " + cboOrdenacao.SelectedItem.ToString() + " Tempo: " + receita.TempoPreparacao.ToString());

                //Atribuindo valores aos objetos conforme o intervalo escolhido.
                if (cboOrdenacao.SelectedItem.ToString() == "20 minutos ou menos")
                {
                    receita.TempoPreparacao = 20;
                    //MessageBox.Show("String: " + cboOrdenacao.SelectedItem.ToString() + " Tempo: " + receita.TempoPreparacao.ToString());//Apenas para rastrear onde o código está passando.
                }
                else if (cboOrdenacao.SelectedItem.ToString() == "21 a 40 minutos")
                {
                    receita.TempoPreparacao = 40;
                    //MessageBox.Show("String: " + cboOrdenacao.SelectedItem.ToString() + " Tempo: " + receita.TempoPreparacao.ToString());
                }
                else if (cboOrdenacao.SelectedItem.ToString() == "41 a 60 minutos")
                {
                    receita.TempoPreparacao = 60;
                    //MessageBox.Show("String: " + cboOrdenacao.SelectedItem.ToString() + " Tempo: " + receita.TempoPreparacao.ToString());
                }
                else
                {
                    receita.TempoPreparacao = 61;
                    //MessageBox.Show("String: " + cboOrdenacao.SelectedItem.ToString() + " Tempo: " + receita.TempoPreparacao.ToString());
                }                

                //Criando objeto e inserindo valor para buscar dentro do intervalo escolhido.
                MySqlDataReader reader = receita.ListarPorTempo();

                if (reader != null && (reader.HasRows))
                {
                    while (reader.Read())
                    {
                        int n = dataGridReceita.Rows.Add();
                        //Preenchendo o datagrid.
                        dataGridReceita.Rows[n].Cells["txtColumnIdReceita"].Value = reader["id"];
                        dataGridReceita.Rows[n].Cells["txtColumnNomeReceita"].Value = reader["nome"];
                        dataGridReceita.Rows[n].Cells["txtColumnValorReceita"].Value = reader["custo"];
                        dataGridReceita.Rows[n].Cells["txtColumnDificuldadeReceita"].Value = reader["dificuldade"];
                        dataGridReceita.Rows[n].Cells["txtColumnRendimentoReceita"].Value = reader["porcoes"];
                        dataGridReceita.Rows[n].Cells["txtColumnTempoPreparoReceita"].Value = reader["tempo"];
                    }
                    //Ordenando pela coluna nome da receita.
                    DataGridViewColumn columnToSort = dataGridReceita.Columns["txtColumnNomeReceita"];
                    dataGridReceita.Sort(columnToSort, ListSortDirection.Ascending);
                }
                else
                {
                    MessageBox.Show("Não há receitas no banco de dados que atenda o critério escolhido."); // BD não está sendo acessado.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rdoTodasReceitas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Limpar o datagrid anterior.
                dataGridReceita.Rows.Clear();
                //Criando objetos.
                Receita receita = new Receita();
                receita.Categoria = "TODAS";
                MySqlDataReader reader = receita.ListarPorCategoria();

                //Deixando label e ComboBox invisíveis.
                cboOrdenacao.Visible = false;
                lblEscolhaOpcao.Visible = false;
                btnSelecao.Visible = false;

                if (reader != null && (reader.HasRows))
                {
                    while (reader.Read())
                    {
                        int n = dataGridReceita.Rows.Add();
                        //Preenchendo o datagrid.
                        dataGridReceita.Rows[n].Cells["txtColumnIdReceita"].Value = reader["id"];
                        dataGridReceita.Rows[n].Cells["txtColumnNomeReceita"].Value = reader["nome"];
                        dataGridReceita.Rows[n].Cells["txtColumnValorReceita"].Value = reader["custo"];
                        dataGridReceita.Rows[n].Cells["txtColumnDificuldadeReceita"].Value = reader["dificuldade"];
                        dataGridReceita.Rows[n].Cells["txtColumnRendimentoReceita"].Value = reader["porcoes"];
                        dataGridReceita.Rows[n].Cells["txtColumnTempoPreparoReceita"].Value = reader["tempo"];
                    }
                    //Ordenando pela coluna nome da receita.
                    DataGridViewColumn columnToSort = dataGridReceita.Columns["txtColumnNomeReceita"];
                    dataGridReceita.Sort(columnToSort, ListSortDirection.Ascending);
                }
                else
                {
                    MessageBox.Show("Não há receitas no banco de dados que atenda o critério escolhido."); // BD não está sendo acessado.
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelecao_Click(object sender, EventArgs e)
        {
            try
            {
                //Limpar o datagrid anterior.
                dataGridReceita.Rows.Clear();
                //Deixando label visível.
                lblEscolhaOpcao.Visible = true;

                Receita receita = new Receita();
                //receita.Categoria = cboOrdenacao.SelectedItem.ToString();

                MySqlDataReader reader;

                if (rdoDificuldadeReceita.Checked == true)
                {
                    receita.Dificuldade = int.Parse(cboOrdenacao.SelectedItem.ToString());
                    reader = receita.ListarPorDificuldade();
                }
                else if (rdoTempoPreparo.Checked == true)
                {
                    if (cboOrdenacao.SelectedItem.ToString() == "20 minutos ou menos")
                    {
                        receita.TempoPreparacao = 20;
                        //MessageBox.Show("String: " + cboOrdenacao.SelectedItem.ToString() + " Tempo: " + receita.TempoPreparacao.ToString());//Apenas para rastrear onde o código está passando.
                    }
                    else if (cboOrdenacao.SelectedItem.ToString() == "21 a 40 minutos")
                    {
                        receita.TempoPreparacao = 40;
                        //MessageBox.Show("String: " + cboOrdenacao.SelectedItem.ToString() + " Tempo: " + receita.TempoPreparacao.ToString());
                    }
                    else if (cboOrdenacao.SelectedItem.ToString() == "41 a 60 minutos")
                    {
                        receita.TempoPreparacao = 60;
                        //MessageBox.Show("String: " + cboOrdenacao.SelectedItem.ToString() + " Tempo: " + receita.TempoPreparacao.ToString());
                    }
                    else
                    {
                        receita.TempoPreparacao = 61;
                        //MessageBox.Show("String: " + cboOrdenacao.SelectedItem.ToString() + " Tempo: " + receita.TempoPreparacao.ToString());
                    }
                    
                    reader = receita.ListarPorTempo();
                }
                else
                {
                    receita.Categoria = cboOrdenacao.SelectedItem.ToString();
                    reader = receita.ListarPorCategoria();
                }

                if (reader != null && (reader.HasRows))
                {
                    while (reader.Read())
                    {
                        //Criando o indice da linha apresentada.
                        int n = dataGridReceita.Rows.Add();

                        //Carregando as linhas.
                        dataGridReceita.Rows[n].Cells["txtColumnIdReceita"].Value = reader["id"];
                        dataGridReceita.Rows[n].Cells["txtColumnNomeReceita"].Value = reader["nome"];
                        dataGridReceita.Rows[n].Cells["txtColumnTempoPreparoReceita"].Value = reader["tempo"];
                        dataGridReceita.Rows[n].Cells["txtColumnRendimentoReceita"].Value = reader["porcoes"];
                        dataGridReceita.Rows[n].Cells["txtColumnValorReceita"].Value = reader["custo"];
                        dataGridReceita.Rows[n].Cells["txtColumnDificuldadeReceita"].Value = reader["dificuldade"];
                    }
                    //Ordenando pela coluna nome da receita.
                    DataGridViewColumn columnToSort = dataGridReceita.Columns["txtColumnNomeReceita"];
                    dataGridReceita.Sort(columnToSort, ListSortDirection.Ascending);
                }
                else
                {
                    // BD está sendo acessado.
                    MessageBox.Show("Ainda não há receitas nesta categoria", "Erro na busca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados do ingrediente\n" + ex.Message, "Erro no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
        }

        private void TelaReceita_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Confirma se o usuário realmente deseja sair do sistema
            DialogResult sair = MessageBox.Show("Deseja voltar ao menu principal?", "Retonar ao menu", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (sair.ToString().ToUpper() == "YES")
            {
                telaInicio.Show();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
