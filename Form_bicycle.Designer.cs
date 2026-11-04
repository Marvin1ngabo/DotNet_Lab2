namespace App2
{
    partial class Form_bicycle
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
            lblstart = new Label();
            lblend = new Label();
            txtstart = new TextBox();
            txtend = new TextBox();
            btncalculate = new Button();
            lbltotal = new Label();
            txttotal = new TextBox();
            btnexit = new Button();
            btnback = new Button();
            SuspendLayout();
            // 
            // lblstart
            // 
            lblstart.AutoSize = true;
            lblstart.Location = new Point(56, 156);
            lblstart.Name = "lblstart";
            lblstart.Size = new Size(266, 41);
            lblstart.TabIndex = 0;
            lblstart.Text = "Start hour (0 to 23)";
            // 
            // lblend
            // 
            lblend.AutoSize = true;
            lblend.Location = new Point(56, 282);
            lblend.Name = "lblend";
            lblend.Size = new Size(256, 41);
            lblend.TabIndex = 1;
            lblend.Text = "End hour (1 to 24)";
            // 
            // txtstart
            // 
            txtstart.Location = new Point(328, 156);
            txtstart.Name = "txtstart";
            txtstart.Size = new Size(585, 47);
            txtstart.TabIndex = 2;
            // 
            // txtend
            // 
            txtend.Location = new Point(328, 276);
            txtend.Name = "txtend";
            txtend.Size = new Size(585, 47);
            txtend.TabIndex = 3;
            txtend.TextChanged += textBox2_TextChanged;
            // 
            // btncalculate
            // 
            btncalculate.BackColor = Color.LightCyan;
            btncalculate.Location = new Point(963, 265);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(262, 58);
            btncalculate.TabIndex = 4;
            btncalculate.Text = "Calculate";
            btncalculate.UseVisualStyleBackColor = false;
            btncalculate.Click += btncalculate_Click;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(231, 477);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(81, 41);
            lbltotal.TabIndex = 5;
            lbltotal.Text = "Total";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(328, 474);
            txttotal.Name = "txttotal";
            txttotal.ReadOnly = true;
            txttotal.Size = new Size(294, 47);
            txttotal.TabIndex = 6;
            txttotal.TextChanged += textBox1_TextChanged;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.LightCyan;
            btnexit.Location = new Point(1444, 599);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(235, 58);
            btnexit.TabIndex = 7;
            btnexit.Text = "Logout";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // btnback
            // 
            btnback.BackColor = Color.LightCyan;
            btnback.Location = new Point(1156, 599);
            btnback.Name = "btnback";
            btnback.Size = new Size(234, 58);
            btnback.TabIndex = 8;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // Form_bicycle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1763, 721);
            Controls.Add(btnback);
            Controls.Add(btnexit);
            Controls.Add(txttotal);
            Controls.Add(lbltotal);
            Controls.Add(btncalculate);
            Controls.Add(txtend);
            Controls.Add(txtstart);
            Controls.Add(lblend);
            Controls.Add(lblstart);
            Name = "Form_bicycle";
            Text = "Bicycle Rental";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblstart;
        private Label lblend;
        private TextBox txtstart;
        private TextBox txtend;
        private Button btncalculate;
        private Label lbltotal;
        private TextBox txttotal;
        private Button btnexit;
        private Button btnback;
    }
}