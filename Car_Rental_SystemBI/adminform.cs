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
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminform_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 0, 75, 125);
        }
    }
}
