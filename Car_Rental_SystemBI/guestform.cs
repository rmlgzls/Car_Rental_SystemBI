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
    public partial class guestform : Form
    {
        public guestform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Show();
        }

        private void guestform_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 0, 75, 125);
        }
    }
}
