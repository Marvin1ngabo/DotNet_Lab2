namespace App2
{
    partial class Form_choose
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
            btnbicycle = new Button();
            btnmushroom = new Button();
            lblchoose = new Label();
            SuspendLayout();
            // 
            // btnbicycle
            // 
            btnbicycle.BackColor = Color.LightCyan;
            btnbicycle.Location = new Point(194, 334);
            btnbicycle.Name = "btnbicycle";
            btnbicycle.Size = new Size(303, 79);
            btnbicycle.TabIndex = 1;
            btnbicycle.Text = "Bicycle";
            btnbicycle.UseVisualStyleBackColor = false;
            btnbicycle.Click += btnbicycle_Click;
            // 
            // btnmushroom
            // 
            btnmushroom.BackColor = Color.LightCyan;
            btnmushroom.Location = new Point(1023, 334);
            btnmushroom.Name = "btnmushroom";
            btnmushroom.Size = new Size(306, 79);
            btnmushroom.TabIndex = 2;
            btnmushroom.Text = "Mushroom";
            btnmushroom.UseVisualStyleBackColor = false;
            btnmushroom.Click += btnmushroom_Click;
            // 
            // lblchoose
            // 
            lblchoose.AutoSize = true;
            lblchoose.Location = new Point(641, 151);
            lblchoose.Name = "lblchoose";
            lblchoose.Size = new Size(281, 41);
            lblchoose.TabIndex = 3;
            lblchoose.Text = "Choose a Program !";
            // 
            // Form_choose
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1533, 693);
            Controls.Add(lblchoose);
            Controls.Add(btnmushroom);
            Controls.Add(btnbicycle);
            Name = "Form_choose";
            Text = "Choose";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnbicycle;
        private Button btnmushroom;
        private Label lblchoose;
    }
}