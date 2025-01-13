using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(148, 145, 226), Color.FromArgb(175, 242, 216), 35f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void linkToSignupTab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainTabControl.SelectedIndex = 1;
        }
    }
}
