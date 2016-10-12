using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CiftlikOyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblSenaryo.Text = "Köyde evini herkesten uzağa yapmış, “Abdullah Çavuş”  olarak bilinen yaşlı yalnız bir adam yaşar. Abdullah Çavuş’un çok sayıda kuzusu\n\nve bir çoban köpeği vardır.  Sabah erkenden kuzuları evin önündeki ağıldan dışarı  çıkarır, akşamları da tekrar oraya toplar.  Abdullah \n\nÇavuş sabahları muhtelif işlerini yapar, öğleden sonra da çoğu akranının yaptığı gibi evlenme programı izler. Çoban köpeği de kuzular \n\notlarken onlara göz kulak olur. Akşam olunca çoban köpeği kuzuların etrafında havlayarak kuzuları ağıla yönlendirir. Günler böyle geçer. \n\nAncak, başları zaman zaman arazilerine giren kurtlarla derttedir. Kurtlar arazilerine girdiğinde, köpekle kurtların mücadelesi başlar. Kurtlar \n\nhemen kendilerine en yakın kuzuya yönelerek yakalamaya çalışırlar. Köpekse kurtlar yakalamadan, kuzuları kurtlardan uzaklaştırmaya, \n\nevin önündeki güvenli ağıla toplamaya çalışır. Akşam olunca Abdullah Çavuş kuzuları sayar. Kuzular tam ise köpek görevini başarı ile \n\ntamamlamıştır. Eksik ise Abdullah Çavuş ve köpeği çok üzülürler.";

            lblOynanis.Text = "Oyunda kuzular mor, kurtlar siyah, çoban köpeği ise beyaz renktedir. Oyuncu, çoban köpeğini üzerine basılı tutup yörüngesini belirler ve \n\nköpeğin o yörüngede hareket etmesini sağlar. Köpek, kuzulara belirli bir mesafeden fazla yaklaştığında kuzular öteye doğru harekete geçerler.\n\nHavlama butonuna basıldığında köpek havlar ve daha uzak mesafeden kuzuyu ötelemeyi başarır. Oyun başladıktan belirli süre sonra kurt \n\ngelecektir. Kurt sayısı, kurt getir butonuna basarak artırılabilir. ";

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
