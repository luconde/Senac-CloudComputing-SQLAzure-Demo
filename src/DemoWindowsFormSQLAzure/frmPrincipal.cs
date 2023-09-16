using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DemoWindowsFormSQLAzure
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carregar os dados do banco de dados
        /// A implementação do código está simples apenas para propósito de demonstração
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLoad_Click(object sender, EventArgs e)
        {
            string strConexao = txtConnectionString.Text;

            SqlConnection objConexao = new SqlConnection(strConexao);
            objConexao.Open();

            StringBuilder objSb = new StringBuilder("SELECT * FROM ");
            objSb.Append(txtNomeDaTabela.Text);

            SqlCommand objCmd = new SqlCommand(objSb.ToString(), objConexao);

            SqlDataAdapter objDa = new SqlDataAdapter(objCmd);

            DataTable objDt = new DataTable();

            objDa.Fill(objDt);

            dataGrid.DataSource = objDt;
        }
    }
}