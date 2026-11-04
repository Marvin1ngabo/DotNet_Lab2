using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App2
{
    public partial class Form_bicycle : Form
    {
        public Form_bicycle()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtstart.Text == "" || txtend.Text == "")
                {
                    MessageBox.Show("Please enter the start hour and the end hour");
                }
                else if (txtstart.Text.Contains(".") || txtstart.Text.Contains(",") || txtend.Text.Contains(".") || txtend.Text.Contains(","))
                {
                    MessageBox.Show("Decimal numbers are not accepted");
                }
                else
                {
                    int start = Convert.ToInt32(txtstart.Text);
                    int end = Convert.ToInt32(txtend.Text);

                    if (start < 0 || start > 23)
                    {
                        MessageBox.Show("The start hour must be between 0 and 23");
                    }
                    else if (end < 1 || end > 24)
                    {
                        MessageBox.Show("The end hour must be between 1 and 24");
                    }
                    else if (start >= end)
                    {
                        MessageBox.Show("The start hour must be less than the end hour");
                    }
                    else
                    {
                        int total = 0;

                        for (int hour = start; hour < end; hour++)
                        {
                            if (hour < 7)
                            {
                                total = total + 500;
                            }
                            else if (hour < 14)
                            {
                                total = total + 1000;
                            }
                            else if (hour < 19)
                            {
                                total = total + 1500;
                            }
                            else if (hour < 21)
                            {
                                total = total + 1000;
                            }
                            else
                            {
                                total = total + 500;
                            }
                        }

                        txttotal.Text = total + " RWF";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please enter whole numbers only.");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            login.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form_choose choose = new Form_choose();
            choose.Show();
            this.Hide();
        }
    }
}
