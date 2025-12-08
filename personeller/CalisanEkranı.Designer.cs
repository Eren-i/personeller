namespace personeller
{
    partial class CalisanEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanEkranı));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuKutusu1 = new personeller.MenuKutusu();
            this.menuKutusu3 = new personeller.MenuKutusu();
            this.menuKutusu4 = new personeller.MenuKutusu();
            this.menuKutusu5 = new personeller.MenuKutusu();
            this.menuKutusu2 = new personeller.MenuKutusu();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.menuKutusu1);
            this.flowLayoutPanel1.Controls.Add(this.menuKutusu3);
            this.flowLayoutPanel1.Controls.Add(this.menuKutusu4);
            this.flowLayoutPanel1.Controls.Add(this.menuKutusu5);
            this.flowLayoutPanel1.Controls.Add(this.menuKutusu2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(647, 546);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // menuKutusu1
            // 
            this.menuKutusu1.BackColor = System.Drawing.Color.White;
            this.menuKutusu1.Baslik = "Menü";
            this.menuKutusu1.Location = new System.Drawing.Point(3, 3);
            this.menuKutusu1.Name = "menuKutusu1";
            this.menuKutusu1.Resim = ((System.Drawing.Image)(resources.GetObject("menuKutusu1.Resim")));
            this.menuKutusu1.Size = new System.Drawing.Size(112, 96);
            this.menuKutusu1.TabIndex = 0;
            // 
            // menuKutusu3
            // 
            this.menuKutusu3.BackColor = System.Drawing.Color.White;
            this.menuKutusu3.Baslik = "Departman";
            this.menuKutusu3.Location = new System.Drawing.Point(121, 3);
            this.menuKutusu3.Name = "menuKutusu3";
            this.menuKutusu3.Resim = ((System.Drawing.Image)(resources.GetObject("menuKutusu3.Resim")));
            this.menuKutusu3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuKutusu3.Size = new System.Drawing.Size(112, 96);
            this.menuKutusu3.TabIndex = 2;
            // 
            // menuKutusu4
            // 
            this.menuKutusu4.BackColor = System.Drawing.Color.White;
            this.menuKutusu4.Baslik = "Kariyerim";
            this.menuKutusu4.Location = new System.Drawing.Point(239, 3);
            this.menuKutusu4.Name = "menuKutusu4";
            this.menuKutusu4.Resim = ((System.Drawing.Image)(resources.GetObject("menuKutusu4.Resim")));
            this.menuKutusu4.Size = new System.Drawing.Size(112, 96);
            this.menuKutusu4.TabIndex = 3;
            // 
            // menuKutusu5
            // 
            this.menuKutusu5.BackColor = System.Drawing.Color.White;
            this.menuKutusu5.Baslik = "Vardiyam";
            this.menuKutusu5.Location = new System.Drawing.Point(357, 3);
            this.menuKutusu5.Name = "menuKutusu5";
            this.menuKutusu5.Resim = ((System.Drawing.Image)(resources.GetObject("menuKutusu5.Resim")));
            this.menuKutusu5.Size = new System.Drawing.Size(112, 96);
            this.menuKutusu5.TabIndex = 4;
            // 
            // menuKutusu2
            // 
            this.menuKutusu2.BackColor = System.Drawing.Color.White;
            this.menuKutusu2.Baslik = "Menü";
            this.menuKutusu2.Location = new System.Drawing.Point(475, 3);
            this.menuKutusu2.Name = "menuKutusu2";
            this.menuKutusu2.Resim = ((System.Drawing.Image)(resources.GetObject("menuKutusu2.Resim")));
            this.menuKutusu2.Size = new System.Drawing.Size(112, 96);
            this.menuKutusu2.TabIndex = 1;
            // 
            // CalisanEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 546);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CalisanEkranı";
            this.Text = "CalisanEkranı";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MenuKutusu menuKutusu1;
        private MenuKutusu menuKutusu2;
        private MenuKutusu menuKutusu3;
        private MenuKutusu menuKutusu4;
        private MenuKutusu menuKutusu5;
    }
}