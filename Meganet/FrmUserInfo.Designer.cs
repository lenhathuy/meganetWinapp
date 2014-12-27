namespace Meganet
{
    partial class FrmUserInfo
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
            this.gpUserInfo = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtFullName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBirthday = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtCurrentPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNewPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRePass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gpUserInfo.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpUserInfo
            // 
            this.gpUserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.gpUserInfo.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpUserInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpUserInfo.Controls.Add(this.dateTimePicker1);
            this.gpUserInfo.Controls.Add(this.rdFemale);
            this.gpUserInfo.Controls.Add(this.rdMale);
            this.gpUserInfo.Controls.Add(this.txtBirthday);
            this.gpUserInfo.Controls.Add(this.txtFullName);
            this.gpUserInfo.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpUserInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpUserInfo.Location = new System.Drawing.Point(12, 23);
            this.gpUserInfo.Name = "gpUserInfo";
            this.gpUserInfo.Size = new System.Drawing.Size(704, 183);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpUserInfo.TabIndex = 0;
            this.gpUserInfo.Text = "User Information";
            // 
            // txtFullName
            // 
            // 
            // 
            // 
            this.txtFullName.Border.Class = "TextBoxBorder";
            this.txtFullName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFullName.Location = new System.Drawing.Point(20, 19);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PreventEnterBeep = true;
            this.txtFullName.Size = new System.Drawing.Size(329, 27);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // txtBirthday
            // 
            // 
            // 
            // 
            this.txtBirthday.Border.Class = "TextBoxBorder";
            this.txtBirthday.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBirthday.Location = new System.Drawing.Point(20, 73);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.PreventEnterBeep = true;
            this.txtBirthday.Size = new System.Drawing.Size(329, 27);
            this.txtBirthday.TabIndex = 1;
            this.txtBirthday.Enter += new System.EventHandler(this.txtBirthday_Enter);
            this.txtBirthday.Leave += new System.EventHandler(this.txtBirthday_Leave);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(52, 120);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(59, 23);
            this.rdMale.TabIndex = 2;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(144, 120);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(77, 23);
            this.rdFemale.TabIndex = 3;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(291, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtRePass);
            this.groupPanel1.Controls.Add(this.txtNewPass);
            this.groupPanel1.Controls.Add(this.txtCurrentPass);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 242);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(704, 205);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Password";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(311, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 32);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            // 
            // txtCurrentPass
            // 
            // 
            // 
            // 
            this.txtCurrentPass.Border.Class = "TextBoxBorder";
            this.txtCurrentPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCurrentPass.Location = new System.Drawing.Point(20, 21);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.PreventEnterBeep = true;
            this.txtCurrentPass.Size = new System.Drawing.Size(329, 27);
            this.txtCurrentPass.TabIndex = 0;
            this.txtCurrentPass.Enter += new System.EventHandler(this.txtCurrentPass_Enter);
            this.txtCurrentPass.Leave += new System.EventHandler(this.txtCurrentPass_Leave);
            // 
            // txtNewPass
            // 
            // 
            // 
            // 
            this.txtNewPass.Border.Class = "TextBoxBorder";
            this.txtNewPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewPass.Location = new System.Drawing.Point(20, 67);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PreventEnterBeep = true;
            this.txtNewPass.Size = new System.Drawing.Size(329, 27);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.Enter += new System.EventHandler(this.txtNewPass_Enter);
            this.txtNewPass.Leave += new System.EventHandler(this.txtNewPass_Leave);
            // 
            // txtRePass
            // 
            // 
            // 
            // 
            this.txtRePass.Border.Class = "TextBoxBorder";
            this.txtRePass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRePass.Location = new System.Drawing.Point(20, 118);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PreventEnterBeep = true;
            this.txtRePass.Size = new System.Drawing.Size(329, 27);
            this.txtRePass.TabIndex = 2;
            this.txtRePass.Enter += new System.EventHandler(this.txtRePass_Enter);
            this.txtRePass.Leave += new System.EventHandler(this.txtRePass_Leave);
            // 
            // FrmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 512);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.gpUserInfo);
            this.Name = "FrmUserInfo";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmUserInfo_Load);
            this.gpUserInfo.ResumeLayout(false);
            this.gpUserInfo.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gpUserInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBirthday;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewPass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFullName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCurrentPass;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRePass;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}