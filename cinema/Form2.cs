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

namespace sinema
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            yerler();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source =.\\sqlexpress; Initial Catalog = Sinema_Bileti; Integrated Security = True");




        }

        public static List<CheckBox> oturacaklar = new List<CheckBox>();
        public static List<CheckBox> al = new List<CheckBox>();
        public static List<CheckBox> reserve = new List<CheckBox>();
        public int kes = -5;
        public int x = 50;
        public int fiyat = 5;
        public int dolu = 1;
        public int y =50;
        public int c = 1;
        public int v = 1;
    
        public void yerler()
        {
            
            for (int i = 0; i < 10; i++)
            {
                var text = new Label();
                text.Text =  v.ToString();
                v++;
                text.Width = 30;
                text.Height = 50;
                text.Font = new Font("Microsoft Sans Serif", 13.6f);
                text.Top = 57 + (i * 50);
                text.Left = 17;
                text.BackColor = Color.Transparent;
                text.ForeColor = Color.White;
               
                this.Controls.Add(text);
                c = 1;
                for (int a = 0; a < 7; a++)
                {
                               
                    var yer = new CheckBox();
                    yer.Text = c.ToString();
                    c ++;
                    yer.Width = 40;
                    
                    yer.Height = 40;
                    yer.Left =x+(a*70);
                    yer.Top = y+(i*50);
                    yer.Appearance = Appearance.Button;
                    yer.FlatAppearance.BorderSize = 2;
                    yer.BackColor = Color.White;
                    oturacaklar.Add(yer);
                    yer.Click += new EventHandler(Button1_Click);
                   
                       
                   
                    this.Controls.Add(yer);

                }
            }


        }
        
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }


        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        Random say = new Random();
        
        private void Button1_Click(object sender, EventArgs e)
        {

            int result = dolu * fiyat;
            int result2 = result - 5;
           

            CheckBox btn = (CheckBox)sender;
            if (btn.CheckState == CheckState.Checked)
            {
                dolu++;
                label1.Text = result.ToString();
                btn.BackColor = Color.Aqua;
                al.Add(btn);
                reserve.Add(btn);
                
            }
            if (btn.CheckState == CheckState.Unchecked)
            {
                dolu--;
                label1.Text = (result - 10).ToString();
                al.Remove(btn);
                reserve.Remove(btn);
                btn.BackColor = Color.Empty;
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int tahmini = say.Next(1000,9999);
            for (int i = 0; i < al.Count; i++)
            {
                al[i].BackColor = Color.Red;
                
            }
            MessageBox.Show("Bizi tercih ettiğiniz için teşekkür ederiz!" + "\r\n" + "Sizin bilet kodunuz " + tahmini + " budur." + "\r\n" + "P.S: Kod bir daha gosterilmez!");
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int tahmini = say.Next(1000, 9999);
            for (int i = 0; i < reserve.Count; i++)
            {
                reserve[i].BackColor = Color.Green;

            }
            MessageBox.Show("Bileti ayırdınız!" + "\r\n" + "Sizin bilet kodunuz " + tahmini + " budur." + "\r\n" + "P.S: Kod bir daha gosterilez!");
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
