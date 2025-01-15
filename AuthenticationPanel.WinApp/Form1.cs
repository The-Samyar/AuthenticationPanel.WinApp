using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AuthenticationPanel.WinApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(148, 145, 226), Color.FromArgb(175, 242, 216), 35f);

            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void linkToSignupTab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainTabControl.SelectedIndex = 1;
        }

        private void login_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AuthDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Checks for custom validations
                var (passwordIsValid, errorMessages) = PasswordValidation.IsValid(loginPassword.Text);
                if (!passwordIsValid)
                {
                    var popupMessage = "Choose another password:\n";
                    foreach (var message in errorMessages)
                    {
                        popupMessage += message + "\n";
                    }
                    MessageBox.Show(popupMessage);
                    return;
                }

                connection.Open();
                string query = $"SELECT [Username],[Password] FROM [AuthDB].[dbo].[Users] WHERE [Username] = '{loginUsername.Text}' AND [Password] = '{loginPassword.Text}';";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login successful.");
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            // Checks repeated password
            if (registerPassword.Text != registerPasswordRepeat.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Checks for custom validations
            var (passwordIsValid, errorMessages) = PasswordValidation.IsValid(registerPassword.Text);
            if (!passwordIsValid)
            {
                var popupMessage = "Choose another password:\n";
                foreach (var message in errorMessages)
                {
                    popupMessage += message + "\n";
                }
                MessageBox.Show(popupMessage);
                return;
            }

            // If all validations passed, connect to database
            string connectionString = ConfigurationManager.ConnectionStrings["AuthDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT [Username] FROM [AuthDB].[dbo].[Users] WHERE [Username] = '{registerUsername.Text}';";
                bool res;
                using (SqlCommand queryCommand = new SqlCommand(query, connection))
                {
                    using (var reader = queryCommand.ExecuteReader())
                    {
                        res = reader.HasRows;
                    }
                }

                if (!res)
                {
                    var insert = $"INSERT INTO [AuthDB].[dbo].[Users] (Username, Password) VALUES ('{registerUsername.Text}','{registerPassword.Text}');";
                    using (SqlCommand insertCommand = new SqlCommand(insert, connection))
                    {
                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Account created successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("User with this username already exists.");
                }
                connection.Close();
            }
        }
    }
}
// k@mbiZ1234