using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zNetFramework.S19.D7.DinamikFormElemanları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            int mayin1 = 0;
            int mayin2 = 0;
            int mayin3 = 0;
            int ButonSayisi = 0;
            Random rnd1 = new Random();
            mayin1 = rnd1.Next(1, 20);
            mayin2 = rnd1.Next(20, 35);
            mayin3 = rnd1.Next(35, 50);
            foreach (Button item in flowLayoutPanel1.Controls)
            {
                ButonSayisi++;
            }
            for (int i = 1; i < 51; i++)
            {
                Button btn = new Button();
                btn.Name = "btn"+ i;
                btn.Size= new System.Drawing.Size(55, 55);
                btn.TabIndex = i - 1;
                btn.Text = "Mayın" + i;

               
                if (mayin1 == i || mayin2 == i || mayin3 == i)
                {
                    btn.Tag = true;
                }
                else
                {
                    btn.Tag = false;
                }
                

                if (ButonSayisi<50)
                {
                    flowLayoutPanel1.Controls.Add(btn);
                }
                btn.Click += btn_Click;

            }
            
            

        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button basilanbuton = (Button)sender;
            bool mayinbulundu =(bool) basilanbuton.Tag;
            if (mayinbulundu)
            {
                MessageBox.Show("Tebrikler,Mayını buldunuz!");
                basilanbuton.BackColor = Color.Red;
                int BulunanMayin = int.Parse(lblBulunanMayın.Text);
                BulunanMayin++;
                lblBulunanMayın.Text = BulunanMayin.ToString();

            }
            else
            {
                basilanbuton.BackColor = Color.Green;
                int Skor = int.Parse(lblSkor.Text);
                Skor++;
                lblSkor.Text = Skor.ToString();
            }
            if (int.Parse(lblBulunanMayın.Text) == 3)
            {
                //flowLayoutPanel1.Enabled = false; //foreach döngüsüne girmeden de bu şekilde halledilebilir.
                foreach (Button item in flowLayoutPanel1.Controls)
                {
                    item.Enabled = false;
                }
                MessageBox.Show("OYUN BİTTİ");

                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //this.button1.Location = new System.Drawing.Point(3, 3);
        //      this.button1.Name = "button1";
        //      this.button1.Size = new System.Drawing.Size(75, 23);
        //      this.button1.TabIndex = 0;
        //      this.button1.Text = "button1";
        //      this.button1.UseVisualStyleBackColor = true;
        //      this.button1.Click += new System.EventHandler(this.button1_Click);
        //YUKARIDAKİ KOD SATIRLARI İNİTİALİZE COMPONENTS İÇİNDEN ALINAN HERHANGİ BİR BUTONUN KOD SATIRALRIDIR,YUKARIDA KULLANMAK İÇİN BURAYA YORUM SATIRI OLARAK YAZDIM
    }
}
