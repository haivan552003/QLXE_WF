using MySql.Data.MySqlClient;
using System.Text;

namespace QLXE_WF
{
    public partial class frmLogin : Form
    {
        //connect mySQL 
        string conStr = "Server=127.0.0.1; database=QLXE_WF; uid=root; psw=";

        MySqlConnection conn;
        MySqlCommand cmd;
        public frmLogin()
        {
            InitializeComponent();
            conn = new MySqlConnection(conStr);
            conn.Open();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            if (string.IsNullOrWhiteSpace(txtAcc.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Not null or white space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAcc.Text = "";
                txtPass.Text = "";
                return;
            }
            try
            {
                cmd.CommandText = "select count(*) from user where Account = '" + txtAcc.Text + "' and Password= '" + txtPass.Text + "'";
                Int64 count = (Int64)cmd.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("Wrong account or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAcc.Text = "";
                    txtPass.Text = "";
                    return;
                }
                else
                {
                    MessageBox.Show("Login with " + txtAcc.Text, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    frmProduct frm = new frmProduct(txtAcc.Text);
                    frm.ShowDialog();
                    return;
                }
            }
            catch
            {
                txtAcc.Text = "";
                txtPass.Text = "";
                MessageBox.Show("Wrong account or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}