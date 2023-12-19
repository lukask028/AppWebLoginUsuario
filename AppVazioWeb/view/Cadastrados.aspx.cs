using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.EnterpriseServices;

namespace AppVazioWeb.view
{
    public partial class Cadastrados : System.Web.UI.Page
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

            /*cria a estrutura da tabela*/
            /* dataSet = new DataSet();
             comandos.CommandText = " SELECT * FROM aluno ";
             comandos.Connection = conexcao;
             adaptadorSql = new SqlDataAdapter(comandos);
             adaptadorSql.Fill(dataSet); /* Recebendo o virá da tabela do bd, na estrutura*/

            /*gdvExibir.DataSource = dataSet;
            comandos.ExecuteNonQuery();
            gdvExibir.DataBind();*/
            /*conexcao.Close();*/

            dataShow();

            conexcao.Close();

        }

        protected void btnReload_Click(object sender, EventArgs e)
        {
            dataShow();
        }


        public void dataShow()
        {
            
            /*cria a estrutura da tabela*/
            dataSet = new DataSet();
            
            comandos.CommandText = " SELECT * FROM aluno ";
            comandos.Connection = conexcao;
            adaptadorSql = new SqlDataAdapter(comandos);
            adaptadorSql.Fill(dataSet); /* Recebendo o virá da tabela do bd, na estrutura*/

            comandos.ExecuteNonQuery();
            gdvExibir.DataSource = dataSet;
            gdvExibir.DataBind();
            conexcao.Close();
        }
        protected void btnDeleteId_Click(object sender, EventArgs e)
        {

            // recebe o id do registro que sera deletado 
            int idDetelar = Convert.ToInt32(txtIdDeletar.Text);
            conexcao.Open();
            /*tabelaDados = new DataTable();*/
            comandos.CommandText = "DELETE FROM aluno WHERE id_aluno='" + idDetelar + "'";
            comandos.Connection = conexcao;
            comandos.ExecuteNonQuery();

            lblMensagem.Text = "Registro apagado";
            lblMensagem.BackColor = System.Drawing.Color.Red;
            lblMensagem.ForeColor = System.Drawing.Color.White;
            dataShow();
            

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}