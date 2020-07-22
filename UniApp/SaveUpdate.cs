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
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();
        }

        private void exitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm mform3 = new MenuForm();
            mform3.ShowDialog();
        }

        private void saveButt_Click(object sender, EventArgs e)
        {

            try {
                string myConnection = "datasource=localhost;port=3306;username=root;password=nuwan";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("insert into uni.details values('" + this.studentIDtext.Text + "','" + this.Ftext.Text + "','" + this.Stext.Text + "','" + this.Ttext.Text + "'); ", myConn);
                SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Saved");
                myConn.Close();
                studentIDtext.Text = "";
                Ftext.Text = "";
                Stext.Text = "";
                Ttext.Text = "";
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void updateButt_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=nuwan";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("update uni.details set FirstYear='"+this.Ftext.Text+"' , SecondYear='"+this.Stext.Text+"' , ThirdYear='"+this.Ttext.Text+"' where stID='"+this.studentIDtext.Text+ "' ; ", myConn);
                SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Updated");
                myConn.Close();
                studentIDtext.Text = "";
                Ftext.Text = "";
                Stext.Text = "";
                Ttext.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
