using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uiprogect
{
    public class Gaz_Abonelikleri:Kisi
    {
        private int Gaz_Abone_Numarasi;
        private string Abone_Tarihi;
        private string Sikayet;
        private string Gaz_Talep_Turu;
        private DateTime Gaz_Talep_tarihi;
        private string Gaz_Talep_Aciklamasi;

        public int Gaz_Abone_Numarasi1 { get => Gaz_Abone_Numarasi; set => Gaz_Abone_Numarasi = value; }
        public string Abone_Tarihi1 { get => Abone_Tarihi; set => Abone_Tarihi = value; }
        public string Sikayet1 { get => Sikayet; set => Sikayet = value; }
        public string Gaz_Talep_Turu1 { get => Gaz_Talep_Turu; set => Gaz_Talep_Turu = value; }
        public DateTime Gaz_Talep_tarihi1 { get => Gaz_Talep_tarihi; set => Gaz_Talep_tarihi = value; }
        public string Gaz_Talep_Aciklamasi1 { get => Gaz_Talep_Aciklamasi; set => Gaz_Talep_Aciklamasi = value; }




        public Gaz_Abonelikleri Giris(int AboneNumarasi, string sifre)
        {
            try
            {
                string query = $"select * from Kisi,[Gaz-Abonelikleri] where kisi.[Gaz-Abone-Numarasi]={AboneNumarasi}" +
                    $" and [Gaz-Abonelikleri].[Gaz-Abone-Numarasi]={AboneNumarasi} and Kisi.sifre='{sifre}'";

                DataTable dt = dataBaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count == 1)
                {
                    Gaz_Abonelikleri temp = new Gaz_Abonelikleri();
                    temp.Tc_kimlik = dt.Rows[0]["TC-Kimlik"].ToString();
                    temp.Isim = dt.Rows[0]["isim"].ToString();
                    temp.Adres = dt.Rows[0]["Adres"].ToString();
                    temp.Telefon = dt.Rows[0]["Telefon"].ToString();
                    temp.Email = dt.Rows[0]["Email"].ToString();
                    temp.Sifre = dt.Rows[0]["sifre"].ToString();
                    temp.Gaz_Abone_Numarasi1 = int.Parse(dt.Rows[0]["Gaz-Abone-Numarasi"].ToString());
                    temp.Abone_Tarihi1 = dt.Rows[0][10].ToString();
                    return temp;
                }
                if (dt.Rows.Count != 1)
                {
                    throw new Exception("Abone Numarası veya şifre yanlış girildi");
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
      


        public int KisiEkle(Gaz_Abonelikleri s)
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

        public int GazEkle(string s)
        {
            try
            {
                string query = $" insert into [Gaz-Abonelikleri]([Abone-Tarihi])" +
                               $" values('{s}')";

                return dataBaseHelper.ExecuteNonQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void KisiyeGazAboneEkle(Gaz_Abonelikleri s)
        {

            string query = $"UPDATE Kisi SET [Gaz-Abone-Numarasi]={s.GazAboneBul()} WHERE " +
                          $" [TC-Kimlik]='{s.Tc_kimlik}'";

            dataBaseHelper.ExecuteNonQuery(query);

        }




        public int GazAboneBul()
        {
            try
            {
                string ElektrikBul = $"SELECT TOP 1 * FROM [Gaz-Abonelikleri] ORDER BY [Gaz-Abone-Numarasi] DESC";
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


        public bool GazExists(string kimlik)
        {
            try
            {
                string query = $"select * from Kisi where [TC-Kimlik]='{kimlik}' and [Gaz-Abone-Numarasi] IS NOT NULL";
                return dataBaseHelper.ExecuteQuery(query).Rows.Count >= 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private bool KisiVar(int abone)
        {
            string query = $"select * from Kisi where ([Gaz-Abone-Numarasi]='{abone}' and " +
                $"kisi.[Su-Abone-Numarasi] is NOT NULL) or ([Gaz-Abone-Numarasi]={abone} and kisi.[Elektrik-Abone-Numarasi] is NOT NULL)";

            return dataBaseHelper.ExecuteQuery(query).Rows.Count >= 1;
        }


        public void AboneKapat(Gaz_Abonelikleri s)
        {
            try
            {
                string deleteFatura = $"delete [Gaz-Faturalari] where [Gaz-Abone-Numarasi]={s.Gaz_Abone_Numarasi1}";
                string deleteSikayet = $"delete Sikayetler where [TC-Kimlik]='{s.Tc_kimlik}'";
                string deleteTalep = $"delete [Gaz-Talepleri] where [Gaz-Abone-Numarasi]={s.Gaz_Abone_Numarasi1}";
                string deleteGaz = $"delete [Gaz-Abonelikleri] where [Gaz-Abone-Numarasi]={s.Gaz_Abone_Numarasi1}";
                string updateKisi = $"update Kisi set [Gaz-Abone-Numarasi]=null where [TC-Kimlik]='{s.Tc_kimlik}'";
                string deleteKisi = $"delete Kisi where [Gaz-Abone-Numarasi]={s.Gaz_Abone_Numarasi1}";

                if (!KisiVar(s.Gaz_Abone_Numarasi1))
                {
                    dataBaseHelper.ExecuteNonQuery(deleteSikayet);
                    dataBaseHelper.ExecuteNonQuery(deleteFatura);
                    dataBaseHelper.ExecuteNonQuery(deleteTalep);
                    dataBaseHelper.ExecuteNonQuery(deleteKisi);
                    dataBaseHelper.ExecuteNonQuery(deleteGaz);

                }
                dataBaseHelper.ExecuteNonQuery(deleteFatura);
                dataBaseHelper.ExecuteNonQuery(deleteTalep);
                dataBaseHelper.ExecuteNonQuery(updateKisi);
                dataBaseHelper.ExecuteNonQuery(deleteGaz);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int SifreResetle(string kimlik, int aboneNumarasi, string sifre)
        {
            try
            {
                string query = $"update Kisi set sifre='{sifre}' where ([TC-Kimlik]='{kimlik}' and [Gaz-Abone-Numarasi]={aboneNumarasi})";
                if (GazExists(kimlik))
                {
                    dataBaseHelper.ExecuteNonQuery(query);
                    return 1;
                }
                return 0;
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
                string query = $"select * from [Gaz-Talepleri] where [Gaz-Abone-Numarasi]={aboneNumarasi}";
                return dataBaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public int TalepEkle(string tur, DateTime time, string aciklama, int aboneNumarasi)
        {
            try
            {

                string query = $"INSERT INTO [Gaz-Talepleri]([Gaz-Talep-Turu],[Gaz-Talep-Tarihi],[Gaz-Talep-Aciklamasi],[Gaz-Abone-Numarasi])" +
                    $" VALUES('{tur}','{time}','{aciklama}',{aboneNumarasi})";


                return dataBaseHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int SikayetEkle(string tc, string sikayet)
        {
            try
            {
                string query = $"insert into Sikayetler([TC-Kimlik],sikayet) values({tc},'{sikayet}')";
                return dataBaseHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public void Guncelle(Gaz_Abonelikleri s)
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
                string query = $"SELECT * FROM [Gaz-Faturalari] WHERE [Gaz-Abone-Numarasi]={aboneNumarasi}";
                return dataBaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }





    }
}

