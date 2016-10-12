using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;
using System.Media;

namespace CiftlikOyunu
{
    public partial class Form1 : Form
    {
        #region Değişkenler
        float[] kopek_x = new float[0]; // mouse ile çizilen koordinatları tutar
        float[] kopek_y = new float[0]; // mouse ile çizilen koordinatları tutar
        float[] kuzu_x = new float[3];
        float[] kuzu_y = new float[3];
        float gidilecekKuzuX; //kurdun gözüne kestirdiği kuzu
        float gidilecekKuzuY; //kurdun gözüne kestirdiği kuzu
        float baslangic_KopekX = -0.05F; // köpeğin başlangıç koordinatları
        float baslangic_KopekY = 0.05F; // köpeğin başlangıç koordinatları
        float[] kurt_x = new float[3]; //kurdun başlangıç koordinatları
        float[] kurt_y = new float[3]; //kurdun başlangıç koordinatları
        float hava = 1.0F; // akşam olduğunu belirten renk değişimi
        float guvenliAlanX = 0.6F;
        float guvenliAlanY = -0.5F;
        int sayacKopekTimer = 0; //köpeğin hangi koordinata atanacağını belirler
        bool tiklandimi = false; // tıklandığında true, mouse'dan elimizi çektiğimizde false oluyor
        Random rnd_X = new Random(); //kuzunun x koordinatına rastgele bir değer
        Random rnd_Y = new Random(); //kuzunun y koordinatına rastgele bir değer
        Random gecici = new Random();
        int kurtarilan = 0;
        int kurtSayisi = 1;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        //0.35,0.85--0.75,-0.25 güvenli alan kordinatları
        void KuzuRandomHareket()
        {
            int a;
            int b;
            int kurban = 0;

            a = gecici.Next(0, 4);
            b = gecici.Next(0, 3);
            for (int i = 0; i < 3; i++)
            {
                //if (!(0.35 < kuzu_x[b] && kuzu_x[b] < 0.85 && -0.75 < kuzu_y[b] && kuzu_y[b] < -0.25))
                //{
                    if (a == 0)
                    {
                        if (kuzu_x[b] > -0.7F)
                        {
                            kuzu_x[b] = kuzu_x[b] - 0.01F;
                        }
                    }
                    else if (a == 1)
                    {
                        if (kuzu_x[b] < 0.7F)
                        {
                            kuzu_x[b] = kuzu_x[b] + 0.01F;
                        }
                    }
                    else if (a == 2)
                    {
                        if (kuzu_y[b] > -0.7F)
                        {
                            kuzu_y[b] = kuzu_y[b] - 0.01F;
                        }
                    }
                    else if (a == 3)
                    {
                        if (kuzu_y[b] < 0.7F)
                        {
                            kuzu_y[b] = kuzu_y[b] + 0.01F;
                        }
                    }
               // }
                for (int j = 0; j < kurtSayisi; j++)
                {
                    if (Math.Abs(kuzu_x[i] - kurt_x[j]) < 0.01F && Math.Abs(kuzu_y[i] - kurt_y[j]) < 0.01F)
                    {

                        kuzu_x[i] = 3.5F;
                        kuzu_y[i] = 3.5F;
                        kurban = Convert.ToInt32(lblKurban.Text);
                        kurban++;
                        lblKurban.Text = kurban.ToString();
                        if (lblKurban.Text == "3")
                        {
                            lblDurum.Visible = true;
                            lblDurum.Text = "BÜTÜN HAYVANLAR TELEF OLDU\n\nSONUÇ: KAYBETTİN";
                            tmrOyunSure.Enabled = false;
                        }
                    }
                }

            }
        }  //kuzuların rastgele hareketi

        void KuzuKacir(float uzaklik)
        {
            float[] fark = new float[3];
            for (int i = 0; i < 3; i++)
            {
                fark[i] = Convert.ToSingle(Math.Sqrt((Math.Abs(kuzu_x[i] - baslangic_KopekX) * Math.Abs(kuzu_x[i] - baslangic_KopekX)) + (Math.Abs(kuzu_y[i] - baslangic_KopekY) * Math.Abs(kuzu_y[i] - baslangic_KopekY))));
                if (kuzu_x[i] < 0.9F && kuzu_y[i] < 0.9F && kuzu_x[i] > -0.9F && kuzu_y[i] > -0.8F)
                {
                    if (fark[i] < uzaklik)
                    {
                        if (baslangic_KopekX < kuzu_x[i] && baslangic_KopekY > kuzu_y[i])
                        {
                            kuzu_x[i] = kuzu_x[i] + 0.05F;
                            kuzu_y[i] = kuzu_y[i] - 0.05F;
                        }
                        else if (baslangic_KopekX > kuzu_x[i] && baslangic_KopekY > kuzu_y[i])
                        {
                            kuzu_x[i] = kuzu_x[i] - 0.05F;
                            kuzu_y[i] = kuzu_y[i] - 0.05F;
                        }
                        else if (baslangic_KopekX < kuzu_x[i] && baslangic_KopekY < kuzu_y[i])
                        {
                            kuzu_x[i] = kuzu_x[i] + 0.05F;
                            kuzu_y[i] = kuzu_y[i] + 0.05F;
                        }
                        else if (baslangic_KopekX > kuzu_x[i] && baslangic_KopekY < kuzu_y[i])
                        {
                            kuzu_x[i] = kuzu_x[i] - 0.05F;
                            kuzu_y[i] = kuzu_y[i] + 0.05F;
                        }
                    }
                }


            }
        }  //köpek ile kuzuları kaçırma

        void KurtGetir(float adim)
        {
            for (int j = 0; j < kurtSayisi; j++)
            {
                float[] fark = new float[3];
                float enk;
                for (int i = 0; i < 3; i++) //her kuzu ile aradaki fark tek tek ölçülür. 
                {
                    fark[i] = Convert.ToSingle(Math.Sqrt((Math.Abs(kuzu_x[i] - kurt_x[j]) * Math.Abs(kuzu_x[i] - kurt_x[j])) + (Math.Abs(kuzu_y[i] - kurt_y[j]) * Math.Abs(kuzu_y[i] - kurt_y[j]))));                  
                }
                enk = 100;
                for (int i = 0; i < 3; i++) //en kısa mesafeyi belirleyecek döngü
                {
                    if (!(kuzu_x[i] < 0.85F && kuzu_x[i] > 0.35F && kuzu_y[i] < -0.25F && kuzu_y[i] > -0.75F) && fark[i] <= 4.0f)
                    {
                        if (fark[i] < enk)
                        {
                            enk = fark[i];
                            gidilecekKuzuX = kuzu_x[i];
                            gidilecekKuzuY = kuzu_y[i];
                        }
                    }
                }
                //for (int i = 0; i < kurtSayisi; i++)
                //{
                    if (enk != 100)
                    { // kuzu güvenli alanda değilse
                        if (gidilecekKuzuX > kurt_x[j])
                        {
                            if (kurt_x[j] != gidilecekKuzuX)
                            {
                                kurt_x[j] = kurt_x[j] + adim;
                            }
                        }
                        else if (gidilecekKuzuX < kurt_x[j])
                        {
                            if (kurt_x[j] != gidilecekKuzuX)
                            {
                                kurt_x[j] = kurt_x[j] - adim;
                            }
                        }

                        if (gidilecekKuzuY > kurt_y[j])
                        {
                            if (kurt_y[j] != gidilecekKuzuY)
                            {
                                kurt_y[j] = kurt_y[j] + adim;
                            }
                        }
                        else if (gidilecekKuzuY < kurt_y[j])
                        {
                            if (kurt_y[j] != gidilecekKuzuY)
                            {
                                kurt_y[j] = kurt_y[j] - adim;
                            }
                        }

                    }
                //}
            }
           


        }  //kurdun en yakın kuzuya saldırması

        private void Form1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            for (int i = 0; i < 3; i++) //kuzulara random koordinat verme
            {
                kuzu_x[i] = Convert.ToSingle(rnd_X.NextDouble() - Convert.ToSingle(gecici.NextDouble()));
                kuzu_y[i] = Convert.ToSingle(rnd_Y.NextDouble() - Convert.ToSingle(gecici.NextDouble()));
            }

            kurt_x[0] = -1.5F;
            kurt_y[0] = 1.5F;
            kurt_x[1] = -1.5F;
            kurt_y[1] = -1.5F;
            kurt_x[2] = 1.5F;
            kurt_y[2] = 1.5F;
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            for (int i = sayacKopekTimer; i < kopek_x.Length - 1; i++)
            {
                Gl.glBegin(Gl.GL_LINES); //ŞEKİL
                Gl.glColor3f(1.0F, 1.0F, 1.0F); //RENGİ
                Gl.glVertex3f(kopek_x[i], kopek_y[i], 0);
                Gl.glVertex3f(kopek_x[i + 1], kopek_y[i + 1], 0);
            }
            Gl.glEnd();

           

            //GÜVENLİ ALAN X=0.6 Y=-0.5
            Gl.glBegin(Gl.GL_QUAD_STRIP); //ŞEKİL
            Gl.glColor3f(0.34F, 0.5F, 0.3F); //RENGİ
            Gl.glVertex3f(guvenliAlanX - 0.25F, guvenliAlanY + 0.25F, 0);//X=-0.05,Y=0.05
            Gl.glVertex3f(guvenliAlanX + 0.25F, guvenliAlanY + 0.25F, 0);//guvenliAlanX=0.6 , guvenliAlanY=-0.5  
            Gl.glVertex3f(guvenliAlanX - 0.25F, guvenliAlanY - 0.25F, 0);//0.35,0.85--0.75,-0.25
            Gl.glVertex3f(guvenliAlanX + 0.25F, guvenliAlanY - 0.25F, 0);
            Gl.glEnd();

            //KÖPEK ÇİZİMİ VE KOORDİNATLARI
            Gl.glBegin(Gl.GL_QUAD_STRIP); //ŞEKİL
            Gl.glColor3f(1.0F, 1.0F, 1.0F); //RENGİ
            Gl.glVertex3f(baslangic_KopekX - 0.05F, baslangic_KopekY + 0.05F, 0);//X=-0.05,Y=0.05
            Gl.glVertex3f(baslangic_KopekX + 0.05F, baslangic_KopekY + 0.05F, 0);
            Gl.glVertex3f(baslangic_KopekX - 0.05F, baslangic_KopekY - 0.05F, 0);
            Gl.glVertex3f(baslangic_KopekX + 0.05F, baslangic_KopekY - 0.05F, 0);
            Gl.glEnd();


            //KUZULARIN ÇİZİMİ VE KOORDİNATLARI
            for (int i = 0; i < 3; i++)
            {
                Gl.glBegin(Gl.GL_QUAD_STRIP); //ŞEKİL
                Gl.glColor3f(0.8F, 0.35F, 0.7F); //RENGİ
                Gl.glVertex3d(kuzu_x[i] - 0.05F, kuzu_y[i] + 0.05F, 0);
                Gl.glVertex3d(kuzu_x[i] + 0.05F, kuzu_y[i] + 0.05F, 0);
                Gl.glVertex3d(kuzu_x[i] - 0.05F, kuzu_y[i] - 0.05F, 0);
                Gl.glVertex3d(kuzu_x[i] + 0.05F, kuzu_y[i] - 0.05F, 0);
                Gl.glEnd();
            }

            //KURDUN ÇİZİMİ VE KOORDİNATLARI 
            for (int i = 0; i < kurtSayisi; i++)
            {
                Gl.glBegin(Gl.GL_QUAD_STRIP); //ŞEKİL
                Gl.glColor3f(0.0F, 0.0F, 0.0F); //RENGİ
                Gl.glVertex3f(kurt_x[i] - 0.05F, kurt_y[i] + 0.05F, 0);//X=-0.05,Y=0.05
                Gl.glVertex3f(kurt_x[i] + 0.05F, kurt_y[i] + 0.05F, 0);
                Gl.glVertex3f(kurt_x[i] - 0.05F, kurt_y[i] - 0.05F, 0);
                Gl.glVertex3f(kurt_x[i] + 0.05F, kurt_y[i] - 0.05F, 0);
                Gl.glEnd();
            }

            
            KuzuKacir(0.15F);

        }

        private void simpleOpenGlControl1_MouseDown(object sender, MouseEventArgs e) //tıklama
        {
            if ((baslangic_KopekX - 0.05F < Convert.ToSingle(e.X) / 350.0F - 1.0F) && (Convert.ToSingle(e.X) / 350.0F - 1.0F < baslangic_KopekX + 0.05F) && (baslangic_KopekY - 0.05F < 1.0F - Convert.ToSingle(e.Y) / 250.0F) && (1.0F - Convert.ToSingle(e.Y) / 250.0F < baslangic_KopekY + 0.05F))
            {
                Array.Resize(ref kopek_x, 0);
                Array.Resize(ref kopek_y, 0);
                tiklandimi = true;
                tmrKopek.Enabled = true;
                sayacKopekTimer = 0;
            }

        }

        private void simpleOpenGlControl1_MouseUp(object sender, MouseEventArgs e) //bırakma
        {
            tiklandimi = false;
        }

        private void simpleOpenGlControl1_MouseMove(object sender, MouseEventArgs e) //gezme
        {
            if (tiklandimi)
            {
                Array.Resize(ref kopek_x, kopek_x.Length + 1);
                Array.Resize(ref kopek_y, kopek_y.Length + 1);
                kopek_x[kopek_x.Length - 1] = Convert.ToSingle(e.X) / 350.0F - 1.0F;
                kopek_y[kopek_y.Length - 1] = 1.0F - Convert.ToSingle(e.Y) / 250.0F;
                KuzuKacir(0.15F);
                simpleOpenGlControl1.Invalidate(); //her seferinde paint'i çağırır
            }
        }

        private void tmrKopek_Tick(object sender, EventArgs e)
        {
            try
            {
                baslangic_KopekX = kopek_x[sayacKopekTimer];
                baslangic_KopekY = kopek_y[sayacKopekTimer];
                sayacKopekTimer++;
                if (sayacKopekTimer == kopek_x.Length - 1 && tiklandimi == false)
                {
                    tmrKopek.Enabled = false;
                }
                simpleOpenGlControl1.Invalidate(); //her seferinde paint'i çağırır
            }
            catch
            {
            }

        }

        private void btnHavlat_Click(object sender, EventArgs e)
        {
            SoundPlayer ses = new SoundPlayer();
            string yol = Application.StartupPath + "\\dog.wav";
            ses.SoundLocation = yol;
            ses.Play();
            KuzuKacir(0.3F);
            simpleOpenGlControl1.Invalidate();
        }

        private void tmrKurt_Tick(object sender, EventArgs e)
        {
            if (numSeviye.Value == 1)
            {
                KurtGetir(0.005F);
            }
            else if (numSeviye.Value == 2)
            {
                KurtGetir(0.007F);
            }
            else if (numSeviye.Value == 3)
            {
                KurtGetir(0.009F);
            }
            simpleOpenGlControl1.Invalidate();
        }

        private void tmrKuzuSes_Tick(object sender, EventArgs e)
        {
            if (lblKurban.Text != "3")
            {
                SoundPlayer ses = new SoundPlayer();
                string yol = Application.StartupPath + "\\sheep.wav";
                ses.SoundLocation = yol;
                ses.Play();
            }
        }

        private void tmrKuzuHareket_Tick(object sender, EventArgs e)
        {
            KuzuRandomHareket();
            simpleOpenGlControl1.Invalidate();
        }

        private void tmrHava_Tick(object sender, EventArgs e)
        {
            Gl.glClearColor(0.0F, hava, 0.0F, 0.0F);
            hava = hava - 0.0005f;
        }

        private void tmrOyunSure_Tick(object sender, EventArgs e)
        {
            int sure;
            kurtarilan = 3 - Convert.ToInt32(lblKurban.Text);
            sure = Convert.ToInt32(lblSure.Text) - 1;
            lblSure.Text = sure.ToString();
            if (lblSure.Text == "0")
            {

                tmrOyunSure.Enabled = false;
                tmrKurt.Enabled = false;
                if (kurtarilan != 3)
                {
                    MessageBox.Show("SÜRE BİTTİ. " + kurtarilan + " ADET KUZUYU KURTARABİLDİNİZ. SONUÇ: TÜM KUZULARI KURTARAMADIĞINIZ İÇİN KAYBETTİNİZ!");
                }
                else
                {
                    MessageBox.Show("SÜRE BİTTİ. TÜM KUZULARI KURTARDINIZ. SONUÇ: KAZANDINIZ!");

                }
                this.Close();
            }
        }

        private void btnKurtArtir_Click(object sender, EventArgs e)
        {
            kurtSayisi++;
 
            if (kurtSayisi == 3)
            {
                btnKurtArtir.Enabled = false;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}