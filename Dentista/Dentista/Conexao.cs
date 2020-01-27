using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dentista
{
    class Conexao
    {
        private SqlConnection sqlcon;
        private String dadosCon = @"SERVER=LAB604-5;DATABASE=dentebaum; INTEGRATED SECURITY= TRUE;";
        public void Conectar ()
        {
            sqlcon = new SqlConnection(dadosCon);
// evitar fechamento de tela por erro try e catch
            try
            {
                sqlcon.Open();
                Console.WriteLine("conectado");
            }
            catch ( SqlException sqlE)
            {
                Console.WriteLine("ERROR:" + sqlE);
            }

        }
        public void desconectar ()
        {
            sqlcon.Close();
        }
        public int executar(string sql)
        {
            SqlCommand sqlC = new SqlCommand(sql, sqlcon);
             return sqlC.ExecuteNonQuery();
        }
        public SqlDataReader execonsulta(string sql)
        {
            SqlCommand sqlC = new SqlCommand(sql, sqlcon);
            return sqlC.ExecuteReader();
        }
    }
}
