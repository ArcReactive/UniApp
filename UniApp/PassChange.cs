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
    public partial class PasswordForm : Form
    {
        int count = 0;
        public PasswordForm()
        {
            InitializeComponent();
            currentpassText.PasswordChar = 'x';
            newpassText.PasswordChar = 'x';
            conpassText.PasswordChar = 'x';
        }

        private void exitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButt_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.ShowDialog();
                
        }

        private void updatepass()
        {
                string myConnection = "datasource=localhost;port=3306;username=root;password=nuwan";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("update uni.users set Password='" + conpassText.Text + "' where UserName = '" + usernameText.Text + "';", myConn);
                SelectCommand.ExecuteNonQuery();

        }

        private void savepassButt_Click(object sender, EventArgs e)
        {
            try {
                
                
                string myConnection = "datasource=localhost;port=3306;username=root;password=nuwan";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from uni.users where UserName='" + this.usernameText.Text + "' and Password='" + this.currentpassText.Text + "'; ", myConn);
                SelectCommand.ExecuteNonQuery();
                MySqlDataReader dataReader = SelectCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (usernameText.Text == dataReader[1].ToString() && currentpassText.Text == dataReader[2].ToString())
                    {
                        updatepass();
                        MessageBox.Show("Done Update Your Password");
                        count = 1;
                    }
                }
                if(count!=1)
                {
                    MessageBox.Show("Wrong Password OR User Name");
                }

                myConn.Close();
                
                usernameText.Text = "";
                currentpassText.Text = "";
                newpassText.Text = "";
                conpassText.Text = "";
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
