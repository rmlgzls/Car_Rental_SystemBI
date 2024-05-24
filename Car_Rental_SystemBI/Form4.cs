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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 form5 = new Form5();
            form5.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string car_rented;
            car_rented = "car3";
            fillform fillform = new fillform();
            fillform.ShowDialog();
            this.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
