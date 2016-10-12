namespace CiftlikOyunu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.simpleOpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.tmrKopek = new System.Windows.Forms.Timer(this.components);
            this.btnHavlat = new System.Windows.Forms.Button();
            this.tmrKurt = new System.Windows.Forms.Timer(this.components);
            this.tmrKuzuSes = new System.Windows.Forms.Timer(this.components);
            this.tmrKuzuHareket = new System.Windows.Forms.Timer(this.components);
            this.tmrHava = new System.Windows.Forms.Timer(this.components);
            this.tmrOyunSure = new System.Windows.Forms.Timer(this.components);
            this.lblSure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numSeviye = new System.Windows.Forms.NumericUpDown();
            this.lblSeviye = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKurban = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnKurtArtir = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSeviye)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl1
            // 
            this.simpleOpenGlControl1.AccumBits = ((byte)(0));
            this.simpleOpenGlControl1.AutoCheckErrors = false;
            this.simpleOpenGlControl1.AutoFinish = false;
            this.simpleOpenGlControl1.AutoMakeCurrent = true;
            this.simpleOpenGlControl1.AutoSwapBuffers = true;
            this.simpleOpenGlControl1.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.simpleOpenGlControl1.ColorBits = ((byte)(32));
            this.simpleOpenGlControl1.DepthBits = ((byte)(16));
            this.simpleOpenGlControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(0, 0);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(700, 500);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 0;
            this.simpleOpenGlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl1_Paint);
            this.simpleOpenGlControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.simpleOpenGlControl1_MouseDown);
            this.simpleOpenGlControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.simpleOpenGlControl1_MouseMove);
            this.simpleOpenGlControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.simpleOpenGlControl1_MouseUp);
            // 
            // tmrKopek
            // 
            this.tmrKopek.Interval = 40;
            this.tmrKopek.Tick += new System.EventHandler(this.tmrKopek_Tick);
            // 
            // btnHavlat
            // 
            this.btnHavlat.Location = new System.Drawing.Point(572, 471);
            this.btnHavlat.Name = "btnHavlat";
            this.btnHavlat.Size = new System.Drawing.Size(55, 21);
            this.btnHavlat.TabIndex = 1;
            this.btnHavlat.Text = "Hav";
            this.btnHavlat.UseVisualStyleBackColor = true;
            this.btnHavlat.Click += new System.EventHandler(this.btnHavlat_Click);
            // 
            // tmrKurt
            // 
            this.tmrKurt.Enabled = true;
            this.tmrKurt.Interval = 70;
            this.tmrKurt.Tick += new System.EventHandler(this.tmrKurt_Tick);
            // 
            // tmrKuzuSes
            // 
            this.tmrKuzuSes.Enabled = true;
            this.tmrKuzuSes.Interval = 10000;
            this.tmrKuzuSes.Tick += new System.EventHandler(this.tmrKuzuSes_Tick);
            // 
            // tmrKuzuHareket
            // 
            this.tmrKuzuHareket.Enabled = true;
            this.tmrKuzuHareket.Interval = 240;
            this.tmrKuzuHareket.Tick += new System.EventHandler(this.tmrKuzuHareket_Tick);
            // 
            // tmrHava
            // 
            this.tmrHava.Enabled = true;
            this.tmrHava.Interval = 50;
            this.tmrHava.Tick += new System.EventHandler(this.tmrHava_Tick);
            // 
            // tmrOyunSure
            // 
            this.tmrOyunSure.Enabled = true;
            this.tmrOyunSure.Interval = 1000;
            this.tmrOyunSure.Tick += new System.EventHandler(this.tmrOyunSure_Tick);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSure.Location = new System.Drawing.Point(73, 471);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(39, 20);
            this.lblSure.TabIndex = 2;
            this.lblSure.Text = "120";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(13, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "SÜRE:";
            // 
            // numSeviye
            // 
            this.numSeviye.BackColor = System.Drawing.Color.DarkSlateGray;
            this.numSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numSeviye.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numSeviye.Location = new System.Drawing.Point(195, 471);
            this.numSeviye.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSeviye.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeviye.Name = "numSeviye";
            this.numSeviye.Size = new System.Drawing.Size(36, 21);
            this.numSeviye.TabIndex = 4;
            this.numSeviye.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSeviye
            // 
            this.lblSeviye.AutoSize = true;
            this.lblSeviye.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeviye.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSeviye.Location = new System.Drawing.Point(116, 471);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(80, 20);
            this.lblSeviye.TabIndex = 5;
            this.lblSeviye.Text = "SEVİYE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(239, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "KAYBEDİLEN KUZU :";
            // 
            // lblKurban
            // 
            this.lblKurban.AutoSize = true;
            this.lblKurban.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblKurban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKurban.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblKurban.Location = new System.Drawing.Point(420, 471);
            this.lblKurban.Name = "lblKurban";
            this.lblKurban.Size = new System.Drawing.Size(19, 20);
            this.lblKurban.TabIndex = 8;
            this.lblKurban.Text = "0";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDurum.Location = new System.Drawing.Point(154, 181);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(77, 25);
            this.lblDurum.TabIndex = 11;
            this.lblDurum.Text = "durum";
            this.lblDurum.Visible = false;
            // 
            // btnKurtArtir
            // 
            this.btnKurtArtir.Location = new System.Drawing.Point(476, 471);
            this.btnKurtArtir.Name = "btnKurtArtir";
            this.btnKurtArtir.Size = new System.Drawing.Size(90, 21);
            this.btnKurtArtir.TabIndex = 12;
            this.btnKurtArtir.Text = "Kurt Getir";
            this.btnKurtArtir.UseVisualStyleBackColor = true;
            this.btnKurtArtir.Click += new System.EventHandler(this.btnKurtArtir_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(633, 471);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(55, 21);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKurtArtir);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblKurban);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSeviye);
            this.Controls.Add(this.numSeviye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.btnHavlat);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSeviye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
        private System.Windows.Forms.Timer tmrKopek;
        private System.Windows.Forms.Button btnHavlat;
        private System.Windows.Forms.Timer tmrKurt;
        private System.Windows.Forms.Timer tmrKuzuSes;
        private System.Windows.Forms.Timer tmrKuzuHareket;
        private System.Windows.Forms.Timer tmrHava;
        private System.Windows.Forms.Timer tmrOyunSure;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSeviye;
        private System.Windows.Forms.Label lblSeviye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKurban;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnKurtArtir;
        private System.Windows.Forms.Button btnCikis;
    }
}

