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
    public partial class FrmEnterCode : Form
    {
        public FrmEnterCode()
        {
            InitializeComponent();
        }

        private void FrmEnterCode_Load(object sender, EventArgs e)
        {
            txtEnterCode.Text = "Enter pack code...";
        }

        private void txtEnterCode_Enter(object sender, EventArgs e)
        {
            if (txtEnterCode.Text == "Enter pack code...")
                txtEnterCode.Text = "";
        }

        private void txtEnterCode_Leave(object sender, EventArgs e)
        {
            if (txtEnterCode.Text == "")
                txtEnterCode.Text = "Enter pack code...";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtEnterCode.Text == "Enter pack code...")
            {
                MessageBox.Show("Chua nhap code");
            }
            else
            {
                this.Hide();
                FrmRegister f2 = new FrmRegister();
                f2.ShowDialog();
                this.Show();
            }
           
        }
    }
}
