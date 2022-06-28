
namespace SendeYe
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
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxsalata = new System.Windows.Forms.CheckBox();
            this.checkBoxdomates = new System.Windows.Forms.CheckBox();
            this.checkBoxgöbek = new System.Windows.Forms.CheckBox();
            this.checkBoxlahanaKır = new System.Windows.Forms.CheckBox();
            this.checkBoxzeytin = new System.Windows.Forms.CheckBox();
            this.checkBoxturp = new System.Windows.Forms.CheckBox();
            this.checkBoxayran = new System.Windows.Forms.CheckBox();
            this.checkBoxlimonata = new System.Windows.Forms.CheckBox();
            this.listBoxsecilenler = new System.Windows.Forms.ListBox();
            this.btnsiparis = new System.Windows.Forms.Button();
            this.checkBoxmaydonoz = new System.Windows.Forms.CheckBox();
            this.checkBoxnareksi = new System.Windows.Forms.CheckBox();
            this.listBoxAlinanlar = new System.Windows.Forms.ListBox();
            this.labelfyt = new System.Windows.Forms.Label();
            this.buttonyenisiparis = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesapDökümüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(12, 85);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(182, 21);
            this.comboBoxMenu.TabIndex = 1;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu Seçin";
            // 
            // checkBoxsalata
            // 
            this.checkBoxsalata.AutoSize = true;
            this.checkBoxsalata.Location = new System.Drawing.Point(6, 133);
            this.checkBoxsalata.Name = "checkBoxsalata";
            this.checkBoxsalata.Size = new System.Drawing.Size(56, 17);
            this.checkBoxsalata.TabIndex = 3;
            this.checkBoxsalata.Text = "Salata";
            this.checkBoxsalata.UseVisualStyleBackColor = true;
            this.checkBoxsalata.CheckedChanged += new System.EventHandler(this.checkBoxsalata_CheckedChanged);
            // 
            // checkBoxdomates
            // 
            this.checkBoxdomates.AutoSize = true;
            this.checkBoxdomates.Location = new System.Drawing.Point(62, 133);
            this.checkBoxdomates.Name = "checkBoxdomates";
            this.checkBoxdomates.Size = new System.Drawing.Size(68, 17);
            this.checkBoxdomates.TabIndex = 4;
            this.checkBoxdomates.Text = "Domates";
            this.checkBoxdomates.UseVisualStyleBackColor = true;
            this.checkBoxdomates.CheckedChanged += new System.EventHandler(this.checkBoxdomates_CheckedChanged);
            // 
            // checkBoxgöbek
            // 
            this.checkBoxgöbek.AutoSize = true;
            this.checkBoxgöbek.Location = new System.Drawing.Point(4, 161);
            this.checkBoxgöbek.Name = "checkBoxgöbek";
            this.checkBoxgöbek.Size = new System.Drawing.Size(58, 17);
            this.checkBoxgöbek.TabIndex = 5;
            this.checkBoxgöbek.Text = "Göbek";
            this.checkBoxgöbek.UseVisualStyleBackColor = true;
            this.checkBoxgöbek.CheckedChanged += new System.EventHandler(this.checkBoxgöbek_CheckedChanged);
            // 
            // checkBoxlahanaKır
            // 
            this.checkBoxlahanaKır.AutoSize = true;
            this.checkBoxlahanaKır.Location = new System.Drawing.Point(62, 187);
            this.checkBoxlahanaKır.Name = "checkBoxlahanaKır";
            this.checkBoxlahanaKır.Size = new System.Drawing.Size(62, 17);
            this.checkBoxlahanaKır.TabIndex = 6;
            this.checkBoxlahanaKır.Text = "Lahana";
            this.checkBoxlahanaKır.UseVisualStyleBackColor = true;
            this.checkBoxlahanaKır.CheckedChanged += new System.EventHandler(this.checkBoxlahanaKır_CheckedChanged);
            // 
            // checkBoxzeytin
            // 
            this.checkBoxzeytin.AutoSize = true;
            this.checkBoxzeytin.Location = new System.Drawing.Point(6, 187);
            this.checkBoxzeytin.Name = "checkBoxzeytin";
            this.checkBoxzeytin.Size = new System.Drawing.Size(55, 17);
            this.checkBoxzeytin.TabIndex = 7;
            this.checkBoxzeytin.Text = "Zeytin";
            this.checkBoxzeytin.UseVisualStyleBackColor = true;
            this.checkBoxzeytin.CheckedChanged += new System.EventHandler(this.checkBoxzeytin_CheckedChanged);
            // 
            // checkBoxturp
            // 
            this.checkBoxturp.AutoSize = true;
            this.checkBoxturp.Location = new System.Drawing.Point(82, 211);
            this.checkBoxturp.Name = "checkBoxturp";
            this.checkBoxturp.Size = new System.Drawing.Size(48, 17);
            this.checkBoxturp.TabIndex = 8;
            this.checkBoxturp.Text = "Turp";
            this.checkBoxturp.UseVisualStyleBackColor = true;
            this.checkBoxturp.CheckedChanged += new System.EventHandler(this.checkBoxturp_CheckedChanged);
            // 
            // checkBoxayran
            // 
            this.checkBoxayran.AutoSize = true;
            this.checkBoxayran.Location = new System.Drawing.Point(6, 234);
            this.checkBoxayran.Name = "checkBoxayran";
            this.checkBoxayran.Size = new System.Drawing.Size(53, 17);
            this.checkBoxayran.TabIndex = 9;
            this.checkBoxayran.Text = "Ayran";
            this.checkBoxayran.UseVisualStyleBackColor = true;
            this.checkBoxayran.CheckedChanged += new System.EventHandler(this.checkBoxayran_CheckedChanged);
            // 
            // checkBoxlimonata
            // 
            this.checkBoxlimonata.AutoSize = true;
            this.checkBoxlimonata.Location = new System.Drawing.Point(62, 234);
            this.checkBoxlimonata.Name = "checkBoxlimonata";
            this.checkBoxlimonata.Size = new System.Drawing.Size(69, 17);
            this.checkBoxlimonata.TabIndex = 10;
            this.checkBoxlimonata.Text = "Limonata";
            this.checkBoxlimonata.UseVisualStyleBackColor = true;
            this.checkBoxlimonata.CheckedChanged += new System.EventHandler(this.checkBoxlimonata_CheckedChanged);
            // 
            // listBoxsecilenler
            // 
            this.listBoxsecilenler.FormattingEnabled = true;
            this.listBoxsecilenler.Location = new System.Drawing.Point(781, -1);
            this.listBoxsecilenler.Name = "listBoxsecilenler";
            this.listBoxsecilenler.Size = new System.Drawing.Size(177, 459);
            this.listBoxsecilenler.TabIndex = 11;
            // 
            // btnsiparis
            // 
            this.btnsiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiparis.Location = new System.Drawing.Point(2, 330);
            this.btnsiparis.Name = "btnsiparis";
            this.btnsiparis.Size = new System.Drawing.Size(196, 53);
            this.btnsiparis.TabIndex = 12;
            this.btnsiparis.Text = "Siparişi tamamla";
            this.btnsiparis.UseVisualStyleBackColor = true;
            this.btnsiparis.Click += new System.EventHandler(this.btnsiparis_Click);
            // 
            // checkBoxmaydonoz
            // 
            this.checkBoxmaydonoz.AutoSize = true;
            this.checkBoxmaydonoz.Location = new System.Drawing.Point(6, 211);
            this.checkBoxmaydonoz.Name = "checkBoxmaydonoz";
            this.checkBoxmaydonoz.Size = new System.Drawing.Size(75, 17);
            this.checkBoxmaydonoz.TabIndex = 13;
            this.checkBoxmaydonoz.Text = "Maydanoz";
            this.checkBoxmaydonoz.UseVisualStyleBackColor = true;
            this.checkBoxmaydonoz.CheckedChanged += new System.EventHandler(this.checkBoxmaydonoz_CheckedChanged);
            // 
            // checkBoxnareksi
            // 
            this.checkBoxnareksi.AutoSize = true;
            this.checkBoxnareksi.Location = new System.Drawing.Point(58, 161);
            this.checkBoxnareksi.Name = "checkBoxnareksi";
            this.checkBoxnareksi.Size = new System.Drawing.Size(72, 17);
            this.checkBoxnareksi.TabIndex = 14;
            this.checkBoxnareksi.Text = "Nar ekşisi";
            this.checkBoxnareksi.UseVisualStyleBackColor = true;
            this.checkBoxnareksi.CheckedChanged += new System.EventHandler(this.checkBoxnareksi_CheckedChanged);
            // 
            // listBoxAlinanlar
            // 
            this.listBoxAlinanlar.FormattingEnabled = true;
            this.listBoxAlinanlar.Location = new System.Drawing.Point(204, 330);
            this.listBoxAlinanlar.Name = "listBoxAlinanlar";
            this.listBoxAlinanlar.Size = new System.Drawing.Size(571, 121);
            this.listBoxAlinanlar.TabIndex = 15;
            // 
            // labelfyt
            // 
            this.labelfyt.AutoSize = true;
            this.labelfyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfyt.ForeColor = System.Drawing.Color.Maroon;
            this.labelfyt.Location = new System.Drawing.Point(721, 423);
            this.labelfyt.Name = "labelfyt";
            this.labelfyt.Size = new System.Drawing.Size(27, 18);
            this.labelfyt.TabIndex = 16;
            this.labelfyt.Text = "TL";
            // 
            // buttonyenisiparis
            // 
            this.buttonyenisiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonyenisiparis.Location = new System.Drawing.Point(2, 389);
            this.buttonyenisiparis.Name = "buttonyenisiparis";
            this.buttonyenisiparis.Size = new System.Drawing.Size(196, 53);
            this.buttonyenisiparis.TabIndex = 17;
            this.buttonyenisiparis.Text = "Yeni sipariş";
            this.buttonyenisiparis.UseVisualStyleBackColor = true;
            this.buttonyenisiparis.Click += new System.EventHandler(this.buttonyenisiparis_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapDökümüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hesapDökümüToolStripMenuItem
            // 
            this.hesapDökümüToolStripMenuItem.Name = "hesapDökümüToolStripMenuItem";
            this.hesapDökümüToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.hesapDökümüToolStripMenuItem.Text = "Hesap dökümü";
            this.hesapDökümüToolStripMenuItem.Click += new System.EventHandler(this.hesapDökümüToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SendeYe.Properties.Resources.tavuklu_kinoa_salatası_nasıl_yapılır;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(956, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.buttonyenisiparis);
            this.Controls.Add(this.labelfyt);
            this.Controls.Add(this.listBoxAlinanlar);
            this.Controls.Add(this.checkBoxnareksi);
            this.Controls.Add(this.checkBoxmaydonoz);
            this.Controls.Add(this.btnsiparis);
            this.Controls.Add(this.listBoxsecilenler);
            this.Controls.Add(this.checkBoxlimonata);
            this.Controls.Add(this.checkBoxayran);
            this.Controls.Add(this.checkBoxturp);
            this.Controls.Add(this.checkBoxzeytin);
            this.Controls.Add(this.checkBoxlahanaKır);
            this.Controls.Add(this.checkBoxgöbek);
            this.Controls.Add(this.checkBoxdomates);
            this.Controls.Add(this.checkBoxsalata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxsalata;
        private System.Windows.Forms.CheckBox checkBoxdomates;
        private System.Windows.Forms.CheckBox checkBoxgöbek;
        private System.Windows.Forms.CheckBox checkBoxlahanaKır;
        private System.Windows.Forms.CheckBox checkBoxzeytin;
        private System.Windows.Forms.CheckBox checkBoxturp;
        private System.Windows.Forms.CheckBox checkBoxayran;
        private System.Windows.Forms.CheckBox checkBoxlimonata;
        private System.Windows.Forms.ListBox listBoxsecilenler;
        private System.Windows.Forms.Button btnsiparis;
        private System.Windows.Forms.CheckBox checkBoxmaydonoz;
        private System.Windows.Forms.CheckBox checkBoxnareksi;
        private System.Windows.Forms.ListBox listBoxAlinanlar;
        private System.Windows.Forms.Label labelfyt;
        private System.Windows.Forms.Button buttonyenisiparis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesapDökümüToolStripMenuItem;
    }
}

