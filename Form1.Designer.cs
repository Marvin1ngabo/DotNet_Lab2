namespace App2
{
    partial class login_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnclose = new Button();
            lbluser = new Label();
            lblpass = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            btnlogin = new Button();
            lblheader = new Label();
            SuspendLayout();
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.LightSlateGray;
            btnclose.Location = new Point(891, 521);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(348, 81);
            btnclose.TabIndex = 0;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(47, 216);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(155, 41);
            lbluser.TabIndex = 1;
            lbluser.Text = "username:";
            lbluser.Click += label1_Click;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Location = new Point(47, 333);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(152, 41);
            lblpass.TabIndex = 2;
            lblpass.Text = "password:";
            lblpass.Click += label2_Click;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(247, 216);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(389, 47);
            txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(247, 333);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(389, 47);
            txtpass.TabIndex = 4;
            txtpass.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(357, 521);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(333, 81);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // lblheader
            // 
            lblheader.BackColor = Color.LightSlateGray;
            lblheader.Font = new Font("Segoe UI", 16F);
            lblheader.ForeColor = Color.BlanchedAlmond;
            lblheader.Location = new Point(345, 54);
            lblheader.Name = "lblheader";
            lblheader.Size = new Size(736, 85);
            lblheader.TabIndex = 7;
            lblheader.Text = "Welcome, please log in";
            lblheader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login_form
            // 
            AcceptButton = btnlogin;
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1458, 674);
            Controls.Add(lblheader);
            Controls.Add(btnlogin);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(lblpass);
            Controls.Add(lbluser);
            Controls.Add(btnclose);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "login_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnclose;
        private Label lbluser;
        private Label lblpass;
        private TextBox txtuser;
        private TextBox txtpass;
        private Button btnlogin;
        private Label lblheader;
    }
}
