using System.Windows.Forms;

namespace AuthenticationPanel.WinApp
{
    partial class mainForm
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.linkToSignupTab = new System.Windows.Forms.LinkLabel();
            this.login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signupTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.registerPasswordRepeat = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registerPassword = new System.Windows.Forms.TextBox();
            this.registerUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.signupTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.loginTab);
            this.mainTabControl.Controls.Add(this.signupTab);
            this.mainTabControl.Location = new System.Drawing.Point(164, 38);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(457, 533);
            this.mainTabControl.TabIndex = 0;
            // 
            // loginTab
            // 
            this.loginTab.BackColor = System.Drawing.Color.Lavender;
            this.loginTab.Controls.Add(this.linkToSignupTab);
            this.loginTab.Controls.Add(this.login);
            this.loginTab.Controls.Add(this.label3);
            this.loginTab.Controls.Add(this.label2);
            this.loginTab.Controls.Add(this.loginPassword);
            this.loginTab.Controls.Add(this.loginUsername);
            this.loginTab.Controls.Add(this.label1);
            this.loginTab.Location = new System.Drawing.Point(4, 25);
            this.loginTab.Margin = new System.Windows.Forms.Padding(4);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(4);
            this.loginTab.Size = new System.Drawing.Size(449, 504);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login";
            // 
            // linkToSignupTab
            // 
            this.linkToSignupTab.AutoSize = true;
            this.linkToSignupTab.Location = new System.Drawing.Point(159, 377);
            this.linkToSignupTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkToSignupTab.Name = "linkToSignupTab";
            this.linkToSignupTab.Size = new System.Drawing.Size(124, 16);
            this.linkToSignupTab.TabIndex = 1;
            this.linkToSignupTab.TabStop = true;
            this.linkToSignupTab.Text = "Create new account";
            this.linkToSignupTab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToSignupTab_LinkClicked);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(160, 309);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(133, 39);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(223, 222);
            this.loginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(160, 22);
            this.loginPassword.TabIndex = 2;
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(223, 162);
            this.loginUsername.Margin = new System.Windows.Forms.Padding(4);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(160, 22);
            this.loginUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // signupTab
            // 
            this.signupTab.BackColor = System.Drawing.Color.Lavender;
            this.signupTab.Controls.Add(this.label7);
            this.signupTab.Controls.Add(this.registerPasswordRepeat);
            this.signupTab.Controls.Add(this.signup);
            this.signupTab.Controls.Add(this.label4);
            this.signupTab.Controls.Add(this.label5);
            this.signupTab.Controls.Add(this.registerPassword);
            this.signupTab.Controls.Add(this.registerUsername);
            this.signupTab.Controls.Add(this.label6);
            this.signupTab.Location = new System.Drawing.Point(4, 25);
            this.signupTab.Margin = new System.Windows.Forms.Padding(4);
            this.signupTab.Name = "signupTab";
            this.signupTab.Padding = new System.Windows.Forms.Padding(4);
            this.signupTab.Size = new System.Drawing.Size(449, 504);
            this.signupTab.TabIndex = 1;
            this.signupTab.Text = "Signup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Repeat password";
            // 
            // registerPasswordRepeat
            // 
            this.registerPasswordRepeat.Location = new System.Drawing.Point(224, 286);
            this.registerPasswordRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.registerPasswordRepeat.Name = "registerPasswordRepeat";
            this.registerPasswordRepeat.Size = new System.Drawing.Size(160, 22);
            this.registerPasswordRepeat.TabIndex = 12;
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(157, 352);
            this.signup.Margin = new System.Windows.Forms.Padding(4);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(133, 39);
            this.signup.TabIndex = 11;
            this.signup.Text = "Sign up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Username";
            // 
            // registerPassword
            // 
            this.registerPassword.Location = new System.Drawing.Point(224, 225);
            this.registerPassword.Margin = new System.Windows.Forms.Padding(4);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.Size = new System.Drawing.Size(160, 22);
            this.registerPassword.TabIndex = 8;
            // 
            // registerUsername
            // 
            this.registerUsername.Location = new System.Drawing.Point(224, 166);
            this.registerUsername.Margin = new System.Windows.Forms.Padding(4);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(160, 22);
            this.registerUsername.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sign up";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 604);
            this.Controls.Add(this.mainTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "Authentication Panel";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.set_background);
            this.mainTabControl.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.signupTab.ResumeLayout(false);
            this.signupTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl mainTabControl;
        private TabPage loginTab;
        private TabPage signupTab;
        private Label label3;
        private Label label2;
        private TextBox loginPassword;
        private TextBox loginUsername;
        private Label label1;
        private Button login;
        private Label label7;
        private TextBox registerPasswordRepeat;
        private Button signup;
        private Label label4;
        private Label label5;
        private TextBox registerPassword;
        private TextBox registerUsername;
        private Label label6;
        private LinkLabel linkToSignupTab;
    }
}

