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
    public partial class MainForm : Form
    {
        SqlConnection connection = new SqlConnection("Your Sql Connection");
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTableUpdate();
        }

        public void DataTableUpdate()
        {
            connection.Open();
            string select = "SELECT Accounts.Source, Accounts.Username,Accounts.E_Mail,Accounts.Password FROM Accounts";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            AccountsGridView.DataSource = dataTable;
            connection.Close();

            for (int i = 0; i < AccountsGridView.Columns.Count; i++)
            {
                AccountsGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        #region formMove
        bool isMove;
        int mouse_x;
        int mouse_y;

        private void MainForm_MouseDown(object sender, MouseEventArgs mouse)
        {
            isMove = true;
            mouse_x = mouse.X;
            mouse_y = mouse.Y;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs mouse)
        {
            isMove = false;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs mouse)
        {
            if (isMove)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            AddingForm addingForm = new AddingForm();
            addingForm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Update Button
            DataTableUpdate();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
        }

        //Help button
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can copy values by double clicking on the desired cell.");
        }

        private void AccountsGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int columnindex = AccountsGridView.CurrentCell.ColumnIndex;
            int rowindex = AccountsGridView.CurrentCell.RowIndex;
            string data = AccountsGridView.Rows[rowindex].Cells[columnindex].Value.ToString();
            MessageBox.Show("Copied");


            Clipboard.SetText(data);
        }
    }
}
