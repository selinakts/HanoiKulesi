using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Csharp_Hanoi_Kuleleri_Oyunu
{
    public partial class Hanoi : Form
    {
        public Hanoi()
        {
            InitializeComponent();
        }

  

        #region TÜM DEĞİŞKENLER BURADA OLUŞTURULDU
        public static bool formAcikMi = false;
        Random rasgeleSayi = new Random();
        int hSayisi = 0;
        int bKonumX;
        int bKonumY;
        int bGenislik;
        bool gidilebilirMi;
        Button b;
        Point bKonum;
        bool oyunBitti = false;
        int bSayisi;
        int saniye = 0;
        int kynk;
        int hedef;
        int sayackynkhedef;
        #endregion

        #region BUTONLARIN HAREKETLENMESİ BURADA GERÇEKLEŞİYOR
        private void butonlar_MouseDown(object sender, MouseEventArgs e)
        {
            b = sender as Button; //hangi butonun tutulduğunu buluyoruz..
            bKonumX = b.Location.X;
            bKonumY = b.Location.Y;
            bKonum = b.Location;
            bGenislik = b.Width;
      
            bool HareketEtsinMi = true;
            foreach (Button pButton in b.Parent.Controls)
            {
                if (bGenislik > pButton.Width)// Eğer tutulan butonun genişliği paneldeki butonlardan büyükse hareket gerçekleşmez
                    HareketEtsinMi = false;
            }
            if (HareketEtsinMi == true)
            {
                DragDropEffects DDE = DragDropEffects.All;   //Hareket Nesnesi
                p1.DoDragDrop(b, DDE);
            }// Butonun dragdropunu başlatıyoruz

        }
        private void p_DragDrop(object sender, DragEventArgs e)
        {
            Panel HedefP = sender as Panel;
            if (e.Data.GetData(typeof(Button)) is Button) // Sürüklemeye alınan buton
            {
                Button SuruklenenButton = (Button)e.Data.GetData(typeof(Button));
                int sayac = 1; // Gidilen konumda kaç tane buton varsa onu tespit etme
                gidilebilirMi = true;
                foreach (Button pButton in HedefP.Controls)
                {
                    if (pButton.Width < bGenislik) //gidilen paneldeki butonun boyutu küçükse gidilemez.
                        gidilebilirMi = false;
                    sayac++;
                }
                if (gidilebilirMi == true && b.Parent != HedefP) // Yapılacak hamle butonun bulunduğu panel değilse ve gidebilme durumu true ise
                {
                   
                    listBox1.Items.Add(b.Parent.Name.ToString().Substring(1,1) + " --> " + HedefP.Name.ToString().Substring(1, 1));
                    SuruklenenButton.Location = new Point(bKonumX, HedefP.Height - sayac * 30); // Tespit edilen butonun sayısı kadar yukarı konumlandırma
                    HedefP.Controls.Add(SuruklenenButton);
                    hSayisi++; // Sürükleme işlemi başarılıysa,hamle sayisi 1 artar.
                    StlHamleSayisi.Text = "Hamle Sayisi : " + hSayisi.ToString();
                    // panel3 e disk konulduğunda
                    int p3BSayisi = 0; // Panel 3 teki Buton sayısı bulunur foreach
                    foreach (Button pButton in p3.Controls)
                    {
                        p3BSayisi++;
                    }
                    if (HedefP == p3 && p3BSayisi == bSayisi) // Eğer hedef pane p3 se ve p3teki buton sayisi disk sayısından 1 az sa yani son disk kaldıysa
                    {
                        foreach (Button pButton in p3.Controls)
                        {
                            if (bGenislik < pButton.Width)
                            {
                                oyunBitti = true; // panel 3 teki butonlar doğru dizildiyse
                            }
                        }
                    }
                    if (oyunBitti == true && p3BSayisi == bSayisi)  //oyunu bittiyse ve panel3teki disk sayisiyle eşitse skora 10 ekle panelleri temizle
                    {
                    
                        timer_sure.Stop();
                        int dakika = saniye / 60;
                        MessageBox.Show(((hSayisi - Math.Pow(2, bSayisi)) < 0 ? "Yapılabilecek en az hamlede yaptınız. : " + ((Math.Pow(2, bSayisi)) - 1).ToString() : hSayisi.ToString() + " Hamle de yaptınız. Fakat " + (hSayisi - Math.Pow(2, bSayisi) + 1) + " hamle daha erken yapabilirdiniz.") + "\nSüreniz : " + (saniye > 60 ? dakika + "  Dakika  " + (saniye - (dakika * 60)).ToString() + " Saniye" : saniye.ToString() + " Saniye"), "Tebrikler Oyunu Bitirdiniz.");
                        pTemizle();
                      
                    }
                }
            }
        }
        private void p_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        } //Hareket efekti


        #endregion

        #region FORM LOAD - FORMU TEMİZLE - YENİ OYUN FONKSİYONU
        private void Form_Uygulama_Load(object sender, EventArgs e)
        {
            StlHamleSayisi.Text = "";
         
            this.Activate();
            this.Focus();
            cB1.SelectedIndex = 0;
          
        
        }
        public void pTemizle()
        {
            p1.Controls.Clear();
            p2.Controls.Clear();
            p3.Controls.Clear();
            listBox1.Items.Clear();
            StlHamleSayisi.Text = "";
            kynk = 0;
            hedef = 0;
            sayackynkhedef = 0;
            timer_otoMod.Stop();
            timer_sure.Stop();
       
        }
        public void yeniOyun() // Comboboxtaki disk sayisina göre küçülen buton oluşturma
        {
            pTemizle(); // Panelleri temizle
            hSayisi = 0;
            StlHamleSayisi.Text = "Hamle Sayisi : " + hSayisi.ToString();
            bSayisi = Int32.Parse(cB1.SelectedItem.ToString());
            int bXkonum = ((p1.Width - (bSayisi * 20)) / 2); // buton sayisi * 20 yani en alttaki butonun boyutu panelin boyutundan çıkartıyoruz ve 2 ye bölüyoruz
            for (int i = bSayisi; i > 0; i--)
            {
                Button butonlar = new Button();
                butonlar.Location = new System.Drawing.Point(bXkonum, 285 - (((bSayisi + 1) - i) * 30));
                butonlar.Name = "btn_" + i.ToString();
                butonlar.Size = new System.Drawing.Size(20 * i, 30);
                butonlar.BackColor = Color.FromArgb(rasgeleSayi.Next(255), rasgeleSayi.Next(255), rasgeleSayi.Next(255));
                butonlar.FlatStyle = FlatStyle.Flat;
                butonlar.Text = i.ToString();
                p1.Controls.Add(butonlar);
                butonlar.Cursor = Cursors.SizeAll;
                butonlar.MouseDown += butonlar_MouseDown;
                bXkonum += 10; // Her buton oluşturmada yukarı çıkarken x konumunda 10 artıyor
            }
            saniye = 0;
            timer_sure.Start();
        }


        private void bYeniOyun_Click(object sender, EventArgs e)
        {
            yeniOyun(); //Tıklandığında Yeni Oyun Başlatır
        }
    
        #endregion



     

        private void CB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void StlSure_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
