using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                connection.Open();
                string query = $"SELECT COUNT(1) FROM User WHERE Username='{loginUsername}' AND Password='{loginPassword}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    Console.WriteLine("OK");
                    
                    int count = command.ExecuteNonQuery();
                    if (count == 1)
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

        private void signup_Click(object sender, EventArgs e)
        {
            if (registerPassword.Text != registerPasswordRepeat.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["AuthDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT COUNT(1) FROM User WHERE Username='{loginUsername}' AND Password='{loginPassword}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    int count = command.ExecuteNonQuery();
                    if (count == 0)
                    {
                        query = $"INSERT INTO Users (Username, Password) VALUES ('{registerUsername}', '{registerPassword}')";
                        MessageBox.Show("Account created successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }
    }
}
