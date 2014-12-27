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
    public partial class FrmUserInfo : Form
    {
        public FrmUserInfo()
        {
            InitializeComponent();
        }

      

        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            txtFullName.Text = "Full name...";
            txtBirthday.Text = "Birthday...";
            txtCurrentPass.Text = "Current password...";
            txtNewPass.Text = "New password...";
            txtRePass.Text = "Retype password...";
        }
        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Full name...")
                txtFullName.Text = "";

        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
                txtFullName.Text = "Full name...";
        }

        private void txtBirthday_Enter(object sender, EventArgs e)
        {
            if (txtBirthday.Text == "Birthday...")
                txtBirthday.Text = "";

        }

        private void txtBirthday_Leave(object sender, EventArgs e)
        {
            if (txtBirthday.Text == "")
                txtBirthday.Text = "Birthday...";
        }

        private void txtCurrentPass_Enter(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text == "Current password...")
                txtCurrentPass.Text = "";
        }

        private void txtCurrentPass_Leave(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text == "")
                txtCurrentPass.Text = "Current password...";
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "New password...")
                txtNewPass.Text = "";
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
                txtNewPass.Text = "New password...";
        }

        private void txtRePass_Enter(object sender, EventArgs e)
        {
            if (txtRePass.Text == "Retype password...")
                txtRePass.Text = "";

        }

        private void txtRePass_Leave(object sender, EventArgs e)
        {
            if (txtRePass.Text == "")
                txtRePass.Text = "Retype password...";
        }
    }
}
