using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibSysMan
{
    public partial class Signup_Users_Info : Form
    {
        public Signup_Users_Info()
        {
            InitializeComponent();
            InitializeComboBoxGender();
            InitializeComboBoxValidID();

            InitializeComboBoxDOBYear();
            InitializeComboBoxDOBMonth();
            InitializeComboBoxDOBDay();

            this.StrokeBoxFName.Paint += DrawStroke;
            this.StrokeBoxMName.Paint += DrawStroke;
            this.StrokeBoxLName.Paint += DrawStroke;

            this.StrokeBoxCNum.Paint += DrawStroke;
            this.StrokeBoxEadd.Paint += DrawStroke;
            this.StrokeBoxValidID.Paint += DrawStroke;

            this.StrokeBoxAddress.Paint += DrawStroke;
            this.StrokeBoxGender.Paint += DrawStroke;
            this.StrokeBoxDOB.Paint += DrawStroke;





        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginUsers loginUserForm = new LoginUsers();
            loginUserForm.Show();
        }

        private void StrokeBoxFName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StrokeBoxMName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StrokeBoxLName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DrawStroke(object sender, PaintEventArgs e)
        {
            Control box = (Control)sender;
            Pen border = new Pen(Color.Gray, 2);
            e.Graphics.DrawRectangle(border, 0, 0, box.Width - 1, box.Height - 1);
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxFName_Enter(object sender, EventArgs e)
        {
            if (TextBoxFName.Text == "Enter first name")
            {
                // Remove the default text when the user clicks on the text box
                TextBoxFName.Text = "";
                TextBoxFName.ForeColor = Color.White; // Change text color to black
            }
        }

        private void TextBoxFName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxFName.Text))
            {
                TextBoxFName.Text = "Enter first name";
                TextBoxFName.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }

        private void TextBoxMName_Enter(object sender, EventArgs e)
        {
            if (TextBoxMName.Text == "Enter middle name")
            {
                // Remove the default text when the user clicks on the text box
                TextBoxMName.Text = "";
                TextBoxMName.ForeColor = Color.White; // Change text color to black
            }
        }

        private void TextBoxMName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxMName.Text))
            {
                TextBoxMName.Text = "Enter middle name";
                TextBoxMName.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }



        private void TextBoxLName_Enter_1(object sender, EventArgs e)
        {
            if (TextBoxLName.Text == "Enter last name")
            {
                // Remove the default text when the user clicks on the text box
                TextBoxLName.Text = "";
                TextBoxLName.ForeColor = Color.White; // Change text color to black
            }
        }

        private void TextBoxLName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxLName.Text))
            {
                TextBoxLName.Text = "Enter last name";
                TextBoxLName.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }

        private void CNumTextBox_Enter(object sender, EventArgs e)
        {
            if (CNumTextBox.Text == "#")
            {
                CNumTextBox.Text = "";
                CNumTextBox.ForeColor = Color.Gray;
            }
        }

        private void CNumTextBox_Leave(object sender, EventArgs e)
        {
            // If the field is empty, show the placeholder and set the text color to gray
            if (string.IsNullOrWhiteSpace(CNumTextBox.Text))
            {
                CNumTextBox.Text = "#";
                CNumTextBox.ForeColor = Color.Gray; // Placeholder color
                CNumTextBox.BackColor = Color.FromArgb(42, 42, 42);
            }
            else
            {
                // Validation: Check if it's an 11-digit number
                string input = CNumTextBox.Text.Trim();
                if (!System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d{11}$"))
                {
                    // Show error message if input is invalid
                    MessageBox.Show("Please enter a valid 11-digit contact number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CNumTextBox.Focus();
                    CNumTextBox.BackColor = Color.FromArgb(42, 42, 42);
                    CNumTextBox.ForeColor = Color.Gray; // Set text color to black when invalid
                }
                else
                {
                    // Reset the background color if the input is valid
                    CNumTextBox.BackColor = Color.FromArgb(42, 42, 42);
                    CNumTextBox.ForeColor = Color.Gray; // Set text color to black when valid
                }
            }
        }

        private void EmailAddTextBox_Enter(object sender, EventArgs e)
        {
            if (EmailAddTextBox.Text == "@")
            {
                EmailAddTextBox.Text = "";
                EmailAddTextBox.ForeColor = Color.White; // or whatever text color you prefer
            }
        }

        private void EmailAddTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailAddTextBox.Text))
            {
                EmailAddTextBox.Text = "@";
                EmailAddTextBox.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }

        private void AddressTextBox_Enter(object sender, EventArgs e)
        {
            if (AddressTextBox.Text == "Street / Barangay / City")
            {
                AddressTextBox.Text = "";
                AddressTextBox.ForeColor = Color.White; // or whatever text color you prefer
            }
        }

        private void AddressTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                AddressTextBox.Text = "Street / Barangay / City";
                AddressTextBox.ForeColor = Color.Gray; // Change text color to gray for placeholder
            }
        }

        private void InitializeComboBoxGender()
        {

            comboBoxGender.Items.Clear();
            comboBoxGender.Items.Add("Male");
            comboBoxGender.Items.Add("Female");

            // Set the default text
            comboBoxGender.SelectedIndex = 0; // "Select Gender" will be displayed by default
        }

        private void InitializeComboBoxValidID()
        {

            comboBoxValidID.Items.Clear();
            comboBoxValidID.Items.Add("Student ID");
            comboBoxValidID.Items.Add("National ID");
            comboBoxValidID.Items.Add("Postal ID");
            comboBoxValidID.Items.Add("Driver’s License");
            comboBoxValidID.Items.Add("PhilHealth ID");


            // Set the default text
            comboBoxValidID.SelectedIndex = 0; // "Select Gender" will be displayed by default
        }

        private void InitializeComboBoxDOBYear()
        {
            comboBoxYear.Items.Clear();

            int currentYear = DateTime.Now.Year;

            for (int year = 1990; year <= currentYear; year++)
            {
                comboBoxYear.Items.Add(year.ToString());
            }

            comboBoxYear.SelectedIndex = 0; // Optional: selects first year (1990)
        }

        private void InitializeComboBoxDOBMonth()
        {
            comboBoxMonth.Items.Clear();

            for (int month = 1; month <= 12; month++)
            {
                comboBoxMonth.Items.Add(new DateTime(2000, month, 1).ToString("MMMM"));
            }

            comboBoxMonth.SelectedIndex = 0; // Optional: selects January
        }


        private void InitializeComboBoxDOBDay()
        {
            comboBoxDay.Items.Clear();

            for (int day = 1; day <= 31; day++)
            {
                comboBoxDay.Items.Add(day.ToString("00")); // Format 01, 02, ..., 31
            }

            comboBoxDay.SelectedIndex = 0; // Optional: selects 01
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(TextBoxFName.Text) || TextBoxFName.Text == "Enter first name" ||
                string.IsNullOrWhiteSpace(TextBoxMName.Text) || TextBoxMName.Text == "Enter middle name" ||
                string.IsNullOrWhiteSpace(TextBoxLName.Text) || TextBoxLName.Text == "Enter last name" ||
                string.IsNullOrWhiteSpace(CNumTextBox.Text) || CNumTextBox.Text == "#" ||
                string.IsNullOrWhiteSpace(EmailAddTextBox.Text) || EmailAddTextBox.Text == "@" ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) || AddressTextBox.Text == "Street / Barangay / City" ||
                comboBoxGender.SelectedIndex == 0 || // Default "Select Gender"
                comboBoxValidID.SelectedIndex == 0 || // Default "Select Valid ID"
                comboBoxYear.SelectedIndex == 0 || // Default year
                comboBoxMonth.SelectedIndex == 0 || // Default month
                comboBoxDay.SelectedIndex == 0) // Default day
            {
                MessageBox.Show("Please fill out all required fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop execution
            }

            // Proceed to the next page
            MessageBox.Show("All fields are valid. Proceeding to the next page.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Hide();
            SignupUsersLoginCredentials signupUsersLoginCredentialsForm = new SignupUsersLoginCredentials(); // Explicitly declare the type as NextForm
            signupUsersLoginCredentialsForm.Show();
        }

    }
}

