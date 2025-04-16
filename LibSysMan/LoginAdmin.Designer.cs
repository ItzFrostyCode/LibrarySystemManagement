using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibSysMan
{
    partial class LoginAdmin
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
            this.ContainerOutsideTitle = new System.Windows.Forms.Panel();
            this.ContainerInsideTitle = new System.Windows.Forms.Panel();
            this.UsersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LineAdmin = new System.Windows.Forms.Panel();
            this.ContainerPassword = new System.Windows.Forms.Panel();
            this.TextBoxGroupPassword = new System.Windows.Forms.Panel();
            this.TextBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.Label();
            this.ContainerLogin = new System.Windows.Forms.Panel();
            this.TextBoxGroupAdmin = new System.Windows.Forms.Panel();
            this.TextBoxAdmin = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.Label();
            this.TextAdmin = new System.Windows.Forms.Label();
            this.ContainerOutsideTitle.SuspendLayout();
            this.ContainerInsideTitle.SuspendLayout();
            this.ContainerPassword.SuspendLayout();
            this.TextBoxGroupPassword.SuspendLayout();
            this.ContainerLogin.SuspendLayout();
            this.TextBoxGroupAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContainerOutsideTitle
            // 
            this.ContainerOutsideTitle.BackColor = System.Drawing.Color.White;
            this.ContainerOutsideTitle.Controls.Add(this.ContainerInsideTitle);
            this.ContainerOutsideTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContainerOutsideTitle.Location = new System.Drawing.Point(0, 0);
            this.ContainerOutsideTitle.Name = "ContainerOutsideTitle";
            this.ContainerOutsideTitle.Size = new System.Drawing.Size(1424, 129);
            this.ContainerOutsideTitle.TabIndex = 1;
            this.ContainerOutsideTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.ContainerOutsideTitle_Paint);
            // 
            // ContainerInsideTitle
            // 
            this.ContainerInsideTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ContainerInsideTitle.Controls.Add(this.UsersButton);
            this.ContainerInsideTitle.Controls.Add(this.label1);
            this.ContainerInsideTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContainerInsideTitle.Location = new System.Drawing.Point(0, 18);
            this.ContainerInsideTitle.Name = "ContainerInsideTitle";
            this.ContainerInsideTitle.Size = new System.Drawing.Size(1424, 111);
            this.ContainerInsideTitle.TabIndex = 1;
            // 
            // UsersButton
            // 
            this.UsersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.UsersButton.FlatAppearance.BorderSize = 0;
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersButton.ForeColor = System.Drawing.Color.White;
            this.UsersButton.Location = new System.Drawing.Point(1290, 36);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(100, 46);
            this.UsersButton.TabIndex = 1;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = false;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            this.UsersButton.Paint += new System.Windows.Forms.PaintEventHandler(this.UsersButton_Paint);
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
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LoginButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(437, 626);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(540, 91);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LineAdmin
            // 
            this.LineAdmin.BackColor = System.Drawing.Color.Gray;
            this.LineAdmin.Location = new System.Drawing.Point(437, 588);
            this.LineAdmin.Name = "LineAdmin";
            this.LineAdmin.Size = new System.Drawing.Size(540, 1);
            this.LineAdmin.TabIndex = 9;
            this.LineAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.LineAdmin_Paint);
            // 
            // ContainerPassword
            // 
            this.ContainerPassword.BackColor = System.Drawing.Color.Transparent;
            this.ContainerPassword.Controls.Add(this.TextBoxGroupPassword);
            this.ContainerPassword.Controls.Add(this.PasswordText);
            this.ContainerPassword.Location = new System.Drawing.Point(437, 448);
            this.ContainerPassword.Name = "ContainerPassword";
            this.ContainerPassword.Size = new System.Drawing.Size(540, 108);
            this.ContainerPassword.TabIndex = 8;
            this.ContainerPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.ContainerPassword_Paint);
            // 
            // TextBoxGroupPassword
            // 
            this.TextBoxGroupPassword.Controls.Add(this.TextBoxAdminPassword);
            this.TextBoxGroupPassword.Location = new System.Drawing.Point(0, 36);
            this.TextBoxGroupPassword.Name = "TextBoxGroupPassword";
            this.TextBoxGroupPassword.Size = new System.Drawing.Size(540, 72);
            this.TextBoxGroupPassword.TabIndex = 1;
            this.TextBoxGroupPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBoxGroupPassword_Paint);
            // 
            // TextBoxAdminPassword
            // 
            this.TextBoxAdminPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.TextBoxAdminPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAdminPassword.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAdminPassword.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxAdminPassword.Location = new System.Drawing.Point(26, 19);
            this.TextBoxAdminPassword.Name = "TextBoxAdminPassword";
            this.TextBoxAdminPassword.Size = new System.Drawing.Size(486, 39);
            this.TextBoxAdminPassword.TabIndex = 0;
            this.TextBoxAdminPassword.Text = "Enter Password";
            this.TextBoxAdminPassword.Enter += new System.EventHandler(this.TextBoxAdminPassword_Enter);
            this.TextBoxAdminPassword.Leave += new System.EventHandler(this.TextBoxAdminPassword_Leave);
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
            this.ContainerLogin.Controls.Add(this.TextBoxGroupAdmin);
            this.ContainerLogin.Controls.Add(this.LoginText);
            this.ContainerLogin.Location = new System.Drawing.Point(437, 312);
            this.ContainerLogin.Name = "ContainerLogin";
            this.ContainerLogin.Size = new System.Drawing.Size(540, 108);
            this.ContainerLogin.TabIndex = 7;
            this.ContainerLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.ContainerLogin_Paint);
            // 
            // TextBoxGroupAdmin
            // 
            this.TextBoxGroupAdmin.Controls.Add(this.TextBoxAdmin);
            this.TextBoxGroupAdmin.Location = new System.Drawing.Point(0, 36);
            this.TextBoxGroupAdmin.Name = "TextBoxGroupAdmin";
            this.TextBoxGroupAdmin.Size = new System.Drawing.Size(540, 72);
            this.TextBoxGroupAdmin.TabIndex = 1;
            this.TextBoxGroupAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBoxGroupAdmin_Paint);
            // 
            // TextBoxAdmin
            // 
            this.TextBoxAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.TextBoxAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAdmin.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAdmin.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxAdmin.Location = new System.Drawing.Point(26, 19);
            this.TextBoxAdmin.Name = "TextBoxAdmin";
            this.TextBoxAdmin.Size = new System.Drawing.Size(486, 39);
            this.TextBoxAdmin.TabIndex = 0;
            this.TextBoxAdmin.Text = "Enter Admin";
            this.TextBoxAdmin.Enter += new System.EventHandler(this.TextBoxAdmin_Enter);
            this.TextBoxAdmin.Leave += new System.EventHandler(this.TextBoxAdmin_Leave);
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginText.ForeColor = System.Drawing.Color.White;
            this.LoginText.Location = new System.Drawing.Point(0, 0);
            this.LoginText.Margin = new System.Windows.Forms.Padding(0);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(86, 33);
            this.LoginText.TabIndex = 0;
            this.LoginText.Text = "Login";
            // 
            // TextAdmin
            // 
            this.TextAdmin.AutoSize = true;
            this.TextAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextAdmin.Location = new System.Drawing.Point(491, 158);
            this.TextAdmin.Name = "TextAdmin";
            this.TextAdmin.Size = new System.Drawing.Size(432, 55);
            this.TextAdmin.TabIndex = 6;
            this.TextAdmin.Text = "Admin Login Form";
            this.TextAdmin.Click += new System.EventHandler(this.TextAdmin_Click);
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1424, 825);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LineAdmin);
            this.Controls.Add(this.ContainerPassword);
            this.Controls.Add(this.ContainerLogin);
            this.Controls.Add(this.TextAdmin);
            this.Controls.Add(this.ContainerOutsideTitle);
            this.Name = "LoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginAdmin";
            this.Load += new System.EventHandler(this.LoginAdmin_Load);
            this.ContainerOutsideTitle.ResumeLayout(false);
            this.ContainerInsideTitle.ResumeLayout(false);
            this.ContainerInsideTitle.PerformLayout();
            this.ContainerPassword.ResumeLayout(false);
            this.ContainerPassword.PerformLayout();
            this.TextBoxGroupPassword.ResumeLayout(false);
            this.TextBoxGroupPassword.PerformLayout();
            this.ContainerLogin.ResumeLayout(false);
            this.ContainerLogin.PerformLayout();
            this.TextBoxGroupAdmin.ResumeLayout(false);
            this.TextBoxGroupAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion



        private System.Windows.Forms.Panel ContainerOutsideTitle;
        private System.Windows.Forms.Panel ContainerInsideTitle;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel LineAdmin;
        private System.Windows.Forms.Panel ContainerPassword;
        private System.Windows.Forms.Panel TextBoxGroupPassword;
        private System.Windows.Forms.TextBox TextBoxAdminPassword;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.Panel ContainerLogin;
        private System.Windows.Forms.Panel TextBoxGroupAdmin;
        private System.Windows.Forms.TextBox TextBoxAdmin;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.Label TextAdmin;


    }
}

