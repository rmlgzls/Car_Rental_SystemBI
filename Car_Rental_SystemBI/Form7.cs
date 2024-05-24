using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_SystemBI
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 form5 = new Form5();
            form5.ShowDialog();
            this.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 form8 = new Form8();
            form8.ShowDialog();
            this.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string car_rented;
            car_rented = "car5";
            fillform fillform = new fillform();
            fillform.ShowDialog();
            this.Show();
        }
    }
}
