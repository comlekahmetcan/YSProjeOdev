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
namespace TeknikKartOdev1
{
    public partial class TeknikKart : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-R1JGFU3\\SQLEXPRESS;Initial Catalog=TeknikKart;Integrated Security=True");
        public TeknikKart()
        {
            InitializeComponent();
        }
        string i;
        string d1, d2, d3, d4, d5, d6;
        #region int deger girne
        private void keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        TeknikKartEntities2 dab = new TeknikKartEntities2();
        


        void listeleme()
          
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select *from TaskStatess";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "TaskStatess");
              
                dataGridView1.DataSource = ds.Tables["TaskStatess"];
                baglanti.Close();

            }
        }


       
        private void TeknikKart_Load(object sender, EventArgs e)
        {
            //txtKartNO.Text=  TeknikKartEkeForm.taskId;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listeleme();
            comboBox1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tasks  ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            
            while(read.Read())
            {
                comboBox1.Items.Add(read["TaskID"].ToString());
                
            }
            
            baglanti.Close();

            var sorgu = from d1 in dab.TaskStatess
                        join d2 in dab.Durumlar
                        on d1.DurumID equals d2.DurumID
                        join d3 in dab.Users
                        on d1.userID equals d3.UserID
                        join d4 in dab.Tasks
                        on d1.TaskID equals d4.TaskID
                        
                        select new
                        {
                            Durumu = d2.DurumName,
                            TeknikUzman = d3.UserName,
                            Proje = d4.TaskName,
                            Açıklama=d4.isAcıklama

                            
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void txtGuncelle_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("Update Tasks SET UserID=@UserID, isAcıklama=@isAcıklama ,Notlar=@Notlar where TaskID=@TaskID", baglanti);
            cmd.Parameters.AddWithValue("@TaskID", Convert.ToInt32(comboBox1.Text));
            cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(txtUserNO.Text));
            cmd.Parameters.AddWithValue("@isAcıklama", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@Notlar", richTextBox2.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskStates TaskStatess = new TaskStates();
            TaskStatess.Show();
            this.Hide();
        }

       

        private void txtKartNO_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tasks where TaskID like '" + comboBox1.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();

            string tarih = dateTimePicker1.Value.ToString();
            while (read.Read())
            {   
                txtUserNO.Text = read["UserID"].ToString();
                richTextBox1.Text = read["isAcıklama"].ToString();
                richTextBox2.Text = read["Notlar"].ToString();
                tarih = read["BaşlangıçTarihi"].ToString();
               

            }
          
            baglanti.Close();
            

            string i = txtUserNO.Text;
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select *from Users where UserID like '" + i + "'", baglanti);

            SqlDataReader read2 = komut2.ExecuteReader();

            while (read2.Read())
            {
                txtUserName.Text = read2["UserName"].ToString();

            }

            baglanti.Close();

        }
            
        
       

        private void txtUserNO_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
