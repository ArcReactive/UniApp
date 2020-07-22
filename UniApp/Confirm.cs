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
    public partial class ConfirmForm : Form
    {
        public ConfirmForm()
        {
            InitializeComponent();
            passWord.PasswordChar = 'x';
        }

        private void Home_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.ShowDialog();
        }

        private void ConfirmButt_Click(object sender, EventArgs e)
        {
            try
            {

                string myConnection = "datasource=localhost;port=3306;username=root;password=nuwan";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                // MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from uni.users where UserName='" + this.userName.Text + "' and Password='" + this.passWord.Text + "'; ", myConn);
                SelectCommand.ExecuteNonQuery();
                MySqlDataReader dataReader = SelectCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (userName.Text == dataReader[1].ToString() && passWord.Text == dataReader[2].ToString())
                    {
                        this.Hide();
                        //MessageBox.Show("Correct");
                        NewUserForm nwu = new NewUserForm();
                        nwu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong");
                    }
                    //dataReader.Close();
                }
                userName.Text = "";
                passWord.Text = "";

                myConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
