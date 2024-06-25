namespace Finals
{
    partial class SignUp
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
            btnSignIn = new Button();
            chbShowPassword = new CheckBox();
            txtPassword = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.AutoEllipsis = true;
            btnSignIn.Location = new Point(90, 316);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(178, 34);
            btnSignIn.TabIndex = 13;
            btnSignIn.Text = "REGISTER ACCOUNT";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.Location = new Point(93, 291);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(108, 19);
            chbShowPassword.TabIndex = 12;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = SystemColors.ActiveBorder;
            txtPassword.Location = new Point(90, 204);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your username";
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.Size = new Size(178, 23);
            txtPassword.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(90, 176);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 10;
            label3.Text = "USERNAME";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 139);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Your Name";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(90, 111);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 8;
            label2.Text = "NAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(81, 66);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 7;
            label1.Text = "SIGN UP";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 262);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Enter Your password";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(90, 234);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 14;
            label4.Text = "PASSWORD";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(btnSignIn);
            Controls.Add(chbShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignIn;
        private CheckBox chbShowPassword;
        private TextBox txtPassword;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Label label4;
    }
}