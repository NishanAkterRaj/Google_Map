using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Search_data_Click(object sender, EventArgs e)
        {
            string street = text_street.Text;
            string city = text_city.Text;
            string state = text_state.Text;
            string zip = text_zip.Text;
            try {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://www.google.com/maps/@23.7985508,90.3654215,15z?");


                if(street != string.Empty)
                {
                    queryaddress.Append(street + "," + "+");
                }
                if(city != string.Empty)
                {
                    queryaddress.Append(city + "," + "+");
                }
                if (state != string.Empty)
                {
                    queryaddress.Append(state + "," + "+");
                }
                if (zip != string.Empty)
                {
                    queryaddress.Append(zip + "," + "+");
                }
                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Error");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void text_zip_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
