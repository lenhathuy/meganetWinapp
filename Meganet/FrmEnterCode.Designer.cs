namespace Meganet
{
    partial class FrmEnterCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEnterCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSignUp = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // txtEnterCode
            // 
            // 
            // 
            // 
            this.txtEnterCode.Border.Class = "TextBoxBorder";
            this.txtEnterCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEnterCode.Location = new System.Drawing.Point(51, 134);
            this.txtEnterCode.Name = "txtEnterCode";
            this.txtEnterCode.PreventEnterBeep = true;
            this.txtEnterCode.Size = new System.Drawing.Size(225, 20);
            this.txtEnterCode.TabIndex = 0;
            this.txtEnterCode.Enter += new System.EventHandler(this.txtEnterCode_Enter);
            this.txtEnterCode.Leave += new System.EventHandler(this.txtEnterCode_Leave);
            // 
            // btnSignUp
            // 
            this.btnSignUp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSignUp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSignUp.Location = new System.Drawing.Point(117, 213);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // FrmEnterCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 452);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtEnterCode);
            this.Name = "FrmEnterCode";
            this.Text = "FrmEnterCode";
            this.Load += new System.EventHandler(this.FrmEnterCode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtEnterCode;
        private DevComponents.DotNetBar.ButtonX btnSignUp;
    }
}