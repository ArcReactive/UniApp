using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UniApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passwordText.PasswordChar = 'x';
        }

        private void loginButt_Click(object sender, EventArgs e)
        {

            try
            {
                //set path od DB.
                string myConnection = "datasource=localhost;port=3306;username=root;password=nuwan";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                // MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

                myConn.Open();

                string sql = "select * from uni.users where UserName='" + this.usernameText.Text + "' and Password='" + this.passwordText.Text + "'; ";
                MySqlCommand SelectCommand = new MySqlCommand(sql,myConn);
                SelectCommand.ExecuteNonQuery();
                MySqlDataReader dataReader = SelectCommand.ExecuteReader();

                //read the user data.
                while (dataReader.Read())
                {
                    //confirmation.
                    if (usernameText.Text == dataReader[1].ToString() && passwordText.Text == dataReader[2].ToString())
                    {
                        this.Hide();
                        //MessageBox.Show("Correct");
                        MenuForm mform = new MenuForm();
                        mform.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong");
                    }
                    //dataReader.Close();
                }
                usernameText.Text = "";
                passwordText.Text = "";

                myConn.Close();
                
             } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
