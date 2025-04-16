using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LibSysMan
{
    public partial class LoginUsers : Form
    {
        private const float DefaultCornerRadius = 14.4f;
        private static readonly Color DefaultBorderColor = Color.FromArgb(25, Color.White);

        // Fix for CS0019: Operator '+=' cannot be applied to operands of type 'Button' and 'method group'
        // The issue is that you are trying to attach an event handler to the Button itself instead of its event.

        public LoginUsers()
        {
            InitializeComponent();

            this.UserLoginButton.Click += UserLoginButton_Load;
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




        private void AdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();


            LoginAdmin loginAdminForm = new LoginAdmin();
            loginAdminForm.Show();
        }

        private void AdminButton_Load(object sender, EventArgs e)
        {
            // Apply styles to AdminButton or other logic
            ApplyRoundedCorners(AdminButton, 14f); // If you want rounded corners
        }


        private void LoginUsers_Load(object sender, EventArgs e)
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

        private void GroupBoxUserBTN_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorder(sender, e, DefaultCornerRadius, DefaultBorderColor, 2);
        }


        private void UserLoginPageBTN_Click(object sender, EventArgs e)
        {

        }

        private void UserLoginButton_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners(UserLoginButton, 14f); // Set corner radius

        }



        private void UserLogoutPageBTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            LogoutUsers logoutUserForm = new LogoutUsers();
            logoutUserForm.Show();
        }
        private void TextBoxGroupUserPassword_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorder(sender, e, DefaultCornerRadius, DefaultBorderColor, 2);
        }

        private void TextBoxGroupUser_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorder(sender, e, DefaultCornerRadius, DefaultBorderColor, 2);
        }





        private void ForgetBTNtxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the administrator to recover your PIN or ID.", "Forgot PIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextBoxUser_Enter(object sender, EventArgs e)
        {
            if (TextBoxLoginUser.Text == "Enter User ID")
            {
                // Remove the default text when the user clicks on the text box
                TextBoxLoginUser.Text = "";
                TextBoxLoginUser.ForeColor = Color.White; // Change text color to black
            }
        }

        private void TextBoxUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxLoginUser.Text))
            {
                TextBoxLoginUser.Text = "Enter User ID";
                TextBoxLoginUser.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }


        private void TextBoxUserPassword_Enter(object sender, EventArgs e)
        {
            if (TextBoxLoginUserPassword.Text == "Enter User Password")
            {
                // Remove the default text when the user clicks on the text box
                TextBoxLoginUserPassword.Text = "";
                TextBoxLoginUserPassword.ForeColor = Color.White; // Change text color to black
            }
        }

        private void TextBoxUserPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxLoginUserPassword.Text))
            {
                TextBoxLoginUserPassword.Text = "Enter User Password";
                TextBoxLoginUserPassword.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }



        private void TextBoxLoginUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxLoginUserPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserLoginButton_Click(object sender, EventArgs e)
        {

        }

        private void SignUpNowBTNtxt_Click(object sender, EventArgs e)
        {
            this.Hide();

            Signup_Users_Info signupForm = new Signup_Users_Info();
            signupForm.Show();
        }
    }
}
