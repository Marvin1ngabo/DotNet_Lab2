using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App2
{
    public partial class Form_choose : Form
    {
        public Form_choose()
        {
            InitializeComponent();
        }

        private void btnbicycle_Click(object sender, EventArgs e)
        {
            Form_bicycle bicycle = new Form_bicycle();
            bicycle.Show();
            this.Hide();
        }

        private void btnmushroom_Click(object sender, EventArgs e)
        {
            Form_mushroom mushroom = new Form_mushroom();
            mushroom.Show();
            this.Hide();
        }
    }
}
