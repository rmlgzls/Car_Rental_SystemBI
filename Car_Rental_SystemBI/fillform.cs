using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MySql.Data.MySqlClient;


namespace Car_Rental_SystemBI
{
    public partial class fillform : Form
    {

        ConnectionState connect = new ConnectionState();
        MySqlConnection cn;
        MySqlCommand command;
        MySqlDataReader dr;
        string connectionString = "Server = 127.0.0.1; User Id = root; Password=root;Database= cardb;";

        public fillform()
        {
            InitializeComponent();
            cn = new MySqlConnection(connectionString);

        }

        public void insert(int carid)
        {


            try
            {
                cn.Open();
                command = new MySqlCommand("Insert into renttbl (lname, fname,mname, bmonth, dy,yr,age,region,province,city,district,email,contactno,pickdate,returndate, carid) VALUES (@lname, @fname,@mname, @bmonth, @dy,@yr,@age,@region,@province,@city,@district,@email,@contactno,@pickdate,@returndate, @carid) ", cn);
                command.Parameters.AddWithValue("@lname", txtlname.Text);
                command.Parameters.AddWithValue("@fname", txtfname.Text);
                command.Parameters.AddWithValue("@mname", txtmname.Text);
                command.Parameters.AddWithValue("@bmonth", txtbmonth.Text);
                command.Parameters.AddWithValue("@dy", txtday.Text);
                command.Parameters.AddWithValue("@yr", txtyr.Text);
                command.Parameters.AddWithValue("@age", txtage.Text);
                command.Parameters.AddWithValue("@region", txtregion.Text);
                command.Parameters.AddWithValue("@province", txtprov.Text);
                command.Parameters.AddWithValue("@city", txtcity.Text);
                command.Parameters.AddWithValue("@district", txtdistrict.Text);
                command.Parameters.AddWithValue("@email", txtemail.Text);
                command.Parameters.AddWithValue("@contactno", txtcontactno.Text);
                command.Parameters.AddWithValue("@pickdate", txtpickup.Value);
                command.Parameters.AddWithValue("@returndate", txtreturndate.Value);
                command.Parameters.AddWithValue("@carid", carid);
                dr = command.ExecuteReader();

                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Inside a method or event handler:
            MessageBox.Show("Succesfully Submit!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public void carmod(int carid)
        {


            try
            {
                cn.Open();
                command = new MySqlCommand("select carid from car where carid = @carid");
                command.Parameters.AddWithValue("carid", carid);

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fillform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 1;
            carmod(id);
            carid.Text = id.ToString();

            insert(id);
        }

        private void txtbmonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtyr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void carid_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog(); 
            this.Show();

        }
    }
}
