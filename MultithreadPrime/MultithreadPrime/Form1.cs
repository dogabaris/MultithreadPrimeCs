using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Threading;

namespace MultithreadPrime
{
    public partial class MultiThreadPrime : Form
    {
        bool flag=true;
        int karekoksayi, aralik, kalan,suankisayi,threadnumarasi;
        int threadsayisi,asallik,elemansayisi,sonasalsayi;
        MySqlConnection baglanti;
        List<string> sonuc = new List<string>();
        List<string> arasonuc = new List<string>();
        List<List<int>> limitler = new List<List<int>>();
        

        public MultiThreadPrime()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //btn_bitir.Enabled = false;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
            string bag;

            build.UserID = "root";
            build.Password = "";
            build.Database = "multithreadprime";
            build.Server = "localhost";

            bag = build.ToString();

            baglanti = new MySqlConnection(bag);
            SonuncuyuGetir();
            
            this.dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            flag = true;
            btn_basla.Hide();
            Thread BaslaThreeadi = new Thread(() => BaslaButonu());
            BaslaThreeadi.Start();
            
        }

        private void num_sayi_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BaslaButonu()
        {
            while (flag)
            {
            label_sayi.Text = sonasalsayi.ToString();
            sonuc.Clear();
            limitler.Clear();
            List<int> asalsayilistesi = new List<int>();
            karekoksayi = (int)Math.Sqrt(Convert.ToDouble(sonasalsayi));

            for (int i = 2; i <= karekoksayi; i++)
            {
                asallik = 1;
                for (int k = 2; k < i; k++)
                {

                    if (i % k == 0)//asal degildir.
                    {
                        asallik = 0;

                        break;
                    }
                }

                if (asallik == 1)
                    asalsayilistesi.Add(i);//asaldir.

            }

            elemansayisi = asalsayilistesi.Count;
            threadsayisi = (elemansayisi / 100) + 1;

            if (elemansayisi <= 100)
                threadsayisi = 2;

            aralik = asalsayilistesi.Count / threadsayisi;
            kalan = asalsayilistesi.Count % threadsayisi;

            int sayac = 0;
            int baslangic = 0;

            for (int j = 0; j < threadsayisi; j++)
            {
                List<int> row = new List<int>();

                for (int i = baslangic; i <= asalsayilistesi.Count; i++)
                {
                    if (sayac == aralik + kalan)
                        break;


                    try//4,5,6,7,8 sayılarında for döngüsü durmayıp dizinin olmayan bir indexini yeni diziye atamaya çalışıyor bu yüzden try-catch
                    {
                        row.Add(asalsayilistesi[i]);
                        sayac++;
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        //break;
                    }

                }
                sayac = 0;
                baslangic += aralik + kalan;

                limitler.Add(row);
            }

            foreach (List<int> row in limitler)
            {
                foreach (int r in row)
                {
                    Debug.WriteLine(r.ToString());
                }

                Debug.WriteLine("ara");
            }

            List<Thread> Threadlar = new List<Thread>();
            


            for (int c = 0; c < threadsayisi; c++)
            {
                sonuc.Add("false");
                int copy = c;
                Threadlar.Add(new Thread(() => ThreadFonksiyonu(limitler[copy], copy)));    
            }


            foreach (Thread thread in Threadlar)
            {
                thread.Start();
            }

            foreach (Thread thread in Threadlar)
            {
                thread.Join();
            }

            //SqlTablosunuTemizle();
            //AsalSayilariSqleYaz(asalsayilistesi);
            //SqlIslemi.Start();
            //SqlIslemi.Join();
            SayiAsalMi(sonuc);
            TabloyuCiz(aralik);
            sonasalsayi += 2;
            }
        }
        private void SayiAsalMi(List<string> sonuc)
        {
            if (sonuc.Contains("true")==false)
            {
                Thread SqlIslemi = new Thread(() => AsalSayilariSqleYaz(sonasalsayi));
                //AsalSayilariSqleYaz(sonasalsayi);
                SqlIslemi.Start();
                SqlIslemi.Join();
            }
        }
        private void SonuncuyuGetir()
        {
            baglanti.Open();          
            MySqlCommand getir = new MySqlCommand("SELECT asalsayilar FROM tablo ORDER BY asalsayilar DESC LIMIT 1", baglanti);
            sonasalsayi = Convert.ToInt32(getir.ExecuteScalar());
            baglanti.Close();
        }

        private void ThreadFonksiyonu(List<int> limitler,int kacincithread)
        {
            string flag="false";
            for (int k = 0; k < limitler.Count; k++)
            {
                if (sonasalsayi % limitler[k] == 0)
                {
                    
                    Debug.WriteLine("true " + limitler[k]);
                    flag = "true";
                    sonuc[kacincithread] = flag;
                    threadnumarasi = k;
                    suankisayi = limitler[k];
                    break;
                }
                else
                {
                    Debug.WriteLine("false");
                    flag = "false";          
                }
                
            }
            
        }

        private void AsalSayilariSqleYaz(int sonasalsayi)
        {
            try
            {
                baglanti.Open();
            }
            catch(System.InvalidOperationException){
                baglanti.Close();
            }
            
                MySqlCommand ekle = new MySqlCommand("insert into tablo (AsalSayilar) values ('" + sonasalsayi + "')", baglanti);
                ekle.ExecuteNonQuery();

            baglanti.Close();
        }

        private void SqlTablosunuTemizle()
        {
            string sql = "DELETE FROM tablo";
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            try
            {
                baglanti.Open();
            }
            catch (System.InvalidOperationException)
            {
                baglanti.Close();
            }
            adapter.Fill(dt);
            baglanti.Close();
        }

        private void TabloyuCiz(int aralik)
        {
            
            dataGridView.Rows.Clear();
            for (int k = 0; k<threadsayisi ;k++ )
            {
                try
                {
                    dataGridView.Rows.Add(k, limitler[k].First(), limitler[k].Last(), sonuc[k]); 
                }
                catch (System.InvalidOperationException)//4 5 6 7 8 için 2 threade bölünmesine rağmen 2.bir asalsayı eksikliğinden yazdırılamıyordu.
                {

                }
                             
            }
            
        }

        private void btn_bitir_Click(object sender, EventArgs e)
        {
            flag = false;
            btn_basla.Show();
            
            int hangithread = sonuc.FindIndex(key => key == "true");
                if(!sonuc.Contains("true"))
                    label_sonuc.Text = "Sayı asaldır!";
                else
                    label_sonuc.Text = "Sayı asal değilidir! \n" + "Thread " + hangithread + " da bulunan " + suankisayi + "\n sayisina tam bölünmektedir.";
            
        }

        

        }
     
}

