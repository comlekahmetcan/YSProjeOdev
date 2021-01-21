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
    public partial class TaskStates : Form
    {
        public TaskStates()
        {
            InitializeComponent();
        }

        string temp,temp3;
        string abTemp;
        int durum1 = 1;
        int durum2 = 2;
        int durum3 = 3;
        int durum4 = 4;
        int durum5 = 5;
        #region dragEnter
        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.Move;
        }
        #endregion
        #region DragOver
        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.All;
        }
        #endregion
        ListBox listbox_Item_Alinan;
        ListBox lstbox_Item_Birakilan;
        int Listbox_Index = 0;
        object a = null;
       
        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            a = sender;
            listbox_Item_Alinan = sender as ListBox;

            temp3 = (listbox_Item_Alinan.Name).ToString();//ALINAN ITMIN NAMESI TEMPP3 E AKTARILIYOR
          
            Point kor_nokta = new Point(e.X, e.Y);
            Listbox_Index = listbox_Item_Alinan.IndexFromPoint(kor_nokta);
            if (Listbox_Index == -1)
                return;
            if (e.Button == MouseButtons.Left)
            {//TEMP3 NAMAESI HANGI LİSTBOXA ESITSE ORADA SECILEN ITEMI TEMP E AKTARIYORUZ
                if (temp3 == "Todo")
                {
                    int selectedIndex = Todo.SelectedIndex;

                    temp = Todo.SelectedItem.ToString();

                }
                else if (temp3 == "listBox2")
                {
                    temp = listBox2.SelectedItem.ToString();

                }
                else if (temp3 == "listBox3")
                {
                    temp = listBox3.SelectedItem.ToString();

                }
                else if (temp3 == "listBox4")
                {
                    temp = listBox4.SelectedItem.ToString();

                }
                else if (temp3 == "listBox5")
                {
                    temp = listBox5.SelectedItem.ToString();

                }

                listbox_Item_Alinan.DoDragDrop(listbox_Item_Alinan.Items[Listbox_Index].ToString(), DragDropEffects.All); }
          
          
            MessageBox.Show(temp);

        }
        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            ListBox ab = (ListBox)sender;
            //secili listboxtakı ıtemın name ni abTemp'e aktarıyoruz
            abTemp = ab.Name.ToString();

           
            
            
            if(a != sender || a != null) //ALDIGIMIZ YERE KATINCA HATA ALMAMAK ICIN
            {

          
            lstbox_Item_Birakilan = sender as ListBox;
            lstbox_Item_Birakilan.Items.Add(listbox_Item_Alinan.Items[Listbox_Index]);
            listbox_Item_Alinan.Items.Remove(listbox_Item_Alinan.Items[Listbox_Index]);
               
                
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select *from Tasks where TaskName like '" + temp + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            // textbox ıcındekı verıyı

            while (read.Read())
            {//TEMP ICDISI TEXTBOX1E YAZDIRIYORZ
                textBox1.Text = read["TaskID"].ToString();
            }

            baglanti.Close();

                #region SURUKLE BIRAK DURUM ID GUNCELLEME
                // ABTEMP HANGI LISTBOXA ESITSE O LİSTBOXA EKLIYORUZ TASK VE TASKSTATESS TABLOLARINI GUNCELLIYORUZ

                if (abTemp == "listBox2")
                {
                    baglanti.Open();

                    SqlCommand cmd = new SqlCommand("Update Tasks SET DurumID=@DurumID where TaskID=@TaskID", baglanti);
                    cmd.Parameters.AddWithValue("@TaskID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@DurumID", durum2);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();

                    SqlCommand cmd2 = new SqlCommand("Update TaskStatess SET DurumID=@DurumID where TaskID=@TaskID", baglanti);
                    cmd2.Parameters.AddWithValue("@TaskID", textBox1.Text);
                    cmd2.Parameters.AddWithValue("@DurumID", durum2);
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                }
                if (abTemp == "listBox3")
                {
                    baglanti.Open();

                    SqlCommand cmd = new SqlCommand("Update Tasks SET DurumID=@DurumID where TaskID=@TaskID", baglanti);
                    cmd.Parameters.AddWithValue("@TaskID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@DurumID", durum3);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();

                    SqlCommand cmd2 = new SqlCommand("Update TaskStatess SET DurumID=@DurumID where TaskID=@TaskID", baglanti);
                    cmd2.Parameters.AddWithValue("@TaskID", textBox1.Text);
                    cmd2.Parameters.AddWithValue("@DurumID", durum3);
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                }
                if (abTemp == "listBox4")
                {
                    baglanti.Open();

                    SqlCommand cmd = new SqlCommand("Update Tasks SET DurumID=@DurumID where TaskID=@TaskID", baglanti);
                    cmd.Parameters.AddWithValue("@TaskID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@DurumID", durum4);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();

                    SqlCommand cmd2 = new SqlCommand("Update TaskStatess SET DurumID=@DurumID where TaskID=@TaskID", baglanti);
                    cmd2.Parameters.AddWithValue("@TaskID", textBox1.Text);
                    cmd2.Parameters.AddWithValue("@DurumID", durum4);
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                }
                if (abTemp == "listBox5")
                {
                    baglanti.Open();

                    SqlCommand cmd = new SqlCommand("Update Tasks SET DurumID=@DurumID where TaskID=@TaskID", baglanti);
                    cmd.Parameters.AddWithValue("@TaskID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@DurumID", durum5);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();

                    SqlCommand cmd2 = new SqlCommand("Update TaskStatess SET DurumID=@DurumID where TaskID=@TaskID", baglanti);
                    cmd2.Parameters.AddWithValue("@TaskID", textBox1.Text);
                    cmd2.Parameters.AddWithValue("@DurumID", durum5);
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                }
                if (abTemp == "Todo")
                {
                    baglanti.Open();

                    SqlCommand cmd = new SqlCommand("Update Tasks SET DurumID=@DurumID where TaskID=@TaskID", baglanti);
                    cmd.Parameters.AddWithValue("@TaskID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@DurumID", durum1);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();

                    SqlCommand cmd2 = new SqlCommand("Update TaskStatess SET DurumID=@DurumID where TaskID=@TaskID", baglanti);
                    cmd2.Parameters.AddWithValue("@TaskID", textBox1.Text);
                    cmd2.Parameters.AddWithValue("@DurumID", durum1);
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
           
            
        }
        #endregion 
        private ListBox ListBox(string name)
        {
            throw new NotImplementedException();
        }

        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-R1JGFU3\\SQLEXPRESS;Initial Catalog=TeknikKart;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            TeknikKart TeknikKart1 = new TeknikKart();
            TeknikKart1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();

        }

      

        private void TaskStates_Load(object sender, EventArgs e)
        {
            #region ALLOW DROP
            Todo.AllowDrop = true;
            listBox2.AllowDrop = true;
            listBox3.AllowDrop = true;
            listBox4.AllowDrop = true;
            listBox5.AllowDrop = true;
            #endregion
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tasks ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            Todo.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            while (read.Read())
            {
                
                temp = read["DurumID"].ToString();
                if (temp == "1")
                {
                    Todo.Items.Add(read["TaskName"].ToString());
                }
                if (temp == "2")
                {
                    listBox2.Items.Add(read["TaskName"].ToString());
                }
                if (temp == "3")
                {
                    listBox3.Items.Add(read["TaskName"].ToString());
                }
                if (temp == "4")
                {
                    listBox4.Items.Add(read["TaskName"].ToString());
                }
                if (temp == "5")
                {
                    listBox5.Items.Add(read["TaskName"].ToString());
                }


            }
            baglanti.Close();

        }
    }
}
