﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCadastrarPessoa(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.Nome = txtNome.Text;
                p.Endereco = txtEndereco.Text;
                p.Email = txtEmail.Text;

                PessoaDAL dal = new PessoaDAL();
                dal.Inserir(p);

                lblMensagem.Text = "Cadastrado com sucesso!";

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