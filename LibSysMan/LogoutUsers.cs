using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LibSysMan
{
    public partial class LogoutUsers : Form
    {
        private const float DefaultCornerRadius = 14.4f;
        private static readonly Color DefaultBorderColor = Color.FromArgb(25, Color.White);
        public LogoutUsers()
        {
            InitializeComponent();
            this.Load += LogoutUsers_Load;
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();


            LoginAdmin loginAdminForm = new LoginAdmin();
            loginAdminForm.Show();
        }

        private void UserLogoutPageBTN_Click(object sender, EventArgs e)
        {

        }


        private void UserLogoutPageBTN_Load(object sender, EventArgs e)
        {

            ApplyRoundedCorners(UserLogoutPageBTN, 14.4f);
        }

        private void TextBoxGroupUserPassword_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorder(sender, e, DefaultCornerRadius, DefaultBorderColor, 2);
        }

        private void TextBoxGroupUser_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorder(sender, e, DefaultCornerRadius, DefaultBorderColor, 2);
        }

        private void GroupBoxUserBTN_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorder(sender, e, DefaultCornerRadius, DefaultBorderColor, 2);
        }

        private void DrawRoundedBorder(object sender, PaintEventArgs e, float cornerRadius, Color borderColor, float borderWidth)
        {
            if (sender is Control control && control.Width > 0 && control.Height > 0)
            {
                RectangleF rect = new RectangleF(0, 0, control.Width - 1, control.Height - 1);
                using (GraphicsPath path = new GraphicsPath())
                {
                    float r = cornerRadius * 2;

                    path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                    path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                    path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                    path.CloseFigure();

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(borderColor, borderWidth))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        private void UserLoginPageBTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginUsers loginUserForm = new LoginUsers();
            loginUserForm.Show();
        }

        private void LogoutUsers_Load(object sender, EventArgs e)
        {
            // Apply rounded corners to UserLoginPageBTN when the form is loaded
            ApplyRoundedCorners(UserLoginPageBTN, 14f);
        }
        private void ApplyRoundedCorners(Control control, float cornerRadius)
        {
            control.Paint += (s, e) =>
            {
                if (control.Width > 0 && control.Height > 0)
                {
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                        path.AddArc(control.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                        path.AddArc(control.Width - cornerRadius, control.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                        path.AddArc(0, control.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                        path.CloseFigure();
                        control.Region = new Region(path);
                    }
                }
            };
        }


        private void UserLoginButton_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxLogoutUser_Enter(object sender, EventArgs e)
        {
            if (TextBoxLogoutUser.Text == "Enter User ID")
            {
                // Remove the default text when the user clicks on the text box
                TextBoxLogoutUser.Text = "";
                TextBoxLogoutUser.ForeColor = Color.White; // Change text color to black
            }
        }

        private void TextBoxLogoutUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxLogoutUser.Text))
            {
                TextBoxLogoutUser.Text = "Enter User ID";
                TextBoxLogoutUser.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }

        private void TextBoxLogoutUserPassword_Enter(object sender, EventArgs e)
        {
            if (TextBoxLogoutUserPassword.Text == "Enter User ID")
            {
                // Remove the default text when the user clicks on the text box
                TextBoxLogoutUserPassword.Text = "";
                TextBoxLogoutUserPassword.ForeColor = Color.White; // Change text color to black
            }
        }

        private void TextBoxLogoutUserPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxLogoutUserPassword.Text))
            {
                TextBoxLogoutUserPassword.Text = "Enter User ID";
                TextBoxLogoutUserPassword.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }

        private void UserLogoutButton_Click(object sender, EventArgs e)
        {

        }

        private void UserLogoutButton_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners(UserLogoutButton, 14f); // Set corner radius

        }

        private void ForgetBTNtxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the administrator to recover your PIN or ID.", "Forgot PIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SignUpNowBTNtxt_Click(object sender, EventArgs e)
        {
            this.Hide();

            Signup_Users_Info signupForm = new Signup_Users_Info();
            signupForm.Show();
        }

        private void TextBoxLogoutUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
