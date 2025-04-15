using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using tcc.Estoque;
using tcc.Funcionario;

namespace tcc
{
    public partial class Menu : Form
    {
        // String de conexão com MySQL no WAMP
        string conexaoString = "server=localhost;user id=root;password=;database=tcc;";
        MySqlConnection conexao;

        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            try
            {
                conexao = new MySqlConnection(conexaoString);
                conexao.Open();
                MessageBox.Show("Conectado com sucesso ao banco!");

                // Substitua "clientes" pelo nome da sua tabela real
               /* string query = "SELECT * FROM produtos";
                MySqlCommand comando = new MySqlCommand(query, conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    // Verifica se a coluna "nome" existe e não é nula
                    if (!reader.IsDBNull(reader.GetOrdinal("name")))
                    {
                        string nome = reader["name"].ToString();
                        MessageBox.Show("name: " + nome);
                    }
                }

                reader.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão: " + ex.Message);
            }
            finally
            {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                    conexao.Close();
            }
        }

        private void oasdoajsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_Estoque menu = new Menu_Estoque();
            menu.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_Funcionario menu = new Menu_Funcionario();
            menu.Show();
        }
    }
}
