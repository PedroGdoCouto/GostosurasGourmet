using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace SistemaGourmet
{
    class Categoria
    {
        //Atributos
        private int id;
        private string nome;

        //Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        //Métodos

        public bool ObterCategoria()
        {
            try
            {
                //criando string para criar a conexão.
                string connectionString = "Server=localhost; port=3306; Database=dbculinaria; User ID=root;"; //Se tivesse senha: Password=senha;
                                                                                                              //criando objeto conexão
                MySqlConnection connection = new MySqlConnection(connectionString);                
                connection.Open();                
                MySqlCommand comando = connection.CreateCommand();
                string select = "SELECT * FROM categoria WHERE id='" + Id + "';";
                //MessageBox.Show(select); //Descobrir se o select está sendo executado corretamente.                
                comando.CommandText = select;                
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    //Preenchendo o campo.
                    Nome = reader["nome"].ToString();
                    return true;
                }

                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Sistema: " + ex.Message);
                return false;
            }

        }
    }
}