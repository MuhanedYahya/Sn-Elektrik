using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uiprogect
{
    public class Elektrik_Abonelikleri:Kisi
    {
        private int Elektrik_Abone_Numarasi;
        private string Abone_Tarihi;
        private string Sikayet;
        private string Elektrik_Talep_Turu;
        private DateTime Elektrik_Talep_tarihi;
        private string Elektrik_Talep_Aciklamasi;

        public int Elektrik_Abone_Numarasi1 { get => Elektrik_Abone_Numarasi; set => Elektrik_Abone_Numarasi = value; }
        public string Abone_Tarihi1 { get => Abone_Tarihi; set => Abone_Tarihi = value; }
        public string Sikayet1 { get => Sikayet; set => Sikayet = value; }
        public string Elektrik_Talep_Turu1 { get => Elektrik_Talep_Turu; set => Elektrik_Talep_Turu = value; }
        public DateTime Elektrik_Talep_tarihi1 { get => Elektrik_Talep_tarihi; set => Elektrik_Talep_tarihi = value; }
        public string Elektrik_Talep_Aciklamasi1 { get => Elektrik_Talep_Aciklamasi; set => Elektrik_Talep_Aciklamasi = value; }



        public  Elektrik_Abonelikleri Giris(int AboneNumarasi, string sifre)
        {
            try
            {
                string query = $"select * from Kisi,[Elektrik-Abonelikleri] where kisi.[Elektrik-Abone-Numarasi]={AboneNumarasi}" +
                    $" and [Elektrik-Abonelikleri].[Elektrik-Abone-Numarasi]={AboneNumarasi} and Kisi.sifre='{sifre}'";


                DataTable dt = dataBaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count ==1)
                {
                    Elektrik_Abonelikleri temp = new Elektrik_Abonelikleri();
                    temp.Tc_kimlik = dt.Rows[0]["TC-Kimlik"].ToString();
                    temp.Isim = dt.Rows[0]["isim"].ToString();
                    temp.Adres = dt.Rows[0]["Adres"].ToString();
                    temp.Telefon = dt.Rows[0]["Telefon"].ToString();
                    temp.Email = dt.Rows[0]["Email"].ToString();
                    temp.Sifre = dt.Rows[0]["sifre"].ToString();
                    temp.Elektrik_Abone_Numarasi1 = int.Parse(dt.Rows[0]["Elektrik-Abone-Numarasi"].ToString());
                    temp.Abone_Tarihi1 = dt.Rows[0][10].ToString();
                    return temp;
                }
                if (dt.Rows.Count !=1)
                {
                    throw new Exception("Abone Numarası veya şifre yanlış girildi");
                }
                return null;
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }

        }
      


        public int KisiEkle(Elektrik_Abonelikleri s)
        {
            try
            {
                string query = $"insert into Kisi([TC-Kimlik],isim,Adres,Telefon,Email,sifre)" +
                               $" values('{s.Tc_kimlik}', '{s.Isim}', '{s.Adres}', '{s.Telefon}', '{s.Email}', '{s.Sifre}')";
                               
                return dataBaseHelper.ExecuteNonQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int ElektrikEkle(string s)
        {
            try
            {
                string query = $" insert into [Elektrik-Abonelikleri]([Abone-Tarihi])" +
                               $" values('{s}')";

                return dataBaseHelper.ExecuteNonQuery(query);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void KisiyeElektrikAboneEkle(Elektrik_Abonelikleri s)
        {

            try
            {
                string query = $"UPDATE Kisi SET [Elektrik-Abone-Numarasi]={s.ElektrikAboneBul()} WHERE " +
                          $" [TC-Kimlik]='{s.Tc_kimlik}'";

                dataBaseHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }




        public int ElektrikAboneBul()
        {
            try
            {
                string ElektrikBul = $"SELECT TOP 1 * FROM [Elektrik-Abonelikleri] ORDER BY [Elektrik-Abone-Numarasi] DESC";
                return int.Parse(dataBaseHelper.ExecuteQuery(ElektrikBul).Rows[0][0].ToString());
                


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool kimlikExists(string kimlik)
        {
            try
            {
                string query = $"select * from Kisi where [TC-Kimlik]='{kimlik}'";
                    
                return dataBaseHelper.ExecuteQuery(query).Rows.Count >= 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool ElektrikExists(string kimlik)
        {
            try
            {
                string query = $"select * from Kisi where ([TC-Kimlik]='{kimlik}' and [Elektrik-Abone-Numarasi] IS NOT NULL)";


                return dataBaseHelper.ExecuteQuery(query).Rows.Count == 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool KisiVar(int abone)
        {
            string query = $"select * from Kisi where ([Elektrik-Abone-Numarasi]='{abone}' and " +
                $"kisi.[Su-Abone-Numarasi] is NOT NULL) or ([Elektrik-Abone-Numarasi]={abone} and kisi.[Gaz-Abone-Numarasi] is NOT NULL)";

            return dataBaseHelper.ExecuteQuery(query).Rows.Count >= 1;
        }


        public void AboneKapat(Elektrik_Abonelikleri s)
        {
            try
            {
                string deleteFatura = $"delete [Elektrik-Faturalari] where [Elektrik-Abone-Numarasi]={s.Elektrik_Abone_Numarasi1}";
                string deleteSikayet = $"delete Sikayetler where [TC-Kimlik]='{s.Tc_kimlik}'";
                string deleteTalep = $"delete [Elektrik-Talepleri] where [Elektrik-Abone-Numarasi]={s.Elektrik_Abone_Numarasi1}";
                    string deleteElektrik=$"delete [Elektrik-Abonelikleri] where [Elektrik-Abone-Numarasi]={s.Elektrik_Abone_Numarasi1}";
                string updateKisi = $"update Kisi set [Elektrik-Abone-Numarasi]=null where [TC-Kimlik]='{s.Tc_kimlik}'";
                string deleteKisi = $"delete Kisi where [Elektrik-Abone-Numarasi]={s.Elektrik_Abone_Numarasi1}";
              
                if (!KisiVar(s.Elektrik_Abone_Numarasi1))
                {
                    dataBaseHelper.ExecuteNonQuery(deleteSikayet);
                    dataBaseHelper.ExecuteNonQuery(deleteFatura);
                    dataBaseHelper.ExecuteNonQuery(deleteTalep);
                    dataBaseHelper.ExecuteNonQuery(deleteKisi);
                    dataBaseHelper.ExecuteNonQuery(deleteElektrik);
                    
                }
                    dataBaseHelper.ExecuteNonQuery(deleteFatura);
                    dataBaseHelper.ExecuteNonQuery(deleteTalep);
                    dataBaseHelper.ExecuteNonQuery(updateKisi);
                    dataBaseHelper.ExecuteNonQuery(deleteElektrik);
                 
                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




        public void SifreResetle(string kimlik,int aboneNumarasi,string sifre) 
        {
            try
            {
                string query = $"update Kisi set sifre='{sifre}' where ([TC-Kimlik]='{kimlik}' and [Elektrik-Abone-Numarasi]={aboneNumarasi})";
                dataBaseHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }




        public DataTable TumTalepler(int aboneNumarasi)
        {
            try
            {
                string query = $"select * from [Elektrik-Talepleri] where [Elektrik-Abone-Numarasi]={aboneNumarasi}";
                return dataBaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public int TalepEkle(string tur,DateTime time,string aciklama,int aboneNumarasi)
        {
            try
            {
                
                string query = $"INSERT INTO [Elektrik-Talepleri]([Elektrik-Talep-Turu],[Elektrik-Talep-Tarihi],[Elektrik-Talep-Aciklamasi],[Elektrik-Abone-Numarasi])" +
                    $" VALUES('{tur}','{time}','{aciklama}',{aboneNumarasi})";


                return dataBaseHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public int SikayetEkle(string tc,string sikayet)
        {
            try
            {
                string query = $"insert into Sikayetler([TC-Kimlik],sikayet) values('{tc}','{sikayet}')";
                return dataBaseHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




        public void Guncelle(Elektrik_Abonelikleri s)
        {

            try
            {
                string query = $"update Kisi set isim='{s.Isim}',Telefon='{s.Telefon}',Email='{s.Email}'," +
                          $"Adres='{s.Adres}',sifre='{s.Sifre}' where [TC-Kimlik]='{s.Tc_kimlik}'";

                dataBaseHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }


        public DataTable TumFaturalar(int aboneNumarasi)
        {
            try
            {
                string query = $"SELECT * FROM [Elektrik-Faturalari] WHERE [Elektrik-Abone-Numarasi]={aboneNumarasi}";
                return dataBaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }




    }
}
