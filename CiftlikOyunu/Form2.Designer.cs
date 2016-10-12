namespace CiftlikOyunu
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSenaryo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOynanis = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SENARYO:";
            // 
            // lblSenaryo
            // 
            this.lblSenaryo.AutoSize = true;
            this.lblSenaryo.Location = new System.Drawing.Point(25, 76);
            this.lblSenaryo.Name = "lblSenaryo";
            this.lblSenaryo.Size = new System.Drawing.Size(29, 13);
            this.lblSenaryo.TabIndex = 1;
            this.lblSenaryo.Text = "label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "NASIL OYNANIR:";
            // 
            // lblOynanis
            // 
            this.lblOynanis.AutoSize = true;
            this.lblOynanis.Location = new System.Drawing.Point(25, 349);
            this.lblOynanis.Name = "lblOynanis";
            this.lblOynanis.Size = new System.Drawing.Size(29, 13);
            this.lblOynanis.TabIndex = 3;
            this.lblOynanis.Text = "label";
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(225, 475);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(123, 23);
            this.btnBasla.TabIndex = 4;
            this.btnBasla.Text = "OYUNA BAŞLA!";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(354, 475);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblOynanis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSenaryo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSenaryo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOynanis;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnCikis;
    }
}