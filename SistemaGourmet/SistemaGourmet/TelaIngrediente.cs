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
    public partial class TelaIngrediente : Form
    {   
        //Atributos
        public Form telaInicio; // Formulário público para salvar o estado da tela desejada

        public TelaIngrediente()
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

        private void DataGridIngrediente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //solução para não gerar erro d clicque no cabeçalho.
            if (e.RowIndex == -1) return;

            //Passando o id do ingrediente para carregar os dados do objeto na próxima tela.            
            int indice = int.Parse(dataGridIngrediente.Rows[e.RowIndex].Cells[0].Value.ToString());
            //Criando nova tela com detalhes da receita.
            TelaDetalheIngrediente detalheIngrediente = new TelaDetalheIngrediente() { idIngredienteDetalhe = indice, telaInicialDetalhe =telaInicio};
            telaInicio.Hide();
            detalheIngrediente.Show();
            this.Hide();
        }

        private void TelaIngrediente_Load(object sender, EventArgs e)
        {
            try
            {
                Ingrediente ingrediente = new Ingrediente();
                MySqlDataReader reader = ingrediente.Listar();

                if (reader != null && (reader.HasRows))
                {


                    while (reader.Read())
                    {
                        int n = dataGridIngrediente.Rows.Add();
                        //Dados que serão colocados no datagrid.
                        dataGridIngrediente.Rows[n].Cells["txtColumnIdIngrediente"].Value = reader["id"];
                        dataGridIngrediente.Rows[n].Cells["txtColumnNomeIngrediente"].Value = reader["nome"];
                        dataGridIngrediente.Rows[n].Cells["txtColumnValorIngrediente"].Value = reader["preco"];
                        dataGridIngrediente.Rows[n].Cells["txtColumnUnidadeIngrediente"].Value = reader["unidade"];
                        dataGridIngrediente.Rows[n].Cells["txtColumnQuantidadeIngrediente"].Value = reader["quantidade"];
                    }
                    //Ordenando pela coluna nome do ingrediente.
                    DataGridViewColumn columnToSort = dataGridIngrediente.Columns["txtColumnNomeIngrediente"];
                    dataGridIngrediente.Sort(columnToSort, ListSortDirection.Ascending);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados do ingrediente\n" + ex.Message, "Erro no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
        }

        private void BtnIngredienteVoltaMenu_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngredienteRegistrar_Click(object sender, EventArgs e)
        {
            TelaRegistroIngrediente registroIngrediente = new TelaRegistroIngrediente() { telaInicialRegistro = telaInicio };
            registroIngrediente.Show();
            telaInicio.Hide();
            this.Hide();
        }

        private void TelaIngrediente_FormClosing(object sender, FormClosingEventArgs e)
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
