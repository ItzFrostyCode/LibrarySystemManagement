using MySqlConnector;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LibSysMan
{
    public partial class LoginAdmin : Form
    {
        private const float DefaultCornerRadius = 14.4f;
        private static readonly Color DefaultBorderColor = Color.FromArgb(25, Color.White);

        public LoginAdmin()
        {
            InitializeComponent();
        }



        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            // Apply rounded corners to the Login button
            ApplyRoundedCorners(LoginButton, DefaultCornerRadius);
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            this.Hide();


            LoginUsers loginUsersForm = new LoginUsers();
            loginUsersForm.Show();
        }

        private void UsersButton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            float radius = 8f;
            float diameter = radius * 2;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, diameter, diameter, 180, 90); // Top-left
            path.AddArc(btn.Width - diameter, 0, diameter, diameter, 270, 90); // Top-right
            path.AddArc(btn.Width - diameter, btn.Height - diameter, diameter, diameter, 0, 90); // Bottom-right
            path.AddArc(0, btn.Height - diameter, diameter, diameter, 90, 90); // Bottom-left
            path.CloseFigure();

            btn.Region = new Region(path);
        }



        private void TextBoxAdmin_Enter(object sender, EventArgs e)
        {
            // Check if the default text "Enter admin username" is present
            if (TextBoxAdmin.Text == "Enter Admin")
            {
                // Remove the default text when the user clicks on the text box
                TextBoxAdmin.Text = "";
                TextBoxAdmin.ForeColor = Color.White; // Change text color to black
            }
        }

        private void TextBoxAdminPassword_Enter(object sender, EventArgs e)
        {
            // Check if the default text "Enter password" is present
            if (TextBoxAdminPassword.Text == "Enter Password")
            {
                // Remove the default text when the user clicks on the text box
                TextBoxAdminPassword.Text = "";
                TextBoxAdminPassword.ForeColor = Color.White; // Change text color to black
            }
        }

        private void TextBoxAdmin_Leave(object sender, EventArgs e)
        {
            // Restore default text if the text box is empty
            if (string.IsNullOrWhiteSpace(TextBoxAdmin.Text))
            {
                TextBoxAdmin.Text = "Enter Admin";
                TextBoxAdmin.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }

        private void TextBoxAdminPassword_Leave(object sender, EventArgs e)
        {
            // Restore default text if the text box is empty
            if (string.IsNullOrWhiteSpace(TextBoxAdminPassword.Text))
            {
                TextBoxAdminPassword.Text = "Enter Password";
                TextBoxAdminPassword.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = TextBoxAdmin.Text.Trim();
            string password = TextBoxAdminPassword.Text.Trim();

            string connection = "Server=127.0.0.1;Database=sys;User ID=root;Password=0430;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();

                    string query = "SELECT * FROM admin_accounts WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login successful!");
                                // Proceed to next form here
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }




        private void TextBoxGroupAdmin_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorder(sender, e, DefaultCornerRadius, DefaultBorderColor, 2);
        }

        private void TextBoxGroupPassword_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorder(sender, e, DefaultCornerRadius, DefaultBorderColor, 2);
        }



        private void DrawRoundedBorder(object sender, PaintEventArgs e, float cornerRadius, Color borderColor, float borderWidth)
        {
            if (sender is Control control)
            {
                RectangleF rect = new RectangleF(0, 0, control.Width - 1, control.Height - 1);
                using (Graphics g = e.Graphics)
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    using (GraphicsPath path = new GraphicsPath())
                    {
                        float r = cornerRadius * 2;

                        path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                        path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                        path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                        path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                        path.CloseFigure();

                        using (Pen pen = new Pen(borderColor, borderWidth))
                        {
                            g.DrawPath(pen, path);
                        }
                    }
                }
            }
        }

        private void ApplyRoundedCorners(Control control, float cornerRadius)
        {
            if (control is Button button)
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    float diameter = cornerRadius * 2;

                    path.AddArc(0, 0, diameter, diameter, 180, 90); // Top-left corner  
                    path.AddArc(button.Width - diameter, 0, diameter, diameter, 270, 90); // Top-right corner  
                    path.AddArc(button.Width - diameter, button.Height - diameter, diameter, diameter, 0, 90); // Bottom-right corner  
                    path.AddArc(0, button.Height - diameter, diameter, diameter, 90, 90); // Bottom-left corner  
                    path.CloseAllFigures();

                    button.Region = new Region(path);
                }

                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
        }

        private void LineAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ContainerPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ContainerLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextAdmin_Click(object sender, EventArgs e)
        {

        }

        private void ContainerOutsideTitle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
