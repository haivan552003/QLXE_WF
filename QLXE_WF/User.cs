using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXE_WF
{
    public partial class frmUser : Form
    {
        //connect mySQL 
        string conStr = "Server=127.0.0.1; database=QLXE_WF; uid=root; psw=";

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlCommand cmdID_User;
        MySqlCommand cmdID_Acc;
        MySqlDataAdapter Adapter = new MySqlDataAdapter();
        DataTable dtTable = new DataTable();
        public frmUser(string UserName)
        {
            InitializeComponent();
            conn = new MySqlConnection(conStr);
            conn.Open();
            lblUserName.Text = UserName;
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct(lblUserName.Text);
            frmProduct.ShowDialog();
            Hide();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser(lblUserName.Text);
            frmUser.ShowDialog();
            Hide();
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select ID_U as 'ID User', Name, Age, Account, Password from user";
            Adapter.SelectCommand = cmd;
            dtTable.Clear();
            Adapter.Fill(dtTable);
            dvProduct.DataSource = dtTable;
        }

        void ClearField()
        {
            txtAcc.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtPass.Text = "";
        }
        private void dvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dvProduct.SelectedRows)
            {
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAge.Text = row.Cells[2].Value.ToString();
                txtAcc.Text = row.Cells[3].Value.ToString();
                txtPass.Text = row.Cells[4].Value.ToString();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmdID_User = conn.CreateCommand();
            cmdID_Acc = conn.CreateCommand();
            cmd = conn.CreateCommand();

            //check ID duplicate
            cmdID_User.CommandText = "select ID_U from user where ID_U = '" + txtID.Text + "'";
            object cmdIDUser = cmdID_User.ExecuteScalar();
            if (cmdIDUser != null)
            {
                string cmdID_User = cmdIDUser.ToString();
                if (cmdID_User == txtID.Text)
                {
                    MessageBox.Show("ID dupplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //check Account duplicate
            cmdID_Acc.CommandText = "select Account from user where Account = '" + txtAcc.Text + "'";
            object cmdIDAcc = cmdID_Acc.ExecuteScalar();
            if (cmdIDAcc != null)
            {
                string cmdID_Acc = cmdIDAcc.ToString();
                if (cmdID_Acc == txtAcc.Text)
                {
                    MessageBox.Show("Account dupplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //check null
            if (string.IsNullOrWhiteSpace(txtAcc.Text) ||
                string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Not null or white space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check ID not int
            if (!int.TryParse(txtID.Text, out int idValue) ||
                !float.TryParse(txtAge.Text, out float Price))
            {
                MessageBox.Show("ID and age is number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                cmd.CommandText = "insert into user values(" + txtID.Text + ", '" + txtName.Text + "', " + txtAge.Text + ", '" + txtAcc.Text + "', '" + txtPass.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearField();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmdID_User = conn.CreateCommand();
            cmd = conn.CreateCommand();

            cmdID_User.CommandText = "select ID_U from user where Account = '" + lblUserName.Text + "'";
            object IDUser = cmdID_User.ExecuteScalar();
            string ID_User = IDUser.ToString();

            //check ID when user want add but click update
            cmdID_User.CommandText = "select ID_U from product where ID_U = '" + txtID.Text + "'";
            object cmdIDUser = cmdID_User.ExecuteScalar();
            if (cmdIDUser == null)
            {
                MessageBox.Show("ID doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check null
            if (string.IsNullOrWhiteSpace(txtAcc.Text) ||
                string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Not null or white space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check ID, age not int
            if (!int.TryParse(txtID.Text, out int ID) ||
                !int.TryParse(txtAge.Text, out int Age))
            {
                MessageBox.Show("ID and age is number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                cmd.CommandText = "update user set Name = '" + txtName.Text + "', Age = " + txtAge.Text + ", Password = " + txtPass.Text + " where ID_U = '" + txtID.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearField();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from user where ID_U = '" + txtID.Text + "'";
                int count = (int)cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Successful", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Fail, because this ID is foreign key in table product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
