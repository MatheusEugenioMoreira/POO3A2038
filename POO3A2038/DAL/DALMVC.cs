using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using POO3A2038.UI;

namespace POO3A2038.DAL
{
    class DALMVC
    {
        private MySqlConnection conexao;
        private string string_conexao = "persist security info = false;" + "server=localhost;" + "database=bd_gravadora;" + "user=root;" + "pwd=;";

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();  
               
            }
            catch (MySqlException e)
            {
                throw new Exception("Problemas na conexão com o Banco de Dados. Erro: " + e.Message);
            }
        }

        public void ExecutarComando(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possivel executar a instrução no Banco. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void AlterarTabelas(string sql)
        {
            Conectar();
            MySqlCommand comandos = new MySqlCommand(sql, conexao);
            comandos.ExecuteNonQuery();
            comandos.Dispose();
            conexao.Close();
        }

        public DataTable ConsultarDadosTabela(string sql)
        {
            Conectar();
            DataTable dt = new DataTable();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            consulta.Fill(dt);
            consulta.Dispose();
            conexao.Close();
            return dt;
        }

        


    }
}
