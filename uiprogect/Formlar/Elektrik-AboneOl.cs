using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiprogect
{
    public partial class AboneOL : Form
    {
        
        public AboneOL()
        {
            InitializeComponent();          
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboneOL_Load(object sender, EventArgs e)
        {

        }

        private void T_isim_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void T_TC_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void T_Email_TextChanged(object sender, EventArgs e)
        {
           
        }

      

        private void T_Telefon_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void T_Sıfre_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void T_Adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void But_Kaydet_Click(object sender, EventArgs e)
        {



            try
            {
                

                Elektrik_Abonelikleri p = new Elektrik_Abonelikleri();
                p.Isim = T_isim.Text.TrimStart().TrimEnd();
                p.Tc_kimlik = T_TC.Text;
                p.Email = T_Email.Text.Trim().TrimStart().TrimEnd();
                p.Telefon = T_Telefon.Text;
                p.Sifre = T_Sifre.Text;
                p.Adres = T_Adres.Text.TrimStart().TrimEnd();
                p.Abone_Tarihi1 = DateTime.Now.ToString();

                if (p.kimlikExists(p.Tc_kimlik) == false)
                {
                    if (string.IsNullOrWhiteSpace(T_isim.Text))
                    {
                        throw new Exception("Isim alanı boş bırakılamaz");
                    }
                    if ((string.IsNullOrWhiteSpace(T_TC.Text)) || (T_TC.Text.Contains(" ")) || (T_TC.Text.Length != 11))
                    {
                        throw new Exception("TC alanı boş yada boşluklu bırakılamaz");
                    }
                    if (string.IsNullOrWhiteSpace(T_Email.Text))
                    {
                        throw new Exception("Email alanı boş bırakılamaz");
                    }
                    if (string.IsNullOrWhiteSpace(T_Telefon.Text) || T_Telefon.Text.Contains(" ") || T_Telefon.Text.Length != 10)
                    {
                        throw new Exception("Telefon alanı boş yada boşluklu bırakılamaz");
                    }
                    if (string.IsNullOrWhiteSpace(T_Sifre.Text) || T_Sifre.Text.Contains(" "))
                    {
                        throw new Exception("şifre alanı boş yada boşluklu bırakılamaz");
                    }
                    if (string.IsNullOrWhiteSpace(T_Adres.Text))
                    {
                        throw new Exception("Adres alanı boş bırakılamaz");
                    }

                    p.ElektrikEkle(p.Abone_Tarihi1);
                    p.KisiEkle(p);
                    int abone = p.ElektrikAboneBul();
                    p.KisiyeElektrikAboneEkle(p);
                    MessageBox.Show($"SN Şirketine Hoşgeldiniz. Elektrik Abone Numaranız: {abone} kimseyle paylaşmayınız\n" +
                        $"Girdiğiniz bilgiler şirketimizdeki diğer abonelikleriniz için geçerli olacak");
                    this.Close();
                }

                if (p.kimlikExists(T_TC.Text) == true)
                {
                    if (p.ElektrikExists(p.Tc_kimlik) == true)
                    {
                       throw new Exception("SN-Elektrik Şirketimizde bu TC-Kimlik Numarasına ait hesap bulunmaktadır");
                    }

                    if (p.ElektrikExists(p.Tc_kimlik) == false)
                    {
                        p.ElektrikEkle(p.Abone_Tarihi1);
                        int Abone = p.ElektrikAboneBul();
                        p.KisiyeElektrikAboneEkle(p);
                        MessageBox.Show($"Şirketimizde TC-Kimlik Numarasına ait bilgileriniz bulundu Bilgilerinizi daha sonra değiştirebilirsiniz.\n" +
                            $"Elektrik Abone Numaranız: {Abone} kimseyle paylaşmayın");
                        this.Close();
                    }
                        

                }

            }
            catch (Exception x)
            {
                lblHata.Text = x.Message;
            }


        }
        




















    }
}
