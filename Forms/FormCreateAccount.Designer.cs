namespace BudgetTrackingSoftware
{
    partial class FormCreateAccount
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblRptPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRptPass = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.lblUserType = new System.Windows.Forms.Label();
            this.radioCorporate = new System.Windows.Forms.RadioButton();
            this.panelAccountTypes = new System.Windows.Forms.Panel();
            this.panelAccountTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUser.Location = new System.Drawing.Point(42, 41);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPass.Location = new System.Drawing.Point(42, 100);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            // 
            // lblRptPass
            // 
            this.lblRptPass.AutoSize = true;
            this.lblRptPass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblRptPass.Location = new System.Drawing.Point(42, 161);
            this.lblRptPass.Name = "lblRptPass";
            this.lblRptPass.Size = new System.Drawing.Size(91, 13);
            this.lblRptPass.TabIndex = 2;
            this.lblRptPass.Text = "Repeat Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(176, 38);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(176, 97);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtRptPass
            // 
            this.txtRptPass.Location = new System.Drawing.Point(176, 158);
            this.txtRptPass.Name = "txtRptPass";
            this.txtRptPass.Size = new System.Drawing.Size(100, 20);
            this.txtRptPass.TabIndex = 5;
            this.txtRptPass.UseSystemPasswordChar = true;
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(186, 304);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(75, 23);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.BtnSignup_Click);
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Checked = true;
            this.radioUser.Location = new System.Drawing.Point(14, 12);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(47, 17);
            this.radioUser.TabIndex = 7;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "User";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Location = new System.Drawing.Point(14, 35);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioAdmin.TabIndex = 8;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUserType.Location = new System.Drawing.Point(42, 229);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(74, 13);
            this.lblUserType.TabIndex = 9;
            this.lblUserType.Text = "Account Type";
            // 
            // radioCorporate
            // 
            this.radioCorporate.AutoSize = true;
            this.radioCorporate.Location = new System.Drawing.Point(14, 59);
            this.radioCorporate.Name = "radioCorporate";
            this.radioCorporate.Size = new System.Drawing.Size(71, 17);
            this.radioCorporate.TabIndex = 10;
            this.radioCorporate.TabStop = true;
            this.radioCorporate.Text = "Corporate";
            this.radioCorporate.UseVisualStyleBackColor = true;
            // 
            // panelAccountTypes
            // 
            this.panelAccountTypes.Controls.Add(this.radioUser);
            this.panelAccountTypes.Controls.Add(this.radioCorporate);
            this.panelAccountTypes.Controls.Add(this.radioAdmin);
            this.panelAccountTypes.Location = new System.Drawing.Point(162, 198);
            this.panelAccountTypes.Name = "panelAccountTypes";
            this.panelAccountTypes.Size = new System.Drawing.Size(114, 89);
            this.panelAccountTypes.TabIndex = 11;
            // 
            // FormCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(323, 353);
            this.Controls.Add(this.panelAccountTypes);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.txtRptPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblRptPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCreateAccount";
            this.Text = "Create Account";
            this.panelAccountTypes.ResumeLayout(false);
            this.panelAccountTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblRptPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRptPass;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.RadioButton radioCorporate;
        private System.Windows.Forms.Panel panelAccountTypes;
    }
}