using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App2
{
    public partial class Form_mushroom : Form
    {
        int step = 0;
        string ring = "";

        public Form_mushroom()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            step = 1;
            ring = "";
            lblresult.Text = "";
            lblinfo.Text = "Does your mushroom have a ring? (type yes or no)";
            txtanswer.Clear();
            txtanswer.Focus();
        }

        private void btnanswer_Click_1(object sender, EventArgs e)
        {
            string answer = txtanswer.Text.ToLower();
            string mushroom = "";

            if (step == 0)
            {
                MessageBox.Show("Please click Start first");
            }
            else if (answer != "yes" && answer != "no")
            {
                MessageBox.Show("Please type only yes or no");
            }
            else
            {
                if (step == 1)
                {
                    ring = answer;

                    if (ring == "yes")
                    {
                        lblinfo.Text = "Does your mushroom grow in a forest? (type yes or no)";
                        step = 2;
                    }
                    else
                    {
                        lblinfo.Text = "Does your mushroom have gills? (type yes or no)";
                        step = 3;
                    }
                }
                else if (step == 2)
                {
                    if (answer == "yes")
                    {
                        mushroom = "Amanite tue-mouches";
                    }
                    else
                    {
                        lblinfo.Text = "Does your mushroom have a convex cup? (type yes or no)";
                        step = 4;
                    }
                }
                else if (step == 3)
                {
                    if (answer == "no")
                    {
                        mushroom = "Cepe de bordeaux";
                    }
                    else
                    {
                        lblinfo.Text = "Does your mushroom have a convex cup? (type yes or no)";
                        step = 4;
                    }
                }
                else if (step == 4)
                {
                    if (ring == "yes" && answer == "yes")
                    {
                        mushroom = "Agaric jaunissant";
                    }
                    else if (ring == "yes" && answer == "no")
                    {
                        mushroom = "Coprin chevelu";
                    }
                    else if (ring == "no" && answer == "yes")
                    {
                        mushroom = "Pied bleu";
                    }
                    else
                    {
                        mushroom = "Girolle";
                    }
                }

                if (mushroom != "")
                {
                    lblresult.Text = "Your mushroom is: " + mushroom;
                    MessageBox.Show("Your mushroom is: " + mushroom);
                    step = 0;
                    lblinfo.Text = "Click Start to play again.";
                }
            }

            txtanswer.Clear();
            txtanswer.Focus();
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