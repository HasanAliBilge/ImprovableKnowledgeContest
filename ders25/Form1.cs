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

namespace ders25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   
        SqlConnection baglan=new SqlConnection("Data Source=DESKTOP-HHKVQ55\\SQLEXPRESS;Initial Catalog=bilgiyarismasi;Integrated Security=True;");

        private void Form1_Load(object sender, EventArgs e)
        {
           label7.Visible = false;
            label8.Visible = false;
            
        }
        int sayaç=0;
        int label12nindeğeri=5;
        
       
        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = SystemColors.Window;
            timer1.Enabled = true;
            sayaç++;
            label12nindeğeri = label12nindeğeri + 5;
            label12.Text=label12nindeğeri.ToString();
            Convert.ToInt32(label10.Text);
            label10.Text = sayaç.ToString();
            button1.BackColor= SystemColors.Window;
            button2.BackColor= SystemColors.Window;
            button3.BackColor= SystemColors.Window;
            button4.BackColor= SystemColors.Window;
           
            button5.Text = "İleri";
            if (sayaç == 1){
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from sorular order by NEWID()", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                button1.Text = (oku["a"].ToString());
                button2.Text = (oku["b"].ToString());
                button3.Text = (oku["c"].ToString());
                button4.Text = (oku["d"].ToString());
                richTextBox1.Text = oku["soru"].ToString();
                label7.Text = (oku["dogru"].ToString());


                    


            } baglan.Close();
            
               
               

            }
            
            if (sayaç == 2)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    richTextBox1.Text = oku["soru"].ToString();
                    label7.Text = (oku["dogru"].ToString());




                }

                baglan.Close();
            }
            if (sayaç == 3)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    richTextBox1.Text = oku["soru"].ToString();
                    label7.Text = (oku["dogru"].ToString());



                    

                }

                baglan.Close();
            }
            if (sayaç == 4)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    richTextBox1.Text = oku["soru"].ToString();
                    label7.Text = (oku["dogru"].ToString());





                }

                baglan.Close();
                
            }
            if (sayaç == 5)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    richTextBox1.Text = oku["soru"].ToString();
                    label7.Text = (oku["dogru"].ToString());





                }

                baglan.Close();
            }
            if (sayaç == 6)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular6 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    richTextBox1.Text = oku["soru"].ToString();
                    label7.Text = (oku["dogru"].ToString());





                }

                baglan.Close();
            }
            if (sayaç == 7)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular7 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    richTextBox1.Text = oku["soru"].ToString();
                    label7.Text = (oku["dogru"].ToString());





                }

                baglan.Close();
            }
            if (sayaç == 8)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular8 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    richTextBox1.Text = oku["soru"].ToString();
                    label7.Text = (oku["dogru"].ToString());





                }

                baglan.Close();
            }
            if (sayaç == 9)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular9 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    richTextBox1.Text = oku["soru"].ToString();
                    label7.Text = (oku["dogru"].ToString());





                }

                baglan.Close();
            }
            if (sayaç == 10)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular10 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    richTextBox1.Text = oku["soru"].ToString();
                    label7.Text = (oku["dogru"].ToString());





                }

                baglan.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            label8.Text=button1.Text;  
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button1.BackColor = Color.Aqua;
            if (label8.Text == label7.Text)
            {
                int değer = Convert.ToInt32(label5.Text);
                değer++;
                label5.Text = değer.ToString();
                int value = Convert.ToInt32(label4.Text);
                value = value + 10;
                label4.Text = value.ToString();
                timer1.Stop();
                richTextBox1.BackColor = Color.Turquoise;

            }
            else if (sayaç > 0 && label8.Text != label7.Text)
            {
                int değer = Convert.ToInt32(label6.Text);
                değer++;
                label6.Text = değer.ToString();
                int value = Convert.ToInt32(label4.Text);
                value = value - 10;
                label4.Text = value.ToString();
                timer1.Stop();
                richTextBox1.BackColor = Color.Pink;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            label8.Text = button2.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button2.BackColor = Color.Aqua;
            if (label8.Text == label7.Text)
            {
                int değer = Convert.ToInt32(label5.Text);
                değer++;
                label5.Text = değer.ToString();
                int value = Convert.ToInt32(label4.Text);
                value = value + 10;
                label4.Text = value.ToString();
                timer1.Stop();
                richTextBox1.BackColor = Color.Turquoise;
            }
            else if (sayaç > 0 && label8.Text != label7.Text)
            {
                int değer = Convert.ToInt32(label6.Text);
                değer++;
                label6.Text = değer.ToString();
                int value = Convert.ToInt32(label4.Text);
                value = value - 10;
                label4.Text = value.ToString();
                timer1.Stop();
                richTextBox1.BackColor = Color.Pink;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            label8.Text = button3.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button3.BackColor = Color.Aqua;
            if (label8.Text == label7.Text)
            {
                int değer = Convert.ToInt32(label5.Text);
                değer++;
                label5.Text = değer.ToString();
                int value = Convert.ToInt32(label4.Text);
                value = value + 10;
                label4.Text = value.ToString();
                timer1.Stop();
                richTextBox1.BackColor = Color.Turquoise;

            }
            else if (sayaç > 0 && label8.Text != label7.Text)
            {
                int değer = Convert.ToInt32(label6.Text);
                değer++;
                label6.Text = değer.ToString();
                int value = Convert.ToInt32(label4.Text);
                value = value - 10;
                label4.Text = value.ToString();
                timer1.Stop();
                richTextBox1.BackColor = Color.Pink;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            label8.Text = button4.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button4.BackColor = Color.Aqua;
            if (label8.Text == label7.Text)
            {
                int değer = Convert.ToInt32(label5.Text);
                değer++;
                label5.Text = değer.ToString();
                int value = Convert.ToInt32(label4.Text);
                value = value + 10;
                label4.Text = value.ToString();
                timer1.Stop();
                richTextBox1.BackColor = Color.Turquoise;
            }
            else if (sayaç > 0 && label8.Text != label7.Text)
            {
                int değer = Convert.ToInt32(label6.Text);
                değer++;
                label6.Text = değer.ToString();
                int value = Convert.ToInt32(label4.Text);
                value = value - 10;
                label4.Text = value.ToString();
                timer1.Stop();
                richTextBox1.BackColor = Color.Pink;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
          int  süre = Convert.ToInt32(label12.Text);
            süre = süre - 1;
            label12.Text = süre.ToString();
            if (süre == 0)
            {
                timer1.Stop();
                MessageBox.Show("Yarışmayı Kaybettiniz..(!)");
            }
        }
    }
    
}
