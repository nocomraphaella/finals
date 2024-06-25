namespace Finals
{
    partial class Sign_In
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            chbShowPassword = new CheckBox();
            btnSignIn = new Button();
            label4 = new Label();
            LinkSignUp = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(48, 58);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 0;
            label1.Text = "SIGN IN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(48, 103);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 1;
            label2.Text = "USERNAME";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 131);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Your Name";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(57, 168);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = SystemColors.ActiveBorder;
            txtPassword.Location = new Point(57, 196);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.Size = new Size(178, 23);
            txtPassword.TabIndex = 4;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.Location = new Point(60, 225);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(108, 19);
            chbShowPassword.TabIndex = 5;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // btnSignIn
            // 
            btnSignIn.AutoEllipsis = true;
            btnSignIn.Location = new Point(57, 261);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(178, 34);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(60, 312);
            label4.Name = "label4";
            label4.Size = new Size(193, 18);
            label4.TabIndex = 7;
            label4.Text = "Don't have an account?";
            // 
            // LinkSignUp
            // 
            LinkSignUp.AutoSize = true;
            LinkSignUp.LinkColor = Color.Black;
            LinkSignUp.Location = new Point(259, 315);
            LinkSignUp.Name = "LinkSignUp";
            LinkSignUp.Size = new Size(60, 15);
            LinkSignUp.TabIndex = 8;
            LinkSignUp.TabStop = true;
            LinkSignUp.Text = "linkLabel1";
            LinkSignUp.LinkClicked += LinkSignUp_LinkClicked;
            // 
            // Sign_In
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(LinkSignUp);
            Controls.Add(label4);
            Controls.Add(btnSignIn);
            Controls.Add(chbShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sign_In";
            Text = "Sign_In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox txtPassword;
        private CheckBox chbShowPassword;
        private Button btnSignIn;
        private Label label4;
        private LinkLabel LinkSignUp;
    }
}