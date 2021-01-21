using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//Data Source=DESKTOP-R1JGFU3\SQLEXPRESS;Initial Catalog=TeknikKart;Integrated Security=True

namespace TeknikKartOdev1
{
    public partial class TeknikKartEkeForm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-R1JGFU3\\SQLEXPRESS;Initial Catalog=TeknikKart;Integrated Security=True");
        public TeknikKartEkeForm()
        {
            InitializeComponent();
        }
        static  public  string taskId;
        #region int deger girne
        private void keypress(object sender , KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        int modified;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void TeknikKartEkeForm_Load(object sender, EventArgs e)
        {

        }
      

        private void txtTaskEkle_Click(object sender, EventArgs e)
        {
            if(txtDurumID.Text==" " || txtTaskName.Text == "" ||txtUserID.Text==" " || richTextBox1.Text== " " || richTextBox2.Text==" " )
            {
                MessageBox.Show("Lutfen tum alanları doldurunuz");
            }
            else { 
            int d1 = int.Parse(txtDurumID.Text);
            int d2 = int.Parse(txtUserID.Text);
            string d3 = richTextBox2.Text;
            if (baglanti.State == ConnectionState.Closed)
            {
               
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                
                cmd.CommandText = "INSERT INTO Tasks(TaskName,isAcıklama,Notlar,DurumID,UserID,BaşlangıçTarihi) VALUES('" + txtTaskName.Text + "','" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + int.Parse(txtDurumID.Text) + "','" + int.Parse(txtUserID.Text) + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "'); select @@identity";


                

                //TaskID ALIYORUZ
                 modified = int.Parse(cmd.ExecuteScalar().ToString());
                cmd.Dispose();

                baglanti.Close();

              
            }
            //TaskStates 
            if (baglanti.State == ConnectionState.Closed)
            {

                baglanti.Open();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = baglanti;
               
                cmd2.CommandText = "INSERT INTO TaskStatess(TaskID,DurumID,Notlar,TaskStateDate,userID) VALUES('" + modified + "','" + d1 + "','" + d3 + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + d2+ "')";


             
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();

                baglanti.Close();

              

            }

            TeknikKart TeknikKart = new TeknikKart();
            TeknikKart.Show();
            this.Hide();
        }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            TaskStates TaskStatess = new TaskStates();
            TaskStatess.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            TeknikKart TeknikKart1 = new TeknikKart();
            TeknikKart1.Show();
            this.Hide();
        }
    }
}
