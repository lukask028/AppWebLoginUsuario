using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/* Chamando o Cliente do SQL */
using System.Data.SqlClient;
using System.Data;

namespace AppVazioWeb.view
{
    public partial class Default : System.Web.UI.Page
    {
        /* Inicio Configuração SQL Server */
        SqlConnection conexcao = new SqlConnection();/* Criando a conexão */
        SqlCommand comandos = new SqlCommand();/* Executará os comandos */
        SqlDataAdapter adaptadorSql = new SqlDataAdapter(); /* Criação do Adaptador para Conexão */ 
        DataTable tabelaDados = new DataTable(); /* Tabela contendo os Dados */
        DataSet dataSet = new DataSet(); /* Objeto de interação com os dados */
        /* Fim Configuração SQl Server */
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Chave do Connection Strig, Propriedade Cadeia de Caracteres*/
            conexcao.ConnectionString = "Data Source=DESKTOP-4N6NC4B\\SQLEXPRESS;Initial Catalog=escola;Integrated Security=True";
            conexcao.Open();/* Abertura da Conexão com o Connection String */            

        }

        /* CLique do Botao que faz o envio*/
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txbSenha.Text != txbsenhaRepete.Text)
            {
                lblMensagem.Text = " As senhas não Conferem !";
                lblMensagem.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                string email = Convert.ToString(txbEmail.Text);
                tabelaDados = new DataTable();/* Chamada da Tabela de Dados */
                comandos.CommandText = "INSERT INTO aluno(email, senha)VALUES('" + email + "','" + txbSenha.Text.ToString() + "')";
                comandos.Connection = conexcao; /* Execução dos Comandos com conexão */
                comandos.ExecuteNonQuery(); /* Execução da Query INSERT */
                lblMensagem.Text = "Aluno Salvo";
                lblMensagem.BackColor = System.Drawing.Color.Green;
                ExibirDados();
            }
        }

        public void ExibirDados()
        {
            dataSet = new DataSet();/* Recebendo o virá da tabela*/
            comandos.CommandText = "SELECT * FROM aluno WHERE email='"+txbEmail.Text+"'";
            comandos.Connection = conexcao;
            adaptadorSql = new SqlDataAdapter(comandos);
            adaptadorSql.Fill(dataSet);
            comandos.ExecuteNonQuery();
            gdvExibir.DataSource = dataSet;
            gdvExibir.DataBind();
            conexcao.Close();
        }

        protected void btnGoLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}