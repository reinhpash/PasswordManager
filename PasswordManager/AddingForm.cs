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
    public partial class AddingForm : Form
    {
        private int minumumID;
        private bool sourceTextChange = false, usernTextChange = false, passwordTextChange = false;
        SqlConnection connection = new SqlConnection("Your Sql Connection");
        public AddingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Save data to sql database
            connection.Open();
            //IdentityReset();

            string INSERT = "INSERT INTO Accounts VALUES ('" + source_textBox.Text + "', '" + username_textBox.Text + "', '" + mail_textBox.Text + "','" + password_textBox.Text + "')";
            SqlCommand command = new SqlCommand(INSERT, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Added");
        }

        /*private void IdentityReset()
        {
            string SELECT = "SELECT MIN(Accounts.ID) AS id from Accounts;";
            SqlCommand selectCommand = new SqlCommand(SELECT, connection);

            using (SqlDataReader sdr = selectCommand.ExecuteReader())
            {
                if (!sdr.IsDBNull(0))
                {
                    while (sdr.Read())
                    {
                        minumumID = sdr.GetInt32(0);
                    }
                }

            }
            MessageBox.Show(minumumID.ToString());
            if (minumumID != 1)
            {
                string resetIdentity = "DBCC CHECKIDENT ('Accounts', RESEED, 0)";
                SqlCommand ResetCommand = new SqlCommand(resetIdentity, connection);
                ResetCommand.ExecuteNonQuery();
            }
        }*/

        private void AddingForm_Load(object sender, EventArgs e)
        {
            if (source_textBox.Text == "" && username_textBox.Text == "" && password_textBox.Text == "")
            {
                SaveButton.Enabled = false;
            }
        }

        private void source_textBox_TextChanged(object sender, EventArgs e)
        {
            sourceTextChange = true;
            if (sourceTextChange == true & usernTextChange == true && passwordTextChange == true)
            {
                SaveButton.Enabled = true;
            }
        }

        private void username_textBox_TextChanged(object sender, EventArgs e)
        {
            usernTextChange = true;
            if (sourceTextChange == true & usernTextChange == true && passwordTextChange == true)
            {
                SaveButton.Enabled = true;
            }
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextChange = true;
            if (sourceTextChange == true & usernTextChange == true && passwordTextChange == true)
            {
                SaveButton.Enabled = true;
            }
            
        }
    }
}
