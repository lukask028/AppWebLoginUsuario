using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/* Biliotecas SQL */
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace AppVazioWeb.view
{
    public partial class Login : System.Web.UI.Page
    {
        /* Inicio Configuração */
        SqlConnection conexao = new SqlConnection();
        SqlCommand comandos = new SqlCommand();
        SqlDataAdapter adaptadorSql = new SqlDataAdapter();
        DataTable tabelaDados = new DataTable();
        DataSet dataSet = new DataSet();
        /* Final Configuração */
        protected void Page_Load(object sender, EventArgs e)
        {
            conexao.ConnectionString = "Data Source=DESKTOP-4N6NC4B\\SQLEXPRESS;Initial Catalog=escola;Integrated Security=True";
            conexao.Open();
        }

        public void checarUsuario()
        {
            dataSet = new DataSet();
            comandos.CommandText = "SELECT * FROM aluno WHERE email='"+txbEmail.Text+"' AND senha='"+txbSenha.Text+"' ";
            comandos.Connection = conexao;
            adaptadorSql = new SqlDataAdapter(comandos);
            adaptadorSql.Fill(dataSet);
            comandos.ExecuteNonQuery();
            /* Carregar o conteudo em um objeto*/
            SqlDataReader dados = comandos.ExecuteReader();
            /* dados["id_aluno"], dados["email"] e dados["senha"] */
            if (dados.HasRows) /* dados.Length > 0 */
            {
                dados.Read(); /* Faz a Leitura do que recebeu em dados */
                string dadosEmail = dados["email"].ToString();
                string dadosId = dados["id_aluno"].ToString();

                /* Cria o cookie com os dados do email do banco */
                HttpCookie cookieEmail = new HttpCookie("cookieEmail", dadosEmail);
                Response.Cookies.Add(cookieEmail);/* Adiciona o cookie a seção */

                /* Cria o cookie com o id_aluno do banco */
                HttpCookie cookieID = new HttpCookie("cookieID", dadosId);
                Response.Cookies.Add(cookieID);/* Adiciona o Cokkie a Seção */


                lblMensagem.Text = "Login Bem sucedido!"+ dadosEmail + "id:"+ dadosId;

                Response.Redirect("Perfil.aspx");
            }
            else
            {
                lblMensagem.Text = "E-mail ou Senha Inválidos!";
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            checarUsuario();
        }
    }
}