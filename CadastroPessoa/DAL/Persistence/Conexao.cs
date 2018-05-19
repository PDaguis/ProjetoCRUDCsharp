using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace DAL.Persistence
{
    public class Conexao 
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader dr;

        protected void AbrirConexao()
        {
            try
            {
                con = new SqlConnection("Data Source=PDAGUIS-PC\\SQLEXPRESS;Initial Catalog=CadastroPessoa;Integrated Security=True");
                con.Open();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        protected void FecharConexao()
        {
            try
            {
                con.Close();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }

    
}
