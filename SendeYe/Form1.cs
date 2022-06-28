using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SendeYe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double toplam = 0;
        double ayran = 2.75;


        private void Form1_Load(object sender, EventArgs e)
        {
            Yemekler neyesek = new Yemekler();
            Yemekler neyesek2 = new Yemekler();
            Yemekler neyesek3 = new Yemekler();
            Yemekler neyesek4 = new Yemekler();
            neyesek.Adi = "Kinoa Salatalı Tavuk";
            neyesek2.Adi = "Kinoa Salatalı Somon";
            neyesek3.Adi = "Kremalı mantarlı tavuklu makarna";
            neyesek4.Adi = "Arabiata soslu tavuklu makarna";
            comboBoxMenu.Items.Add(neyesek.Adi);
            comboBoxMenu.Items.Add(neyesek2.Adi);
            comboBoxMenu.Items.Add(neyesek3.Adi);
            comboBoxMenu.Items.Add(neyesek4.Adi);
            SoundPlayer ses = new SoundPlayer("gaziantepbaklava.wav");
            ses.Play();
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxsecilenler.Items.Count; i++)
            {
                listBoxAlinanlar.Items.Add(listBoxsecilenler.Items[i].ToString());
            }
            checkBoxmaydonoz.Checked = false;
            checkBoxayran.Checked = false;
            checkBoxlahanaKır.Checked = false;
            checkBoxgöbek.Checked = false;
            checkBoxdomates.Checked = false;
            checkBoxlimonata.Checked = false;
            checkBoxnareksi.Checked = false;
            checkBoxsalata.Checked = false;
            checkBoxturp.Checked = false;
            checkBoxzeytin.Checked = false; // bunları false a  döndürünce - ye düşüyo ayranların fiyatı ona ayar çek 
            listBoxsecilenler.Items.Clear();

        }

        private void checkBoxayran_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxayran.Checked == true)
            {
                listBoxsecilenler.Items.Add("Ayran");
                toplam += ayran;
                labelfyt.Text = toplam.ToString();
            }
            else if (checkBoxayran.Checked == false)
            {
                listBoxsecilenler.Items.Remove("Ayran");
                toplam -= ayran;
                labelfyt.Text = toplam.ToString();
            }

        }
        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxMenu.SelectedIndex == 0)
            {
                listBoxsecilenler.Items.Add("Kinoa Salatalı Tavuk");
                listBoxsecilenler.Items.Remove("Kinoa Salatalı Somon");
                listBoxsecilenler.Items.Remove("Kremalı mantarlı tavuklu makarna");
                listBoxsecilenler.Items.Remove("Arabiata soslu tavuklu makarna");
                double kinotav = 55.25;
                toplam += kinotav;
                labelfyt.Text = toplam.ToString();
            }
            else if (comboBoxMenu.SelectedIndex == 1)
            {
                listBoxsecilenler.Items.Add("Kinoa Salatalı Somon");
                listBoxsecilenler.Items.Remove("Kremalı mantarlı tavuklu makarna");
                listBoxsecilenler.Items.Remove("Arabiata soslu tavuklu makarna");
                listBoxsecilenler.Items.Remove("Kinoa Salatalı Tavuk");
                double kinosom = 99.25;
                toplam += kinosom;
                labelfyt.Text = toplam.ToString();
            }
            else if (comboBoxMenu.SelectedIndex == 2)
            {
                listBoxsecilenler.Items.Add("Kremalı mantarlı tavuklu makarna");
                listBoxsecilenler.Items.Remove("Arabiata soslu tavuklu makarna");
                listBoxsecilenler.Items.Remove("Kinoa Salatalı Tavuk");
                listBoxsecilenler.Items.Remove("Kinoa Salatalı Somon");
                double kremtavuk = 32.75;
                toplam += kremtavuk;
                labelfyt.Text = toplam.ToString();
            }
            else if (comboBoxMenu.SelectedIndex == 3)
            {
                listBoxsecilenler.Items.Add("Arabiata soslu tavuklu makarna");
                listBoxsecilenler.Items.Remove("Kremalı mantarlı tavuklu makarna");
                listBoxsecilenler.Items.Remove("Kinoa Salatalı Tavuk");
                listBoxsecilenler.Items.Remove("Kinoa Salatalı Somon");
                double araptavuk = 32.75;
                toplam += araptavuk;
                labelfyt.Text = toplam.ToString();
            }


        }

        private void checkBoxsalata_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxsalata.Checked == true)
            {
                listBoxsecilenler.Items.Add("Salata");
            }
            else if (checkBoxsalata.Checked == false)
            {
                listBoxsecilenler.Items.Remove("Salata");
            }
        }

        private void checkBoxdomates_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxdomates.Checked == true)
            {
                listBoxsecilenler.Items.Add("Domates");
            }
            else if (checkBoxdomates.Checked == false)
            {
                listBoxsecilenler.Items.Remove("Domates");
            }
        }

        private void checkBoxgöbek_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxgöbek.Checked == true)
            {
                listBoxsecilenler.Items.Add("Göbek");
            }
            else if (checkBoxgöbek.Checked == false)
            {
                listBoxsecilenler.Items.Remove("Göbek");
            }
        }

        private void checkBoxnareksi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxnareksi.Checked == true)
            {
                listBoxsecilenler.Items.Add("Nar ekşisi");
            }
            else if (checkBoxnareksi.Checked == false)
            {
                listBoxsecilenler.Items.Remove("Nar ekşisi");
            }
        }

        private void checkBoxzeytin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxzeytin.Checked == true)
            {
                listBoxsecilenler.Items.Add("Zeytin");
            }
            else if (checkBoxzeytin.Checked == false)
            {
                listBoxsecilenler.Items.Remove("Zeytin");
            }
        }

        private void checkBoxlahanaKır_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxlahanaKır.Checked == true)
            {
                listBoxsecilenler.Items.Add("Kırmızı lahana");
            }
            else if (checkBoxlahanaKır.Checked == false)
            {
                listBoxsecilenler.Items.Remove("Kırmızı lahana");
            }
        }

        private void checkBoxmaydonoz_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxmaydonoz.Checked == true)
            {
                listBoxsecilenler.Items.Add("Maydonoz");
            }
            else if (checkBoxmaydonoz.Checked == false)
            {
                listBoxsecilenler.Items.Remove("Maydonoz");
            }
        }

        private void checkBoxturp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxturp.Checked == true)
            {
                listBoxsecilenler.Items.Add("Turp");
            }
            else if (checkBoxturp.Checked == false)
            {
                listBoxsecilenler.Items.Remove("Turp");
            }
        }

        private void checkBoxlimonata_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxlimonata.Checked == true)
            {
                listBoxsecilenler.Items.Add("Limonata");
                double limonata = 2.75;
                toplam += limonata;
                labelfyt.Text = toplam.ToString();
            }
            else if (checkBoxlimonata.Checked == false)
            {
                listBoxsecilenler.Items.Remove("Limonata");
                double limonata = 2.75;
                toplam -= limonata;
                labelfyt.Text = toplam.ToString();
            }
        }

        private void buttonyenisiparis_Click(object sender, EventArgs e)
        {
            listBoxAlinanlar.Items.Clear();
            listBoxsecilenler.Items.Clear();
            toplam = 0;
            labelfyt.Text = toplam.ToString();
            checkBoxmaydonoz.Checked = false;
            checkBoxayran.Checked = false;
            checkBoxlahanaKır.Checked = false;
            checkBoxgöbek.Checked = false;
            checkBoxdomates.Checked = false;
            checkBoxlimonata.Checked = false;
            checkBoxnareksi.Checked = false;
            checkBoxsalata.Checked = false;
            checkBoxturp.Checked = false;
            checkBoxzeytin.Checked = false;
        }

        private void hesapDökümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gelir gelirform = new Gelir();
            gelirform.Show();
        }
    }
}
