using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "Please, select any value";
            comboBox1.Items.Insert(0, "Secin: ");
            comboBox1.SelectedIndex = 0;
            comboBox1.Items.Add("Yüzüklerin Efendisi");
            comboBox1.Items.Add("Tenet");
            button1.FlatStyle = FlatStyle.Flat;
            button2.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            
            



        }
        SqlConnection baglanti = new SqlConnection("Data Source =.\\sqlexpress; Initial Catalog = Sinema_Bileti; Integrated Security = True");

        public void filmlerigoster(string fimler)
        {
            SqlDataAdapter da = new SqlDataAdapter(fimler, baglanti);
            DataSet ds = new DataSet();
            


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Yüzüklerin Efendisi")
            {
                button1.Text = "22:45";
                button1.Show();
                button2.Text = "10:00";
                button2.Show();


            }

                if (comboBox1.Text == "Tenet")
                {
                button1.Text = "16:00";
                button1.Show();
                button2.Text = "17:35";
                button2.Show();
                }
            if (comboBox1.Text == "Secin: ")
            {
                button1.Hide();
                button2.Hide();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            
                var ac = new Form2();
                ac.Show();
              
            
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
       
                var ac = new Form2();
                ac.Show();
 
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
