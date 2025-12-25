namespace personeller
{
    partial class Frmİzin
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
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSure = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İzin Başlangıç Tarihi";
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBaslangic.Location = new System.Drawing.Point(16, 57);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dateBaslangic.TabIndex = 1;
            this.dateBaslangic.ValueChanged += new System.EventHandler(this.dateBitis_ValueChanged_1);
            // 
            // dateBitis
            // 
            this.dateBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBitis.Location = new System.Drawing.Point(261, 57);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(200, 22);
            this.dateBitis.TabIndex = 3;
            this.dateBitis.ValueChanged += new System.EventHandler(this.dateBitis_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşe Dönüş / Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toplam İzin Süresi ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "İzin Nedeni / Açıklama";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(16, 278);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(160, 88);
            this.btnGonder.TabIndex = 8;
            this.btnGonder.Text = "Tamamla ve Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(295, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 88);
            this.button1.TabIndex = 9;
            this.button1.Text = "AnaSayfaya Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAciklama.FormattingEnabled = true;
            this.txtAciklama.Items.AddRange(new object[] {
            "Yıllık İzin",
            "",
            "Hastalık (Rapor) İzni",
            "",
            "Mazeret İzni",
            "",
            "Ücretsiz İzin",
            "",
            "Evlilik İzni",
            "",
            "Babalık İzni",
            "",
            "Ölüm İzni",
            "",
            "Doğum İzni",
            "",
            "İdari İzin"});
            this.txtAciklama.Location = new System.Drawing.Point(16, 248);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(435, 24);
            this.txtAciklama.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.txtSure);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnGonder);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateBaslangic);
            this.panel1.Controls.Add(this.dateBitis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 391);
            this.panel1.TabIndex = 11;
            // 
            // txtSure
            // 
            this.txtSure.AutoSize = true;
            this.txtSure.BackColor = System.Drawing.Color.White;
            this.txtSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSure.Location = new System.Drawing.Point(255, 119);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(104, 32);
            this.txtSure.TabIndex = 11;
            this.txtSure.Text = "0 GÜN";
            // 
            // Frmİzin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(714, 414);
            this.Controls.Add(this.panel1);
            this.Name = "Frmİzin";
            this.Text = "Frmİzin";
            this.Load += new System.EventHandler(this.Frmİzin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtAciklama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtSure;
    }
}