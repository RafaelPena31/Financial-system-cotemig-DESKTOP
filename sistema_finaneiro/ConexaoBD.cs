using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Biblioteca
using System.Data;
using MySql.Data.MySqlClient;

namespace sistema_finaneiro
{
    class ConexaoBD
    {

        private MySqlConnection conexao;

        public MySqlConnection getConexao()
        {
            return this.conexao;
        }


        public void ConectarBD()
        {
            try
            {
                conexao = new MySqlConnection("Persist Security info = false;server=localhost;database=SISTEMA_FINANCEIRO;user=root;pwd=");
                conexao.Open();
            }
            catch 
            {
                throw;
            }
        }
    }
}
