using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaGourmet
{
    class Receita
    {
        //Atributos
        private int id; // id da receita
        private string nome; // nome da receita
        private string categoria; // nome da categoria
        private double porcoes; // para quantas pessoas a receita
        private double custo; // valor da receita em função dos ingredientes
        private int tempoPreparacao; // ver como será passado para o banco de dados
        private int dificuldade; // De 1 a 10 (int)
        private string preparo; //modo de preparo da receita
        private Ingrediente ingrediente;//para gerar a lista de ingredientes da receita.

        //Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public double Porcoes { get => porcoes; set => porcoes = value; }
        public int TempoPreparacao { get => tempoPreparacao; set => tempoPreparacao = value; }
        public int Dificuldade { get => dificuldade; set => dificuldade = value; }
        public string Preparo { get => preparo; set => preparo = value; }
        public double Custo { get => custo; set => custo = value; }
        public Ingrediente Ingrediente {get => ingrediente; set => ingrediente = value; }
        public Receita() { ingrediente = new Ingrediente(); }        

        /** Métodos 
         * 
         * Específicos para os atributos de tipo primário da classe
         * 
         */

        /**
         * \brief Método que cadastra em um banco de dados todas as propriedades de um objeto receita (exceto Id).
         * \return Retorna verdadeiro a se ação foi bem sucedida.
         */
        public bool Cadastrar()
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

                //String para query.
                string insert = "INSERT INTO receita(nome,dificuldade,porcoes,tempo,categoria,preparo,custo) VALUES" +
                                " ('" + Nome + "'," + Dificuldade + "," + Porcoes + "," + TempoPreparacao + ",'" + Categoria + "','" + Preparo + "'," + Custo + "); SELECT last_insert_id() AS id;";
                //MessageBox.Show(insert);
                //Colocando a string no comando.
                comando.CommandText = insert;

                //Para gerar a consulta que alterará o DB
                MySqlDataReader reader = comando.ExecuteReader();

                //Ler o retorno do id
                reader.Read();
                Id = int.Parse(reader["id"].ToString());
                reader.Close();
                connection.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        /**
         * \brief Método que altera em um banco de dados o valor da propriedade custo de um objeto receita conforme o id do objeto.
         * \return Retorna verdadeiro a se ação foi bem sucedida.
         */
        public bool AlterarCusto()
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
                string update = "UPDATE receita SET custo=" + Custo + " WHERE id = " + Id + ";";

                // Testar se a consulta foi escrita corretamente.
                //MessageBox.Show("Cadastro custo: "+update);

                //Colocando a string no comando.
                comando.CommandText = update;

                MySqlDataReader reader = comando.ExecuteReader();

                reader.Close();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        /**
         * \brief Método que apaga em um banco de dados o objeto receita conforme o ID.
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
                string delete = "DELETE FROM preparo WHERE receita_id =" + Id + ";  DELETE  FROM receita WHERE id=" + Id + ";";
                //MessageBox.Show(insert);
                //Colocando a string no comando.
                comando.CommandText = delete;

                //Quantas linhas foram alteradas
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Close();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        /**
         * \brief Método que altera em um banco de dados o objeto receita conforme o ID.
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
                string update = "UPDATE receita SET" +
                                " nome='" + Nome + "', dificuldade=" + Dificuldade + ", porcoes=" + Porcoes +
                                ", tempo=" + TempoPreparacao + ", preparo='" + Preparo + "' WHERE id=" + Id + ";";
                //MessageBox.Show(update);
                //Colocando a string no comando.
                comando.CommandText = update;

                //Quantas linhas foram alteradas
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Close();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        /**
         * \brief Método que busca em um banco de dados o objeto receita conforme campo e  valor fornececidos.
         * \param string campo - atributo a ser pesquisado.
         * \param string procurado - valor do atributo a ser pesquisado.
         * \return Retorna verdadeiro a se objeto existe no banco de dados.
         */
        public bool Busca(string campo, string procurado)
        {
            try
            {
                //Criando string para criar a conexão.
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;";
                //Criando objeto de conexão
                MySqlConnection connection = new MySqlConnection(connectionString);
                //Abrindo conexão
                connection.Open();
                //Criando comando para  enviar a query
                MySqlCommand comando = connection.CreateCommand();

                string select = "SELECT * FROM  receita WHERE " + campo + " = " + procurado + ";";

                //Colocando a string no comando.
                comando.CommandText = select;

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        /**
         * \brief Método que obtem de um banco de dados os dados do objeto receita,
         * conforme ID.
         * \return Retorna verdadeiro a se objeto existe no banco de dados.
         */
        public bool ObterReceita()
        {
            try
            {
                //criando string para criar a conexão.
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;"; //Se tivesse senha: Password=senha;
                                                                                                              //criando objeto conexão
                MySqlConnection connection = new MySqlConnection(connectionString);
                //Abrindo conexão
                connection.Open();
                //Criando comando para  enviar a query
                MySqlCommand comando = connection.CreateCommand();
                //Obtendo os dados para receita
                string select = "SELECT * FROM  receita WHERE id=" + Id + ";";

                //Para descobrir se o select está sendo executado corretamente.
                //MessageBox.Show(select); 

                //Colocando a string no comando.
                comando.CommandText = select;
                //Dados que serão listados
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    //Preenchendo os campos
                    Nome = reader["nome"].ToString();
                    Categoria = reader["categoria"].ToString();
                    Preparo = reader["preparo"].ToString();
                    Porcoes = double.Parse(reader["porcoes"].ToString());
                    Custo = double.Parse(reader["custo"].ToString());
                    TempoPreparacao = int.Parse(reader["tempo"].ToString());
                    Dificuldade = int.Parse(reader["dificuldade"].ToString());

                    reader.Close();
                    connection.Close();
                    return true;
                }

                reader.Close();
                connection.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        /**
         * \brief Método que carrega de um banco de dados uma lista completa de receitas.
         * \return Retorna conjunto de objetos caso haja registros no banco de dados.
         */
        public MySqlDataReader Listar()
        {
            try
            {
                //Para comentários mais elaborados em conexão com MySQl checar 
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM  receita; ";
                comando.CommandText = select;
                //Dados que serão listados
                return comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return null;
            }
        }

        /**
         * \brief Método que carrega de um banco de dados uma lista  de receitas
         * que possuem a mesma categoria do objeto. Se  o atributo for "TODAS", não haverá
         * distinção por categoria alguma e agirá como o método Listar().
         * \return Retorna conjunto de objetos caso haja reistros no banco de dados com o critério selecionado.
         */
        public MySqlDataReader ListarPorCategoria()
        {
            try
            {
                //Para comentários mais elaborados em conexão com MySQl checar método Calcular()
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand comando = connection.CreateCommand();
                string select;

                if (Categoria == "TODAS")
                {
                    select = "SELECT * FROM  receita;";
                }
                else
                {
                    select = "SELECT * FROM  receita WHERE categoria = '" + Categoria + "';";
                }

                comando.CommandText = select;
                //MessageBox.Show(select);
                //Dados que serão listados
                return comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return null;
            }
        }

        /**
         * \brief Método que carrega de um banco de dados uma lista  de receitas
         * que possuem a mesma dificuldade do objeto.
         * \return Retorna conjunto de objetos caso haja reistros no banco de dados com o critério selecionado.
         */
        public MySqlDataReader ListarPorDificuldade()
        {
            try
            {
                //Para comentários mais elaborados em conexão com MySQl checar método Calcular()
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM  receita WHERE dificuldade = " + Dificuldade + " ; ";
                comando.CommandText = select;
                //MessageBox.Show(select);
                //Dados que serão listados
                return comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return null;
            }
        }

        /**
         * \brief Método que carrega de um banco de dados uma lista  de receitas
         * que estejam na mesma faixa de tempo de preparação do objeto. Os intervalos são:
         * - 20 minutos ou menos;
         * - entre 21 e 40 minutos;
         * - entre 41 e 60 minutos;
         * - acima de 61 minutos.
         * \return Retorna conjunto de objetos caso haja reistros no banco de dados com o critério selecionado.
         */
        public MySqlDataReader ListarPorTempo()
        {
            try
            {
                //Para comentários mais elaborados em conexão com MySQl checar método Calcular()
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand comando = connection.CreateCommand();
                string select;
                if (tempoPreparacao == 20)
                {
                    select = "SELECT  id,nome,dificuldade,porcoes,tempo,custo FROM  receita WHERE tempo <= 20;";
                }
                else if (tempoPreparacao == 40)
                {
                    select = "SELECT  id,nome,dificuldade,porcoes,tempo,custo FROM  receita WHERE tempo > 20 AND tempo < 41;";
                }
                else if (tempoPreparacao == 60)
                {
                    select = "SELECT  id,nome,dificuldade,porcoes,tempo,custo FROM  receita WHERE tempo >= 41 AND tempo <= 60;";
                }
                else
                {
                    select = "SELECT  id,nome,dificuldade,porcoes,tempo,custo FROM  receita WHERE tempo > 60;";
                }

                comando.CommandText = select;
                //MessageBox.Show(select);// rastrear se a Query está correta.
                //Dados que serão listados
                return comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return null;
            }
        }


        /** Métodos 
        * 
        * Específicos para os atributos de tipo composto da classe.
        * Lidam com a Lista de Ingredientes (DataGridView)
        * 
        */

        /**
         * \brief Método que altera em um banco de dados, o valor dos atributos de um ingrediente de objeto receita,
         * conforme os ID da receita e o ID do ingrediente. Esses dados estão listados em uma terceira tabela no banco de dados que
         * relaciona ingredientes e receitas.
         * \return Retorna verdadeiro a se ação foi bem sucedida.
         */
        public bool AlterarListaIngredientes()
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
                string update = "UPDATE preparo SET" +
                                " quantidade ='" + Ingrediente.Quantidade + "', custo='" + Ingrediente.Preco + "', unidade='" + Ingrediente.UnidadeMedidaPreco +
                                "' WHERE receita_id=" + Id + " AND ingrediente_id = " + Ingrediente.Id + ";";
                //MessageBox.Show(insert);
                //Colocando a string no comando.
                comando.CommandText = update;

                //Quantas linhas foram alteradas
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    connection.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    connection.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        /**
         * \brief Método que apaga em um banco de dados, o registro que relaciona receita a um dado ingrediente,
         * conforme os ID da receita e o ID do ingrediente.
         * Esses dados estão listados em uma terceira tabela.         
         * \return Retorna verdadeiro a se ação foi bem sucedida.
         */
        public bool ApagarIngrediente()
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
                string delete = "DELETE FROM preparo WHERE receita_id =" + Id + " AND ingrediente_id = " + Ingrediente.Id + ";";
                //MessageBox.Show(delete);
                //Colocando a string no comando.
                comando.CommandText = delete;

                //Quantas linhas foram alteradas
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Está apagando itens que estavam na lista anteriormente.");
                    reader.Close();
                    connection.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    connection.Close();
                    return false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        /**
         * \brief Método que cadastra em um banco de dados, o registro que relaciona receita a um dado ingrediente,
         * conforme os ID da receita e o ID do ingrediente.
         * Esses dados estão listados em uma terceira tabela
         * \return Retorna verdadeiro a se ação foi bem sucedida.
         */
        public bool CadastrarIngrediente()
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
                string insert = "INSERT INTO preparo(receita_id,ingrediente_id,quantidade,unidade,custo) VALUES" +
                    " (" + Id + ","
                         + Ingrediente.Id + "," 
                         + Ingrediente.Quantidade + ",'" 
                         + Ingrediente.UnidadeMedidaPreco + "'," 
                         + Ingrediente.Preco + ");";
                //MessageBox.Show(insert); // Para rastrear erros de sintaxe da query.
                //Colocando a string no comando.
                comando.CommandText = insert;

                //Quantas linhas foram alteradas
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    connection.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    connection.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        /**
         * \brief Método que confirma em um banco de dados,
         * se há o registro que relaciona receita a um dado ingrediente,
         * conforme os ID da receita e o ID do ingrediente.
         * Esses dados estão listados em uma terceira tabela
         * \return Retorna verdadeiro o registro da relação foi encontrado.
         */
        public bool ConfirmarIngredientesSelecionados()
        {
            try
            {
                //Para comentários mais elaborados em conexão com MySQl checar função Cadastrar().
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT receita_id FROM preparo WHERE receita_id =" + Id + " AND ingrediente_id =" + Ingrediente.Id + ";";

                comando.CommandText = select;
                // Para rastrear erros de sintaxe da query.
                //MessageBox.Show("Lista Ingredientes selecionados: " + select); 
                //Dados que serão listados                

                MySqlDataReader reader = comando.ExecuteReader();

                //MessageBox.Show(comando.ExecuteNonQuery().ToString());
                if (reader.HasRows)
                {
                    reader.Close();
                    connection.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    connection.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        /**
         * \brief Método que carrega de um banco de dados uma lista completa de ingredientes.
         * \return Retorna conjunto de objetos caso haja registros no banco de dados.
         */
        public MySqlDataReader ListarTodosIngredientes()
        {
            try
            {
                //Para comentários mais elaborados em conexão com MySQl checar 
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM ingrediente";
                comando.CommandText = select;
                // Para rastrear erros de sintaxe da query.
                //MessageBox.Show("Lista todos os Ingredientes: " + select);

                //Dados que serão listados
                return comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar todos os dados da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return null;
            }
        }

        /**
         * \brief Método que carrega  de um banco de dados,
         * a lista de registros que relacionam receita a um conjunto de ingredientes,
         * conforme os ID da receita e o IDs dos ingredientes.
         * Esses dados estão listados em uma terceira tabela
         * \return Retorna verdadeiro se há ao menos registro da relação foi encontrado.
         */
        public MySqlDataReader ListarIngredientesSelecionados()
        {
            try
            {
                //Para comentários mais elaborados em conexão com MySQl checar 
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT DISTINCT p.quantidade,p.unidade,p.custo,i.nome,i.id FROM preparo as p" +
                                " INNER JOIN  receita as r ON p.receita_id =" + Id +
                                " INNER JOIN ingrediente as i ON p.ingrediente_id = i.id;";
                comando.CommandText = select;
                //Dados que serão listados
                return comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os ingredientes da receita\n" + ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                return null;
            }
        }


    }//classe
}