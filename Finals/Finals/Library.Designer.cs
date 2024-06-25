namespace Finals
{
    partial class Library
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
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            TxtID = new TextBox();
            btnRemove = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cbRole = new ComboBox();
            label6 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnLogout = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(29, 220);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(170, 28);
            txtUsername.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(29, 193);
            label4.Name = "label4";
            label4.Size = new Size(105, 24);
            label4.TabIndex = 11;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(29, 113);
            label3.Name = "label3";
            label3.Size = new Size(63, 24);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(29, 140);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 28);
            txtName.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(29, 35);
            label2.Name = "label2";
            label2.Size = new Size(21, 24);
            label2.TabIndex = 8;
            label2.Text = "#";
            // 
            // TxtID
            // 
            TxtID.Location = new Point(29, 62);
            TxtID.Multiline = true;
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(170, 28);
            TxtID.TabIndex = 7;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Black;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.LightCoral;
            btnRemove.Location = new Point(29, 539);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(170, 45);
            btnRemove.TabIndex = 20;
            btnRemove.Text = "Remove Account";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.LightCoral;
            btnUpdate.Location = new Point(29, 488);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(170, 45);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update Account";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.LightCoral;
            btnAdd.Location = new Point(29, 437);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 45);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add Account";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // cbRole
            // 
            cbRole.AutoCompleteCustomSource.AddRange(new string[] { "Teacher\t", "Admin", "Student" });
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Teacher", "Student", "Admin" });
            cbRole.Location = new Point(29, 376);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(170, 23);
            cbRole.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightCoral;
            label6.Location = new Point(29, 349);
            label6.Name = "label6";
            label6.Size = new Size(52, 24);
            label6.TabIndex = 16;
            label6.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(29, 300);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 28);
            txtPassword.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightCoral;
            label5.Location = new Point(29, 265);
            label5.Name = "label5";
            label5.Size = new Size(103, 24);
            label5.TabIndex = 14;
            label5.Text = "Password";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.LightCoral;
            btnSearch.Location = new Point(759, 103);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(170, 28);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(268, 103);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(481, 28);
            txtSearch.TabIndex = 23;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Black;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.LightCoral;
            btnLogout.Location = new Point(759, 31);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(170, 45);
            btnLogout.TabIndex = 22;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(268, 20);
            label1.Name = "label1";
            label1.Size = new Size(234, 56);
            label1.TabIndex = 21;
            label1.Text = "Welcome";
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 674);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbRole);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(TxtID);
            Name = "Library";
            Text = "Library";
            Load += Library_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox TxtID;
        private Button btnRemove;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cbRole;
        private Label label6;
        private TextBox txtPassword;
        private Label label5;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnLogout;
        private Label label1;
    }
}