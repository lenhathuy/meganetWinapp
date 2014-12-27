using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meganet
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "Email...";
            txtPass.Text = "Password...";
            txtRePass.Text = "Retype password...";

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email...")
                txtEmail.Text = "";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
                txtEmail.Text = "Email...";
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password...")
                txtPass.Text = "";
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
                txtPass.Text = "Password...";
        }
        private void txtRePass_Enter(object sender, EventArgs e)
        {
            if (txtRePass.Text == "Retype password...")
                txtRePass.Text = "";
        }
        private void txtRePass_Leave(object sender, EventArgs e)
        {
            if (txtRePass.Text =="")
                txtRePass.Text = "Retype password...";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success");
        }

       
    }
}
