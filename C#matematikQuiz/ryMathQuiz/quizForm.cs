using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ryMathQuiz
{
    public partial class quizForm : Form
    {
        public quizForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar
        Random RSayi = new Random();
        int toplaSayi1, toplaSayi2;
        int cikarSayi1, cikarSayi2;
        int carpSayi1, carpSayi2;
        int bolSayi1, bolSayi2;
        int sureTut;
        #endregion

        #region Kullanıcı Tanımlı Olaylar
        private void SinavHazirla()
        {
            try
            {
                //toplaSolSayi.Text=(toplaSayi1 = RSayi.Next(50)).ToString ();
                toplaSayi1 = RSayi.Next(50);
                toplaSolSayi.Text = toplaSayi1.ToString();
                toplaSayi2 = RSayi.Next(50);
                toplaSagSayi.Text = toplaSayi2.ToString();
                nudTopla.Value = 0;

                cikarSayi1 = RSayi.Next(1, 101);
                cikarSolSayi.Text = cikarSayi1.ToString();
                cikarSayi2 = RSayi.Next(1, cikarSayi1);
                cikarSagSayi.Text = cikarSayi2.ToString();
                nudCikar.Value = 0;

                carpSayi1 = RSayi.Next(1, 11);
                carpSolSayi.Text = carpSayi1.ToString();
                carpSayi2 = RSayi.Next(1, 11);
                carpSagSayi.Text = carpSayi2.ToString();
                nudCarp.Value = 0;

                bolSayi1 = RSayi.Next(1, 11);
                int geciciBolme = RSayi.Next(2, 11);
                bolSayi2 = bolSayi1 * geciciBolme;
                bolSolSayi.Text = bolSayi2.ToString();
                bolSagSayi.Text = bolSayi1.ToString();
                nudBol.Value = 0;
                
                sureTut = 30;
                sureGoster.ForeColor = Color.Black;
                sureGoster.Text = sureTut.ToString();

                saat.Start();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Dikkat",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnBaslat.Select();
            }
        }

        private bool CevapKontrol()
        {
            if (((toplaSayi1 + toplaSayi2) == nudTopla.Value) &
                    ((cikarSayi1 - cikarSayi2) == nudCikar.Value) &
                    ((carpSayi1 * carpSayi2) == nudCarp.Value) &
                    ((bolSayi2 / bolSayi1) == nudBol.Value))
                return true;
            else
                return false;
        }
        #endregion

        #region Nesne Tanımlı Olaylar
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            SinavHazirla();
            btnBaslat.Enabled = false;
        }
        private void saat_Tick(object sender, EventArgs e)
        {
            if (CevapKontrol())
            {
                saat.Stop();
                MessageBox.Show("Tüm Soruları \nDoğru Şekilde Cevapladınız." +
                    "\nBravo!", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                btnBaslat.Enabled = true;
            }
            else if (sureTut > 0)
            {
                sureTut--;
                if (sureTut < 10)
                {
                    sureGoster.ForeColor = Color.Red;
                    sureGoster.Text = "Son " + sureTut.ToString() + " Saniye";
                }
                else
                    sureGoster.Text = sureTut.ToString() + " Saniye";

            }
            else
            {
                saat.Stop();
                sureGoster.Text = "Süre Bitti";
                MessageBox.Show("Sorular Verilen \nSürede Cevaplanmadı",
                    "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudTopla.Value = (toplaSayi1 + toplaSayi2);
                nudCikar.Value = (cikarSayi1 - cikarSayi2);
                nudCarp.Value = carpSayi1 * carpSayi2;
                nudBol.Value = bolSayi2 / bolSayi1;
                btnBaslat.Enabled = true;
            }
        }


        private void SonucGirisKontrolu(object sender,EventArgs e)
        {
            NumericUpDown CevapAlani = sender as NumericUpDown;
            if (CevapAlani !=null)
            {
                int CevapSayisi = CevapAlani.Value.ToString().Length;
                CevapAlani.Select(1, CevapSayisi);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulama \n Sonlandırılsın mı?", "Çıkış Onayı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }
        #endregion
    }
}
