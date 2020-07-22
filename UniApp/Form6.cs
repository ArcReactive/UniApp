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
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void homeButt_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.ShowDialog();
        }

        private void passform_Click(object sender, EventArgs e)
        {
            PasswordForm passwordForm = new PasswordForm();
            this.Hide();
            passwordForm.ShowDialog();
        }

        private void newuserform_Click(object sender, EventArgs e)
        {
            ConfirmForm cmf = new ConfirmForm();
            this.Hide();
            cmf.ShowDialog();
        }

        private void ChooseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
