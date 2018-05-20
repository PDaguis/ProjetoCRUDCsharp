using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class PessoaDAL : Conexao
    {
        public void Inserir(Pessoa p)
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("[dbo].[InserirPessoa]", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nome", p.Nome);
                cmd.Parameters.AddWithValue("@Endereco", p.Endereco);
                cmd.Parameters.AddWithValue("@Email", p.Email); 
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {

                throw new Exception("ERRO AO CADASTRAR " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("AlterarPessoa", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nome", p.Nome);
                cmd.Parameters.AddWithValue("@Endereco", p.Endereco);
                cmd.Parameters.AddWithValue("@Email", p.Email);
                cmd.Parameters.AddWithValue("@Codigo", p.Codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("ERRO AO ATUALIZAR" + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("ExcluirPessoa", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("ERRO AO EXCLUIR" + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Pessoa BuscarPorCodigo(int codigo)
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("[dbo].[BuscarPorCodigo]", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                dr = cmd.ExecuteReader();// executa a leitura das informações do BD

                Pessoa p = null;

                if (dr.Read())
                {
                    p = new Pessoa();
                    p.Nome = Convert.ToString(dr["nome"]);
                    p.Endereco = Convert.ToString(dr["endereco"]);
                    p.Email = Convert.ToString(dr["email"]);
                }
                return p;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Pessoa> ListaPessoas()
        {
            try
            {
                AbrirConexao();
                cmd = new SqlCommand("BuscarTodasPessoas", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();
                while (dr.Read())
                {
                    Pessoa p = new Pessoa();
                    p.Codigo = Convert.ToInt32(dr["codigo"]);
                    p.Nome = Convert.ToString(dr["nome"]);
                    p.Endereco = Convert.ToString(dr["endereco"]);
                    p.Email = Convert.ToString(dr["email"]);

                    lista.Add(p);

                }
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
