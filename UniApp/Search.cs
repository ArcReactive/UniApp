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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm mform2 = new MenuForm();
            mform2.ShowDialog();
        }

        private void searchButt_Click(object sender, EventArgs e)
        {
            try {
                string myConnection = "datasource=localhost;port=3306;username=root;password=nuwan";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from uni.details where stID='" + this.studentidText.Text + "'; ", myConn);
                SelectCommand.ExecuteNonQuery();
                MySqlDataReader dataReader = SelectCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    firstText.Text = (dataReader["FirstYear"].ToString());
                    secondText.Text = (dataReader["SecondYear"].ToString());
                    thirdText.Text = (dataReader["ThirdYear"].ToString());
                }
                myConn.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void clearButt_Click(object sender, EventArgs e)
        {
            studentidText.Text = "";
            firstText.Text = "";
            secondText.Text = "";
            thirdText.Text = "";
        }
    }
}
