using System;
using System.Windows.Forms;

namespace LibSysMan
{
    partial class LoginUsers
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
            this.LineAdmin = new System.Windows.Forms.Panel();
            this.ContainerPassword = new System.Windows.Forms.Panel();
            this.TextBoxGroupUserPassword = new System.Windows.Forms.Panel();
            this.TextBoxLoginUserPassword = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.Label();
            this.ContainerLogin = new System.Windows.Forms.Panel();
            this.TextBoxGroupUser = new System.Windows.Forms.Panel();
            this.TextBoxLoginUser = new System.Windows.Forms.TextBox();
            this.IDText = new System.Windows.Forms.Label();
            this.ContainerOutsideTitle = new System.Windows.Forms.Panel();
            this.ContainerInsideTitle = new System.Windows.Forms.Panel();
            this.AdminButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserLoginButton = new System.Windows.Forms.Button();
            this.ForgetBTNtxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SignUpNowBTNtxt = new System.Windows.Forms.Label();
            this.GroupBoxUserBTN = new System.Windows.Forms.Panel();
            this.UserLogoutPageBTN = new System.Windows.Forms.Button();
            this.UserLoginPageBTN = new System.Windows.Forms.Button();
            this.ContainerPassword.SuspendLayout();
            this.TextBoxGroupUserPassword.SuspendLayout();
            this.ContainerLogin.SuspendLayout();
            this.TextBoxGroupUser.SuspendLayout();
            this.ContainerOutsideTitle.SuspendLayout();
            this.ContainerInsideTitle.SuspendLayout();
            this.GroupBoxUserBTN.SuspendLayout();
            this.SuspendLayout();
            // 
            // LineAdmin
            // 
            this.LineAdmin.BackColor = System.Drawing.Color.Gray;
            this.LineAdmin.Location = new System.Drawing.Point(12, 553);
            this.LineAdmin.Name = "LineAdmin";
            this.LineAdmin.Size = new System.Drawing.Size(540, 1);
            this.LineAdmin.TabIndex = 15;
            // 
            // ContainerPassword
            // 
            this.ContainerPassword.BackColor = System.Drawing.Color.Transparent;
            this.ContainerPassword.Controls.Add(this.TextBoxGroupUserPassword);
            this.ContainerPassword.Controls.Add(this.PasswordText);
            this.ContainerPassword.Location = new System.Drawing.Point(12, 380);
            this.ContainerPassword.Name = "ContainerPassword";
            this.ContainerPassword.Size = new System.Drawing.Size(540, 108);
            this.ContainerPassword.TabIndex = 14;
            // 
            // TextBoxGroupUserPassword
            // 
            this.TextBoxGroupUserPassword.Controls.Add(this.TextBoxLoginUserPassword);
            this.TextBoxGroupUserPassword.Location = new System.Drawing.Point(0, 36);
            this.TextBoxGroupUserPassword.Name = "TextBoxGroupUserPassword";
            this.TextBoxGroupUserPassword.Size = new System.Drawing.Size(540, 72);
            this.TextBoxGroupUserPassword.TabIndex = 1;
            this.TextBoxGroupUserPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBoxGroupUserPassword_Paint);
            // 
            // TextBoxLoginUserPassword
            // 
            this.TextBoxLoginUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.TextBoxLoginUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLoginUserPassword.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLoginUserPassword.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxLoginUserPassword.Location = new System.Drawing.Point(26, 21);
            this.TextBoxLoginUserPassword.Name = "TextBoxLoginUserPassword";
            this.TextBoxLoginUserPassword.Size = new System.Drawing.Size(486, 39);
            this.TextBoxLoginUserPassword.TabIndex = 0;
            this.TextBoxLoginUserPassword.Text = "Enter User Password";
            this.TextBoxLoginUserPassword.TextChanged += new System.EventHandler(this.TextBoxLoginUserPassword_TextChanged);
            this.TextBoxLoginUserPassword.Enter += new System.EventHandler(this.TextBoxUserPassword_Enter);
            this.TextBoxLoginUserPassword.Leave += new System.EventHandler(this.TextBoxUserPassword_Leave);
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.ForeColor = System.Drawing.Color.White;
            this.PasswordText.Location = new System.Drawing.Point(0, 0);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(143, 33);
            this.PasswordText.TabIndex = 0;
            this.PasswordText.Text = "Password";
            // 
            // ContainerLogin
            // 
            this.ContainerLogin.BackColor = System.Drawing.Color.Transparent;
            this.ContainerLogin.Controls.Add(this.TextBoxGroupUser);
            this.ContainerLogin.Controls.Add(this.IDText);
            this.ContainerLogin.Location = new System.Drawing.Point(12, 244);
            this.ContainerLogin.Name = "ContainerLogin";
            this.ContainerLogin.Size = new System.Drawing.Size(540, 108);
            this.ContainerLogin.TabIndex = 13;
            // 
            // TextBoxGroupUser
            // 
            this.TextBoxGroupUser.Controls.Add(this.TextBoxLoginUser);
            this.TextBoxGroupUser.Location = new System.Drawing.Point(0, 36);
            this.TextBoxGroupUser.Name = "TextBoxGroupUser";
            this.TextBoxGroupUser.Size = new System.Drawing.Size(540, 72);
            this.TextBoxGroupUser.TabIndex = 1;
            this.TextBoxGroupUser.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBoxGroupUser_Paint);
            // 
            // TextBoxLoginUser
            // 
            this.TextBoxLoginUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.TextBoxLoginUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLoginUser.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLoginUser.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxLoginUser.Location = new System.Drawing.Point(26, 21);
            this.TextBoxLoginUser.Name = "TextBoxLoginUser";
            this.TextBoxLoginUser.Size = new System.Drawing.Size(486, 39);
            this.TextBoxLoginUser.TabIndex = 0;
            this.TextBoxLoginUser.Text = "Enter User ID";
            this.TextBoxLoginUser.TextChanged += new System.EventHandler(this.TextBoxLoginUser_TextChanged);
            this.TextBoxLoginUser.Enter += new System.EventHandler(this.TextBoxUser_Enter);
            this.TextBoxLoginUser.Leave += new System.EventHandler(this.TextBoxUser_Leave);
            // 
            // IDText
            // 
            this.IDText.AutoSize = true;
            this.IDText.Dock = System.Windows.Forms.DockStyle.Top;
            this.IDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDText.ForeColor = System.Drawing.Color.White;
            this.IDText.Location = new System.Drawing.Point(0, 0);
            this.IDText.Margin = new System.Windows.Forms.Padding(0);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(44, 33);
            this.IDText.TabIndex = 0;
            this.IDText.Text = "ID";
            // 
            // ContainerOutsideTitle
            // 
            this.ContainerOutsideTitle.BackColor = System.Drawing.Color.White;
            this.ContainerOutsideTitle.Controls.Add(this.ContainerInsideTitle);
            this.ContainerOutsideTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContainerOutsideTitle.Location = new System.Drawing.Point(0, 0);
            this.ContainerOutsideTitle.Name = "ContainerOutsideTitle";
            this.ContainerOutsideTitle.Size = new System.Drawing.Size(1424, 129);
            this.ContainerOutsideTitle.TabIndex = 11;
            // 
            // ContainerInsideTitle
            // 
            this.ContainerInsideTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ContainerInsideTitle.Controls.Add(this.AdminButton);
            this.ContainerInsideTitle.Controls.Add(this.label1);
            this.ContainerInsideTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContainerInsideTitle.Location = new System.Drawing.Point(0, 18);
            this.ContainerInsideTitle.Name = "ContainerInsideTitle";
            this.ContainerInsideTitle.Size = new System.Drawing.Size(1424, 111);
            this.ContainerInsideTitle.TabIndex = 1;
            // 
            // AdminButton
            // 
            this.AdminButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AdminButton.FlatAppearance.BorderSize = 0;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.ForeColor = System.Drawing.Color.White;
            this.AdminButton.Location = new System.Drawing.Point(1290, 36);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(100, 46);
            this.AdminButton.TabIndex = 1;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRARY SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserLoginButton
            // 
            this.UserLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.UserLoginButton.FlatAppearance.BorderSize = 0;
            this.UserLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserLoginButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLoginButton.ForeColor = System.Drawing.Color.White;
            this.UserLoginButton.Location = new System.Drawing.Point(12, 577);
            this.UserLoginButton.Name = "UserLoginButton";
            this.UserLoginButton.Size = new System.Drawing.Size(540, 91);
            this.UserLoginButton.TabIndex = 2;
            this.UserLoginButton.Text = "Login";
            this.UserLoginButton.UseVisualStyleBackColor = false;
            this.UserLoginButton.Click += new System.EventHandler(this.UserLoginButton_Click);
            // 
            // ForgetBTNtxt
            // 
            this.ForgetBTNtxt.AutoSize = true;
            this.ForgetBTNtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetBTNtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(140)))), ((int)(((byte)(233)))));
            this.ForgetBTNtxt.Location = new System.Drawing.Point(12, 508);
            this.ForgetBTNtxt.Name = "ForgetBTNtxt";
            this.ForgetBTNtxt.Size = new System.Drawing.Size(112, 25);
            this.ForgetBTNtxt.TabIndex = 16;
            this.ForgetBTNtxt.Text = "Forget ID?";
            this.ForgetBTNtxt.Click += new System.EventHandler(this.ForgetBTNtxt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 694);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Not a member?";
            // 
            // SignUpNowBTNtxt
            // 
            this.SignUpNowBTNtxt.AutoSize = true;
            this.SignUpNowBTNtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpNowBTNtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(140)))), ((int)(((byte)(233)))));
            this.SignUpNowBTNtxt.Location = new System.Drawing.Point(183, 692);
            this.SignUpNowBTNtxt.Name = "SignUpNowBTNtxt";
            this.SignUpNowBTNtxt.Size = new System.Drawing.Size(182, 33);
            this.SignUpNowBTNtxt.TabIndex = 18;
            this.SignUpNowBTNtxt.Text = " Sign up now";
            this.SignUpNowBTNtxt.Click += new System.EventHandler(this.SignUpNowBTNtxt_Click);
            // 
            // GroupBoxUserBTN
            // 
            this.GroupBoxUserBTN.Controls.Add(this.UserLogoutPageBTN);
            this.GroupBoxUserBTN.Controls.Add(this.UserLoginPageBTN);
            this.GroupBoxUserBTN.Location = new System.Drawing.Point(82, 155);
            this.GroupBoxUserBTN.Name = "GroupBoxUserBTN";
            this.GroupBoxUserBTN.Size = new System.Drawing.Size(400, 64);
            this.GroupBoxUserBTN.TabIndex = 19;
            this.GroupBoxUserBTN.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupBoxUserBTN_Paint);
            // 
            // UserLogoutPageBTN
            // 
            this.UserLogoutPageBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLogoutPageBTN.BackColor = System.Drawing.Color.Transparent;
            this.UserLogoutPageBTN.FlatAppearance.BorderSize = 0;
            this.UserLogoutPageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserLogoutPageBTN.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogoutPageBTN.ForeColor = System.Drawing.Color.White;
            this.UserLogoutPageBTN.Location = new System.Drawing.Point(204, 0);
            this.UserLogoutPageBTN.Name = "UserLogoutPageBTN";
            this.UserLogoutPageBTN.Size = new System.Drawing.Size(194, 64);
            this.UserLogoutPageBTN.TabIndex = 2;
            this.UserLogoutPageBTN.Text = "User Logout";
            this.UserLogoutPageBTN.UseVisualStyleBackColor = false;
            this.UserLogoutPageBTN.Click += new System.EventHandler(this.UserLogoutPageBTN_Click);
            // 
            // UserLoginPageBTN
            // 
            this.UserLoginPageBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLoginPageBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.UserLoginPageBTN.FlatAppearance.BorderSize = 0;
            this.UserLoginPageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserLoginPageBTN.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLoginPageBTN.ForeColor = System.Drawing.Color.White;
            this.UserLoginPageBTN.Location = new System.Drawing.Point(1, 0);
            this.UserLoginPageBTN.Name = "UserLoginPageBTN";
            this.UserLoginPageBTN.Size = new System.Drawing.Size(204, 64);
            this.UserLoginPageBTN.TabIndex = 2;
            this.UserLoginPageBTN.Text = "User Login";
            this.UserLoginPageBTN.UseVisualStyleBackColor = false;
            this.UserLoginPageBTN.Click += new System.EventHandler(this.UserLoginPageBTN_Click);
            // 
            // LoginUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1424, 825);
            this.Controls.Add(this.GroupBoxUserBTN);
            this.Controls.Add(this.SignUpNowBTNtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ForgetBTNtxt);
            this.Controls.Add(this.UserLoginButton);
            this.Controls.Add(this.LineAdmin);
            this.Controls.Add(this.ContainerPassword);
            this.Controls.Add(this.ContainerLogin);
            this.Controls.Add(this.ContainerOutsideTitle);
            this.Name = "LoginUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginUsers";
            this.ContainerPassword.ResumeLayout(false);
            this.ContainerPassword.PerformLayout();
            this.TextBoxGroupUserPassword.ResumeLayout(false);
            this.TextBoxGroupUserPassword.PerformLayout();
            this.ContainerLogin.ResumeLayout(false);
            this.ContainerLogin.PerformLayout();
            this.TextBoxGroupUser.ResumeLayout(false);
            this.TextBoxGroupUser.PerformLayout();
            this.ContainerOutsideTitle.ResumeLayout(false);
            this.ContainerInsideTitle.ResumeLayout(false);
            this.ContainerInsideTitle.PerformLayout();
            this.GroupBoxUserBTN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        

        #endregion
        private System.Windows.Forms.Panel LineAdmin;
        private System.Windows.Forms.Panel ContainerPassword;
        private System.Windows.Forms.Panel TextBoxGroupUserPassword;
        private System.Windows.Forms.TextBox TextBoxLoginUserPassword;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.Panel ContainerLogin;
        private System.Windows.Forms.Panel TextBoxGroupUser;
        private System.Windows.Forms.TextBox TextBoxLoginUser;
        private System.Windows.Forms.Label IDText;
        private System.Windows.Forms.Panel ContainerOutsideTitle;
        private System.Windows.Forms.Panel ContainerInsideTitle;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserLoginButton;
        private System.Windows.Forms.Label ForgetBTNtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SignUpNowBTNtxt;
        private System.Windows.Forms.Panel GroupBoxUserBTN;
        private System.Windows.Forms.Button UserLoginPageBTN;
        private System.Windows.Forms.Button UserLogoutPageBTN;
    }
}