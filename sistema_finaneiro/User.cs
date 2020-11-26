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
    class User
    {
        ConexaoBD bd = new ConexaoBD();
        private int UserId = 0;

        public int getUserId()
        {
            return this.UserId;
        }

        public bool CreateUser(string sql, string email, string pass)
        {
            try
            {
                bd.ConectarBD();
                MySqlConnection connection = bd.getConexao();
                MySqlCommand cmd = new MySqlCommand(sql, connection);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    if (Authenticator(email, pass))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                } else
                {
                    return false;
                }


            } 
            catch
            {
                throw;
            }
            finally
            {
                MySqlConnection connection = bd.getConexao();
                connection.Close();
            }
        }

        public DataTable DataList(string sql)
        {
            try
            {
                bd.ConectarBD();
                MySqlConnection connection = bd.getConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, connection);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                MySqlConnection connection = bd.getConexao();
                connection.Close();
            }
        }

        public bool Authenticator(string email, string pass)
        {
            try
            {
                MySqlConnection connection = bd.getConexao();
                bd.ConectarBD();
                string sql = string.Format("select id from user where email = '{0}' and password = '{1}'", email, pass);
                DataTable dt = new DataTable();
                dt = DataList(sql);

                if(dt.Rows.Count > 0)
                {
                    UserId = int.Parse(dt.Rows[0]["id"].ToString());
                    return true;
                } else
                {
                    return false;
                }
            } catch
            {
                throw;
            } finally
            {
                MySqlConnection connection = bd.getConexao();
                connection.Close();
            }
        }

        public int UpdateData(string sql)
        {
            try
            {
                MySqlConnection connection = bd.getConexao();
                bd.ConectarBD();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                return cmd.ExecuteNonQuery();
            } catch
            {
                throw;
            } finally
            {
                MySqlConnection connection = bd.getConexao();
                connection.Close();
            }
        }

    }
}
