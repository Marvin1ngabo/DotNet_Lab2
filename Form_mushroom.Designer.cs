namespace App2
{
    partial class Form_mushroom
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
            lblinfo = new Label();
            btnstart = new Button();
            btnexit = new Button();
            lblresult = new Label();
            txtanswer = new TextBox();
            btnanswer = new Button();
            btnback = new Button();
            SuspendLayout();
            // 
            // lblinfo
            // 
            lblinfo.AutoSize = true;
            lblinfo.Location = new Point(96, 147);
            lblinfo.Name = "lblinfo";
            lblinfo.Size = new Size(552, 41);
            lblinfo.TabIndex = 0;
            lblinfo.Text = "Think of one mushroom, then click Start.";
            // 
            // btnstart
            // 
            btnstart.BackColor = Color.LightCyan;
            btnstart.Location = new Point(1554, 141);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(209, 52);
            btnstart.TabIndex = 1;
            btnstart.Text = "Start";
            btnstart.UseVisualStyleBackColor = false;
            btnstart.Click += btnstart_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.LightCyan;
            btnexit.Location = new Point(1515, 623);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(188, 58);
            btnexit.TabIndex = 2;
            btnexit.Text = "Logout";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(262, 242);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(0, 41);
            lblresult.TabIndex = 3;
            // 
            // txtanswer
            // 
            txtanswer.Location = new Point(966, 144);
            txtanswer.Name = "txtanswer";
            txtanswer.Size = new Size(369, 47);
            txtanswer.TabIndex = 4;
            // 
            // btnanswer
            // 
            btnanswer.BackColor = Color.LightCyan;
            btnanswer.Location = new Point(1360, 142);
            btnanswer.Name = "btnanswer";
            btnanswer.Size = new Size(188, 51);
            btnanswer.TabIndex = 5;
            btnanswer.Text = "Answer";
            btnanswer.UseVisualStyleBackColor = false;
            btnanswer.Click += btnanswer_Click_1;
            // 
            // btnback
            // 
            btnback.BackColor = Color.LightCyan;
            btnback.Location = new Point(1221, 623);
            btnback.Name = "btnback";
            btnback.Size = new Size(188, 58);
            btnback.TabIndex = 6;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // Form_mushroom
            // 
            AcceptButton = btnanswer;
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1764, 728);
            Controls.Add(btnback);
            Controls.Add(btnanswer);
            Controls.Add(txtanswer);
            Controls.Add(lblresult);
            Controls.Add(btnexit);
            Controls.Add(btnstart);
            Controls.Add(lblinfo);
            Name = "Form_mushroom";
            Text = "Mushroom Finder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblinfo;
        private Button btnstart;
        private Button btnexit;
        private Label lblresult;
        private TextBox txtanswer;
        private Button btnanswer;
        private Button btnback;
    }
}