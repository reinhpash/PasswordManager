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

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        private bool firstRun;

        const string REGISTRY_KEY = @"HKEY_CURRENT_USER\PasswordManager";
        const string REGISTY_VALUE = "FirstRun";
        private string realMasterPassword;
        private string decryptedKey;
        int encryptKey = 5;
        



        SqlConnection connection = new SqlConnection("Your Sql Connection");
        public Form1()
        {
            InitializeComponent();

            //When the program starts we create firstRun registry
            //If firstrun registry value = 0 than firstRun = true and we can make a new master password
            //New master password is gonna be equal the first record on the database
            //else we can log in the program with the first record on the database

            if (Convert.ToInt32(Microsoft.Win32.Registry.GetValue(REGISTRY_KEY, REGISTY_VALUE, 0)) == 0)
            {
                firstRun = true;
                //Change the value since the program has run once now
                Microsoft.Win32.Registry.SetValue(REGISTRY_KEY, REGISTY_VALUE, 1, Microsoft.Win32.RegistryValueKind.DWord);
            }
            else
            {
                firstRun = false;
            }
        }

        //Exit button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimize button
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #region //Move the form according to mouse movement
        bool isMove;
        int mouse_x;
        int mouse_y;
        private void Form1_MouseDown(object sender, MouseEventArgs mouse)
        {
            isMove = true;
            mouse_x = mouse.X;
            mouse_y = mouse.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs mouse)
        {
            isMove = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs mouse)
        {
            if (isMove)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }

        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            if (firstRun == true)
            {
                //Creating the master password
                CreateMasterPassword();
            }
            else
            {
                MasterPasswordReader();
                
                if (decryptedKey != masterPassword_textBox.Text)
                {
                    MessageBox.Show("fuck u");
                }
                else
                {
                    //Logged in show password form
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }

                
            }

        }

        private void CreateMasterPassword()
        {
            string masterPassword = masterPassword_textBox.Text;
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into MasterPassword_Table (MasterPassword) VALUES ('" + Cryptology.Encryption(masterPassword_textBox.Text, encryptKey) + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Master password saved Please restart the app");
        }

        private void MasterPasswordReader()
        {
            string masterPassword = masterPassword_textBox.Text;
            string oString = "SELECT TOP 1 MasterPassword from MasterPassword_Table";
            SqlCommand command = new SqlCommand(oString, connection);
            connection.Open();

            using (SqlDataReader sqlDataReader = command.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    realMasterPassword =  sqlDataReader["MasterPassword"].ToString();
                    
                }
                decryptedKey = Cryptology.Decryption(realMasterPassword,encryptKey);
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (firstRun == true)
            {
                MessageBox.Show("This is your first run enter the master password and click 'Enter' button");
            }
        }

        private void masterPassword_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter_button.PerformClick();
            }
        }
    }
}
