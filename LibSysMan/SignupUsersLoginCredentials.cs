using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibSysMan
{
    public partial class SignupUsersLoginCredentials : Form
    {
        public SignupUsersLoginCredentials()
        {
            InitializeComponent();

            this.StrokeBoxUsername.Paint += DrawStroke;
            this.StrokeBoxPin.Paint += DrawStroke;
            this.StrokeBoxRePin.Paint += DrawStroke;

        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            Signup_Users_Info signupUserInfoForm = new Signup_Users_Info();
            signupUserInfoForm.Show();
        }

        private void DrawStroke(object sender, PaintEventArgs e)
        {
            Control box = (Control)sender;
            Pen border = new Pen(Color.Gray, 2);
            e.Graphics.DrawRectangle(border, 0, 0, box.Width - 1, box.Height - 1);
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Enter username")
            {
                // Remove the default text when the user clicks on the text box
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.White; // Change text color to black
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                textBoxUsername.Text = "Enter username";
                textBoxUsername.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }

        private void TextBoxSixDigitPin_Enter(object sender, EventArgs e)
        {
            if (TextBoxSixDigitPin.Text == "******")
            {
                TextBoxSixDigitPin.Text = "";
                TextBoxSixDigitPin.ForeColor = Color.White;
                TextBoxSixDigitPin.PasswordChar = '*'; // Enable masking
            }
        }

        private void TextBoxSixDigitPin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxSixDigitPin.Text))
            {
                TextBoxSixDigitPin.Text = "******";
                TextBoxSixDigitPin.ForeColor = Color.Gray;
                TextBoxSixDigitPin.PasswordChar = '\0'; // Disable masking to show placeholder
            }
        }

        private void TextBoxReEnterSixDigitPin_Enter(object sender, EventArgs e)
        {
            if (TextBoxReEnterSixDigitPin.Text == "******")
            {
                TextBoxReEnterSixDigitPin.Text = "";
                TextBoxReEnterSixDigitPin.ForeColor = Color.White;
                TextBoxReEnterSixDigitPin.PasswordChar = '*';
            }
        }

        private void TextBoxReEnterSixDigitPin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxReEnterSixDigitPin.Text))
            {
                TextBoxReEnterSixDigitPin.Text = "******";
                TextBoxReEnterSixDigitPin.ForeColor = Color.Gray;
                TextBoxReEnterSixDigitPin.PasswordChar = '\0';
            }
        }



        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string pin = TextBoxSixDigitPin.Text.Trim();
            string rePin = TextBoxReEnterSixDigitPin.Text.Trim();

            // Check username
            if (string.IsNullOrWhiteSpace(username) || username == "Enter username")
            {
                MessageBox.Show("Please enter a valid username.", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUsername.BackColor = Color.MistyRose;
                return;
            }
            else
            {
                textBoxUsername.BackColor = Color.FromArgb(42, 42, 42); // Reset color
            }

            // Check PIN format
            if (!System.Text.RegularExpressions.Regex.IsMatch(pin, @"^\d{6}$"))
            {
                MessageBox.Show("PIN must be exactly 6 digits.", "Invalid PIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxSixDigitPin.BackColor = Color.MistyRose;
                return;
            }
            else
            {
                TextBoxSixDigitPin.BackColor = Color.FromArgb(42, 42, 42);
            }

            // Check PIN match
            if (pin != rePin)
            {
                MessageBox.Show("PINs do not match. Please re-enter.", "PIN Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxReEnterSixDigitPin.BackColor = Color.MistyRose;
                return;
            }
            else
            {
                TextBoxReEnterSixDigitPin.BackColor = Color.FromArgb(42, 42, 42);
            }

            // All good!
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optional: Navigate to login or next form
            // this.Hide();s
            // var loginForm = new LoginForm();
            // loginForm.Show();
        }





    }
}
