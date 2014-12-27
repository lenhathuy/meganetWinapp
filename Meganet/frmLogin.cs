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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, System.EventArgs e)
        {
           // if(txtEmail.Focus())
           // txtEmail.Text = String.Empty;
     

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "Email...";
            txtPassword.Text = "Password...";
          
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email...")
            {
                txtEmail.Text = "";
            }
           
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email...";
            }
           
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password...")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password...";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEnterCode f2= new FrmEnterCode();
            f2.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != null && txtPassword.Text != null && txtEmail.Text == "Email..." && txtPassword.Text == "Password...")
            {
                MessageBox.Show("Nhap lai Email và Password");
            }
            else
            {
                this.Hide();
                FrmUserInfo f2 = new FrmUserInfo();
                f2.ShowDialog();
                this.Show();
            }
        }


    }
}
