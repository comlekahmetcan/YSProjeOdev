using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikKartOdev1
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

      

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void txtTeknikKartEKLE_Click(object sender, EventArgs e)
        {
            TeknikKartEkeForm TeknikKartEkeForm = new TeknikKartEkeForm();
            TeknikKartEkeForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeknikKart TeknikKart = new TeknikKart();
            TeknikKart.Show();
            this.Hide();
           
        }
    }
}
