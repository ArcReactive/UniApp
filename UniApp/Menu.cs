using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm sform = new SearchForm();
            sform.ShowDialog();
        }

        private void saveForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaveForm sform = new SaveForm();
            sform.ShowDialog();
        }

        private void settingForm_Click(object sender, EventArgs e)
        {
            ChooseForm chooseForm = new ChooseForm();
            this.Hide();
            chooseForm.ShowDialog();
        }
    }
}
