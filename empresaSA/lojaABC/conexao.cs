using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace lojaABC
{
    class conexao
    {
        private static string conn = "Server=localhost;Port=3306;Database=dblojaabc;Uid=loja;Pwd=123456";

        private static MySqlConnection con = null;

        public static MySqlConnection obterConexao()
        {
            con = new MySqlConnection(conn);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                con = null;
               
            }
            return con;
        }
        public static void fecharConexao()
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }  
}
