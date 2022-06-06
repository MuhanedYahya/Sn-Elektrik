using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uiprogect
{
    public class Su_Abonelikleri : Kisi
    {
        private int Su_Abone_Numarasi;
        private string Abone_Tarihi;
        private string Sikayet;
        private string Su_Talep_Turu;
        private DateTime Su_Talep_tarihi;
        private string SU_Talep_Aciklamasi;
        private float Su_Birim_Fiyati;

        public int Su_Abone_Numarasi1 { get => Su_Abone_Numarasi; set => Su_Abone_Numarasi = value; }
        public string Abone_Tarihi1 { get => Abone_Tarihi; set => Abone_Tarihi = value; }
        public string Sikayet1 { get => Sikayet; set => Sikayet = value; }
        public string Su_Talep_Turu1 { get => Su_Talep_Turu; set => Su_Talep_Turu = value; }
        public DateTime Su_Talep_tarihi1 { get => Su_Talep_tarihi; set => Su_Talep_tarihi = value; }
        public string SU_Talep_Aciklamasi1 { get => SU_Talep_Aciklamasi; set => SU_Talep_Aciklamasi = value; }
        public float Su_Birim_Fiyati1 { get => Su_Birim_Fiyati; set => Su_Birim_Fiyati = value; }

        public Su_Abonelikleri Giris(int AboneNumarasi, string sifre)
        {
            try
            {
                string query = $"select * from Kisi,[Su-Abonelikleri] where kisi.[Su-Abone-Numarasi]={AboneNumarasi}" +
                    $" and [Su-Abonelikleri].[Su-Abone-Numarasi]={AboneNumarasi} and Kisi.sifre='{sifre}'";

                DataTable dt = dataBaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count == 1)
                {
                    Su_Abonelikleri temp = new Su_Abonelikleri();
                    temp.Tc_kimlik = dt.Rows[0]["TC-Kimlik"].ToString();
                    temp.Isim = dt.Rows[0]["isim"].ToString();
                    temp.Adres = dt.Rows[0]["Adres"].ToString();
                    temp.Telefon = dt.Rows[0]["Telefon"].ToString();
                    temp.Email = dt.Rows[0]["Email"].ToString();
                    temp.Sifre = dt.Rows[0]["sifre"].ToString();
                    temp.Su_Abone_Numarasi1 = int.Parse(dt.Rows[0]["Su-Abone-Numarasi"].ToString());
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
        


        public int KisiEkle(Su_Abonelikleri s)
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

        public int SuEkle(string s)
        {
            try
            {
                string query = $" insert into [Su-Abonelikleri]([Abone-Tarihi])" +
                               $" values('{s}')";

                return dataBaseHelper.ExecuteNonQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void KisiyeSuAboneEkle(Su_Abonelikleri s)
        {

            string query = $"UPDATE Kisi SET [Su-Abone-Numarasi]={s.SuAboneBul()} WHERE " +
                          $" [TC-Kimlik]='{s.Tc_kimlik}'";

            dataBaseHelper.ExecuteNonQuery(query);

        }




        public int SuAboneBul()
        {
            try
            {
                string SuBul = $"SELECT TOP 1 * FROM [Su-Abonelikleri] ORDER BY [Su-Abone-Numarasi] DESC";
                return int.Parse(dataBaseHelper.ExecuteQuery(SuBul).Rows[0][0].ToString());



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


        public bool SuExists(string kimlik)
        {
            try
            {
                string query = $"select * from Kisi where [TC-Kimlik]='{kimlik}' and [Su-Abone-Numarasi] IS NOT NULL";

                return dataBaseHelper.ExecuteQuery(query).Rows.Count >= 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private bool KisiVar(int abone)
        {
            string query = $"select * from Kisi where ([Su-Abone-Numarasi]='{abone}' and " +
                $"kisi.[Elektrik-Abone-Numarasi] is NOT NULL) or ([Su-Abone-Numarasi]={abone} and kisi.[Gaz-Abone-Numarasi] is NOT NULL)";

            return dataBaseHelper.ExecuteQuery(query).Rows.Count >= 1;
        }


        public void AboneKapat(Su_Abonelikleri s)
        {
            try
            {
                string deleteFatura = $"delete [Su-Faturalari] where [Su-Abone-Numarasi]={s.Su_Abone_Numarasi1}";
                string deleteSikayet = $"delete Sikayetler where [TC-Kimlik]='{s.Tc_kimlik}'";
                string deleteTalep = $"delete [Su-Talepleri] where [Su-Abone-Numarasi]={s.Su_Abone_Numarasi1}";
                string deleteSu = $"delete [Su-Abonelikleri] where [Su-Abone-Numarasi]={s.Su_Abone_Numarasi1}";
                string updateKisi = $"update Kisi set [Su-Abone-Numarasi]=null where [TC-Kimlik]='{s.Tc_kimlik}'";
                string deleteKisi = $"delete Kisi where [Su-Abone-Numarasi]={s.Su_Abone_Numarasi1}";

                if (!KisiVar(s.Su_Abone_Numarasi1))
                {
                    dataBaseHelper.ExecuteNonQuery(deleteSikayet);
                    dataBaseHelper.ExecuteNonQuery(deleteFatura);
                    dataBaseHelper.ExecuteNonQuery(deleteTalep);
                    dataBaseHelper.ExecuteNonQuery(deleteKisi);
                    dataBaseHelper.ExecuteNonQuery(deleteSu);

                }
                dataBaseHelper.ExecuteNonQuery(deleteFatura);
                dataBaseHelper.ExecuteNonQuery(deleteTalep);
                dataBaseHelper.ExecuteNonQuery(updateKisi);
                dataBaseHelper.ExecuteNonQuery(deleteSu);

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
                string query = $"update Kisi set sifre='{sifre}' where ([TC-Kimlik]='{kimlik}' and [Su-Abone-Numarasi]={aboneNumarasi})";
                if (SuExists(kimlik))
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
                string query = $"select * from [Su-Talepleri] where [Su-Abone-Numarasi]={aboneNumarasi}";
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

                string query = $"INSERT INTO [Su-Talepleri]([Su-Talep-Turu],[Su-Talep-Tarihi],[Su-Talep-Aciklamasi],[Su-Abone-Numarasi])" +
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


        public void Guncelle(Su_Abonelikleri s)
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
                string query = $"SELECT * FROM [Su-Faturalari] WHERE [Su-Abone-Numarasi]={aboneNumarasi}";
                return dataBaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }




    }
}
