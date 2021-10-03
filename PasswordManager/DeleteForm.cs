using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace PasswordManager
{
    public partial class DeleteForm : Form
    {
        SqlConnection connection = new SqlConnection("Your Sql Connection");
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            DataTableUpdate();
            //RowCounter();
        }

        private void RowCounter()
        {
            int num = DeleteDataView.RowCount;
            if (num == 2)
            {
                button1.Enabled = false;
                return;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        public void DataTableUpdate()
        {
            connection.Open();
            string select = "SELECT * FROM Accounts";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DeleteDataView.DataSource = dataTable;
            connection.Close();

            for (int i = 0; i < DeleteDataView.Columns.Count; i++)
            {
                DeleteDataView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        //Exit Button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Delete Button
        private void button1_Click(object sender, EventArgs e)
        {
            //Delete
            
            int rowindex = DeleteDataView.CurrentCell.RowIndex;
            string data = DeleteDataView.Rows[rowindex].Cells[0].Value.ToString();
            if (DeleteDataView.SelectedRows != null)
            {
                string DELETE = "DELETE FROM Accounts WHERE ID = '"+data+"'";
                connection.Open();
                SqlCommand command = new SqlCommand(DELETE,connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Deleted");
            }
            DataTableUpdate();
            //RowCounter();
        }

        //Update button
        private void button3_Click(object sender, EventArgs e)
        {
            DataTableUpdate();
        }

        public void DeleteForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
