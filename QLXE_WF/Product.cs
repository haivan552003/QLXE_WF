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
    public partial class frmProduct : Form
    {

        //connect mySQL 
        string conStr = "Server=127.0.0.1; database=QLXE_WF; uid=root; psw=";

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlCommand cmdID_User;
        MySqlCommand cmdID_Product;
        MySqlDataAdapter Adapter = new MySqlDataAdapter();
        DataTable dtTable = new DataTable();
        public frmProduct(string UserName)
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

        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select ID_P as 'ID Product', ProcductName as 'Name', Price, Description, ID_U as 'ID User' from product";
            Adapter.SelectCommand = cmd;
            dtTable.Clear();
            Adapter.Fill(dtTable);
            dvProduct.DataSource = dtTable;
        }

        void ClearField()
        {
            txtDes.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dvProduct.SelectedRows)
            {
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[2].Value.ToString();
                txtDes.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmdID_User = conn.CreateCommand();
            cmdID_Product = conn.CreateCommand();
            cmd = conn.CreateCommand();

            //want auto add ID_U
            cmdID_User.CommandText = "select ID_U from user where Account = '" + lblUserName.Text + "'";
            object IDUser = cmdID_User.ExecuteScalar();
            string ID_User = IDUser.ToString();

            //check ID duplicate
            cmdID_Product.CommandText = "select ID_P from product where ID_P = '" + txtID.Text + "'";
            object IDProduct = cmdID_Product.ExecuteScalar();
            if (IDProduct != null)
            {
                string ID_Product = IDProduct.ToString();
                if (ID_Product == txtID.Text)
                {
                    MessageBox.Show("ID dupplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //check null
            if (string.IsNullOrWhiteSpace(txtDes.Text) ||
                string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Not null or white space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            //check ID not int
            if (!int.TryParse(txtID.Text, out int idValue) ||
                !float.TryParse(txtPrice.Text, out float Price))
            {
                MessageBox.Show("ID and price is number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                cmd.CommandText = "insert into product values(" + txtID.Text + ", '" + txtName.Text + "', " + txtPrice.Text + ", '" + txtDes.Text + "', " + ID_User + ")";
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
            cmdID_User.CommandText = "select ID_P from product where ID_P = '" + txtID.Text + "'";
            object IDProduct = cmdID_User.ExecuteScalar();
            if (IDProduct == null)
            {
                MessageBox.Show("ID doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check null
            if (string.IsNullOrWhiteSpace(txtDes.Text) ||
                string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Not null or white space", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check price not int
            if (!float.TryParse(txtPrice.Text, out float Price))
            {
                MessageBox.Show("Price is number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                cmd.CommandText = "update product set ProcductName = '" + txtName.Text + "',Price = " + txtPrice.Text + ",Description = '" + txtDes.Text + "', ID_U = " + ID_User + " where ID_P = '" + txtID.Text + "'";
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
                cmd.CommandText = "delete from product where ID_P = '" + txtID.Text + "'";
                int resualt = (int)cmd.ExecuteNonQuery();

                if (resualt > 0)
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
            catch (Exception ex)
            {
                MessageBox.Show("Choose product, please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
