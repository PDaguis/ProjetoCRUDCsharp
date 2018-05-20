using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
            
        }
            PessoaDAL dal = new PessoaDAL();
            Pessoa p = new Pessoa();
        protected void BtnPesquisar(object sender, EventArgs e)
        {
            try
            {

                int codigo = Convert.ToInt32(txtCodigo.Text);
                
                Pessoa p = dal.BuscarPorCodigo(codigo);

                if (p != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = p.Nome;
                    txtEndereco.Text = p.Endereco;
                    txtEmail.Text = p.Email;
                }
                else 
                {
                    lblMensagem.Text = "Pessoa não encontrada !";

                    txtCodigo.Text = string.Empty;
                }

            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
                
            }
        }

        protected void BtnExclui(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                dal.Excluir(codigo);

                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;

                lblMensagem.Text = p.Nome + " excluído(a) com sucesso";
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void BtnAtualiza(object sender, EventArgs e)
        {
            try
            {
                p = new Pessoa();
                p.Codigo =   Convert.ToInt32(txtCodigo.Text);
                p.Nome =     Convert.ToString(txtNome.Text);
                p.Endereco = Convert.ToString(txtEndereco.Text);
                p.Email =    Convert.ToString(txtEmail.Text);

                dal.Atualizar(p);

                lblMensagem.Text = p.Nome + " atualizado(a) com sucesso !";

                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}