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
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PessoaDAL dal = new PessoaDAL();
                gridPessoa.DataSource = dal.ListaPessoas();// POPULAR O GRID
                gridPessoa.DataBind();//MOSTRA OS DADOS DA CONSULTA NA GRID
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}