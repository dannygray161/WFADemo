
namespace WFADemo
{
    partial class Registration
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
            this.gbCreateUser = new System.Windows.Forms.GroupBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.tbCreateUserName = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbCreatePassword = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.gbCreateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreateUser
            // 
            this.gbCreateUser.Controls.Add(this.tbEmail);
            this.gbCreateUser.Controls.Add(this.lblEmail);
            this.gbCreateUser.Controls.Add(this.lblConfirmPassword);
            this.gbCreateUser.Controls.Add(this.lblCreatePassword);
            this.gbCreateUser.Controls.Add(this.lblUsername);
            this.gbCreateUser.Controls.Add(this.lblLastName);
            this.gbCreateUser.Controls.Add(this.lblFirstname);
            this.gbCreateUser.Controls.Add(this.tbCreateUserName);
            this.gbCreateUser.Controls.Add(this.tbConfirmPassword);
            this.gbCreateUser.Controls.Add(this.tbCreatePassword);
            this.gbCreateUser.Controls.Add(this.tbLastName);
            this.gbCreateUser.Controls.Add(this.tbFirstName);
            this.gbCreateUser.Location = new System.Drawing.Point(138, 39);
            this.gbCreateUser.Name = "gbCreateUser";
            this.gbCreateUser.Size = new System.Drawing.Size(572, 290);
            this.gbCreateUser.TabIndex = 0;
            this.gbCreateUser.TabStop = false;
            this.gbCreateUser.Text = "Create an Account";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(7, 65);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(76, 17);
            this.lblFirstname.TabIndex = 5;
            this.lblFirstname.Text = "First Name";
            // 
            // tbCreateUserName
            // 
            this.tbCreateUserName.Location = new System.Drawing.Point(373, 51);
            this.tbCreateUserName.Name = "tbCreateUserName";
            this.tbCreateUserName.Size = new System.Drawing.Size(165, 22);
            this.tbCreateUserName.TabIndex = 4;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(373, 251);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(184, 22);
            this.tbConfirmPassword.TabIndex = 3;
            // 
            // tbCreatePassword
            // 
            this.tbCreatePassword.Location = new System.Drawing.Point(373, 146);
            this.tbCreatePassword.Name = "tbCreatePassword";
            this.tbCreatePassword.Size = new System.Drawing.Size(184, 22);
            this.tbCreatePassword.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(89, 113);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(151, 22);
            this.tbLastName.TabIndex = 1;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(89, 65);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(151, 22);
            this.tbFirstName.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 117);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(373, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(131, 17);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Create a Username";
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.Location = new System.Drawing.Point(373, 113);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(115, 17);
            this.lblCreatePassword.TabIndex = 8;
            this.lblCreatePassword.Text = "Create Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(373, 214);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(121, 17);
            this.lblConfirmPassword.TabIndex = 9;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(166, 369);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(132, 34);
            this.btnCreateAccount.TabIndex = 1;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(572, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 177);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(58, 177);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(182, 22);
            this.tbEmail.TabIndex = 11;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.gbCreateUser);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.gbCreateUser.ResumeLayout(false);
            this.gbCreateUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreateUser;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox tbCreateUserName;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbCreatePassword;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblCreatePassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}