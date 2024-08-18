namespace ŞİRKETOTOMASYONU
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stoklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şirketlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.ürünToolStripMenuItem,
            this.stoklarToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.şirketlerToolStripMenuItem,
            this.personellerToolStripMenuItem,
            this.giderlerToolStripMenuItem,
            this.kasaToolStripMenuItem,
            this.bankalarToolStripMenuItem,
            this.faturaToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Image = global::ŞİRKETOTOMASYONU.Properties.Resources.home_1946436;
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.anaSayfaToolStripMenuItem.Text = "Anasayfa";
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.Image = global::ŞİRKETOTOMASYONU.Properties.Resources.products_10951869;
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.ürünToolStripMenuItem.Text = "Ürünler";
            this.ürünToolStripMenuItem.Click += new System.EventHandler(this.ürünToolStripMenuItem_Click);
            // 
            // stoklarToolStripMenuItem
            // 
            this.stoklarToolStripMenuItem.Image = global::ŞİRKETOTOMASYONU.Properties.Resources.forklift_7459466;
            this.stoklarToolStripMenuItem.Name = "stoklarToolStripMenuItem";
            this.stoklarToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.stoklarToolStripMenuItem.Text = "Stoklar";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Image = global::ŞİRKETOTOMASYONU.Properties.Resources.people;
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
            // 
            // şirketlerToolStripMenuItem
            // 
            this.şirketlerToolStripMenuItem.Image = global::ŞİRKETOTOMASYONU.Properties.Resources.building;
            this.şirketlerToolStripMenuItem.Name = "şirketlerToolStripMenuItem";
            this.şirketlerToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.şirketlerToolStripMenuItem.Text = "Şirketler";
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.Image = global::ŞİRKETOTOMASYONU.Properties.Resources.staff_management;
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.personellerToolStripMenuItem.Text = "Personeller";
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.Image = global::ŞİRKETOTOMASYONU.Properties.Resources.expenses;
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(97, 25);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // kasaToolStripMenuItem
            // 
            this.kasaToolStripMenuItem.Image = global::ŞİRKETOTOMASYONU.Properties.Resources.ecommerce;
            this.kasaToolStripMenuItem.Name = "kasaToolStripMenuItem";
            this.kasaToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.kasaToolStripMenuItem.Text = "Kasa";
            // 
            // bankalarToolStripMenuItem
            // 
            this.bankalarToolStripMenuItem.Image = global::ŞİRKETOTOMASYONU.Properties.Resources.bank;
            this.bankalarToolStripMenuItem.Name = "bankalarToolStripMenuItem";
            this.bankalarToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.bankalarToolStripMenuItem.Text = "Bankalar";
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.Image = global::ŞİRKETOTOMASYONU.Properties.Resources.bill;
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.faturaToolStripMenuItem.Text = "Faturalar";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Image = global::ŞİRKETOTOMASYONU.Properties.Resources.support;
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Image = global::ŞİRKETOTOMASYONU.Properties.Resources.setting_lines;
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stoklarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şirketlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
    }
}

