using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaGourmet
{
    class Ingrediente
    {
        //Atributos
        private int id;
        private string nome;
        private double preco;        
        private double quantidade;
        private string unidadeMedidaPreco; //Serão medidas pré-definidas (L, mL, Kg, g, e etc.)
       /*Qual a unidade  de medida que o item foi comprado .Ex.: normalmente compra 1l de leite,
        * mas gasta-se 200ml para uma receita. Criar um método que calcular o custo do ingrediente
        * baseado no preço e quantidade? 
        **/
        
        //Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        public string UnidadeMedidaPreco { get => unidadeMedidaPreco; set => unidadeMedidaPreco = value; }

        //Métodos

        /**
         * \brief Método que cadastra em um banco de dados todas as propriedades de um objeto
         * ingrediente (exceto Id).
         * \return Retorna verdadeiro a se ação foi bem sucedida.
         */
        public bool Cadastrar()
        {
            try
            {
                //criando string para criar a conexão.
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;"; 
                //Se tivesse senha: Password=senha.
                
                //criando objeto conexão
                MySqlConnection connection = new MySqlConnection(connectionString);
                //abrindo conexão
                connection.Open();
                //Criando comando para  enviar a query
                MySqlCommand comando = connection.CreateCommand();
                string insert = "INSERT INTO ingrediente(nome,preco,quantidade,unidade) VALUES" +
                    " ('" + nome + "','" + preco + "','" + quantidade + "','" + unidadeMedidaPreco +"'); SELECT last_insert_id() AS id;";
                //MessageBox.Show(insert);
                //Colocando a string no comando.
                comando.CommandText = insert;


                //Quantas linhas foram alteradas
                MySqlDataReader reader = comando.ExecuteReader();
                //Ler o retorno do id
                reader.Read();
                id = int.Parse(reader["id"].ToString());

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados do ingrediente\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        /**
         * \brief Método que apaga em um banco de dados o objeto ingrediente conforme o ID.
         * \return Retorna verdadeiro a se ação foi bem sucedida.
         */
        public bool Apagar()
        {
            try
            {
                //criando string para criar a conexão.
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;"; //Se tivesse senha: Password=senha;
                                                                                                              //criando objeto conexão
                MySqlConnection connection = new MySqlConnection(connectionString);
                //abrindo conexão
                connection.Open();
                //Criando comando para  enviar a query
                MySqlCommand comando = connection.CreateCommand();
                string delete = "DELETE  FROM ingrediente WHERE id="+Id+";";                
                //Colocando a string no comando.
                comando.CommandText = delete;

                //Quantas linhas foram alteradas
                MySqlDataReader reader = comando.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados do ingrediente\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        /**
         * \brief Método que altera em um banco de dados o objeto ingrediente conforme o ID.
         * \return Retorna verdadeiro a se ação foi bem sucedida.
         */
        public bool Alterar()
        {
            try
            {
                //criando string para criar a conexão.
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;"; //Se tivesse senha: Password=senha;
                                                                                                              //criando objeto conexão
                MySqlConnection connection = new MySqlConnection(connectionString);
                //abrindo conexão
                connection.Open();
                //Criando comando para  enviar a query
                MySqlCommand comando = connection.CreateCommand();
                string update = "UPDATE ingrediente SET "+ 
                                "nome='"+Nome+"', preco="+Preco+", quantidade="+Quantidade+
                                ", unidade='"+UnidadeMedidaPreco+"' WHERE id = "+Id+";";
                //MessageBox.Show(update);
                //Colocando a string no comando.
                comando.CommandText = update;

                //Quantas linhas foram alteradas
                MySqlDataReader reader = comando.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados do ingrediente\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        /**
         * \brief Método que carrega de um banco de dados uma lista completa de ingredientes.
         * \return Retorna conjunto de objetos caso haja registros no banco de dados.
         */
        public MySqlDataReader Listar()
        {
            try
            {
                //criando string para criar a conexão.
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;"; 

                MySqlConnection connection = new MySqlConnection(connectionString);
                //abrindo conexão
                connection.Open();
                //Criando comando para  enviar a query
                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM  ingrediente; ";

                //Colocando a string no comando.
                comando.CommandText = select;
                //Dados que serão listados
                return comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados do ingrediente\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return null;
            }
        }

         /**
         * \brief Método que obtem de um banco de dados os dados do objeto ingrediente,
         * conforme ID.
         * \return Retorna verdadeiro a se objeto existe no banco de dados.
         */
        public bool ObterIngrediente()
        {
            try
            {
                //Para comentários mais elaborado sobre conexão com MySQL nessa sessão veja o método Cadastrar
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;"; 
                MySqlConnection connection = new MySqlConnection(connectionString);                
                connection.Open();                
                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM ingrediente WHERE id='" + Id + "';";
                //MessageBox.Show(select); //Descobrir se o select está sendo executado corretamente.                
                comando.CommandText = select;

                //Dados que serão listados
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    //Preenchendo os campos
                    Nome = reader["nome"].ToString();                                        
                    UnidadeMedidaPreco = reader["unidade"].ToString();                                        
                    Preco = double.Parse(reader["preco"].ToString());
                    Quantidade = double.Parse(reader["quantidade"].ToString());                    

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados do ingrediente\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }

        }
    }
}
