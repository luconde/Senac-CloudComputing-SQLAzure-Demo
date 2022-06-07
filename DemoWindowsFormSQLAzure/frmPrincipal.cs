using System.Data;
using System.Data.SqlClient;

namespace DemoWindowsFormSQLAzure
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            string strConexao = txtConnectionString.Text;

            SqlConnection objConexao = new SqlConnection(strConexao);
            objConexao.Open();  

            SqlCommand objCmd = new SqlCommand("SELECT * FROM CLIENTE", objConexao);

            SqlDataAdapter objDa = new SqlDataAdapter(objCmd);

            DataTable objDt = new DataTable();

            objDa.Fill(objDt);

            dataGrid.DataSource = objDt;
        }
    }
}