using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace AppVazioWeb.view
{
    public partial class Perfil : System.Web.UI.Page
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

            VerificarCookie();

        }

        public void VerificarCookie()
        {
            //formata os dados buscados do banco de dados
            dataSet = new DataSet();
            //armazena os dados inserido na label numa variavel cookie
            HttpCookie cookieEmail = Request.Cookies["cookieEmail"];
            lblBemvindo.Text = cookieEmail.Value.ToString();
            lblEmail.Text = cookieEmail.Value.ToString();

            //armazena os dados inserido na label numa variavel cookie
            HttpCookie cookieId = Request.Cookies["cookieID"];
            int id_aluno = Convert.ToInt32(cookieId.Value);
            lblId.Text = cookieId.Value.ToString();

            //faz a busca no banco de dados, onde ha o id correspondente ao valor armazenado no cookieId
            comandos.CommandText = "SELECT * from aluno WHERE id_aluno='"+id_aluno+"'";
            comandos.Connection = conexao;

            //preennche o dataset, com o retorno do comando no sqlDataAdapter, com a execução do comando executeNonQuery
            adaptadorSql = new SqlDataAdapter(comandos);
            adaptadorSql.Fill(dataSet);
            comandos.ExecuteNonQuery();
            SqlDataReader dados = comandos.ExecuteReader();
            


           
        }

        protected void btnCadastrados_Click(object sender, EventArgs e)
        { 
           Response.Redirect("Cadastrados.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}