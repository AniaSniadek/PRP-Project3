using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;
using System.Net;

namespace Projekt_bazodanowy
{
    public partial class Form1 : Form
    {
        DatabaseBasketballEntities dbModel;

        public Form1(bool  b = true)
        {
            InitializeComponent();

            if (b == true)
            {
                dbModel = new DatabaseBasketballEntities();
                dbModel.Configuration.ProxyCreationEnabled = false;
            }
        }

        public bool PobierzZespolSerwer(out ObiektZespol obj, string url)
        {
            obj = new ObiektZespol();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            try
            {
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if ((int)httpResponse.StatusCode < 200 && (int)httpResponse.StatusCode > 299)
                        return false;

                    var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    var rezultat = streamReader.ReadToEnd();
                    obj = JsonConvert.DeserializeObject<ObiektZespol>(rezultat);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void PobierzZespol_Click(object sender, EventArgs e)
        {
            ObiektZespol obj;
            string url = "http://ania.feel3d.nazwa.pl/api/zespol/read.php";
            PobierzZespolSerwer(out obj, url);
            dataGridView1.DataSource = obj.obiekt[0].records;
            int elementy = obj.obiekt[1].summary.ilosc;
            label15.Text = elementy.ToString();
        }

        public bool PobierzPrezesSerwer(out ObiektPrezes obj, string url)
        {
            obj = new ObiektPrezes();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            try
            {
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if ((int)httpResponse.StatusCode < 200 && (int)httpResponse.StatusCode > 299)
                        return false;

                    var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    var rezultat = streamReader.ReadToEnd();
                    obj = JsonConvert.DeserializeObject<ObiektPrezes>(rezultat);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void PobierzPrezes_Click(object sender, EventArgs e)
        {
            ObiektPrezes obj;
            string url = "http://ania.feel3d.nazwa.pl/api/prezes/read.php";
            PobierzPrezesSerwer(out obj, url);
            dataGridView1.DataSource = obj.obiekt[0].records;
            int elementy = obj.obiekt[1].summary.ilosc;
            label15.Text = elementy.ToString();
        }

        public bool PobierzTrenerSerwer(out ObiektTrener obj, string url)
        {
            obj = new ObiektTrener();
            
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            try
            {
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if ((int)httpResponse.StatusCode < 200 && (int)httpResponse.StatusCode > 299)
                        return false;

                    var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    var rezultat = streamReader.ReadToEnd();
                    obj = JsonConvert.DeserializeObject<ObiektTrener>(rezultat);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void PobierzTrenera()
        {
            ObiektTrener obj;
            string url = "http://ania.feel3d.nazwa.pl/api/trenerzy/read.php";
            PobierzTrenerSerwer(out obj, url);
            dataGridView1.DataSource = obj.obiekt[0].records;
            int elementy = obj.obiekt[1].summary.ilosc;
            label15.Text = elementy.ToString();
        }

        public void PobierzTrener_Click(object sender, EventArgs e)
        {
            PobierzTrenera();
        }

        public bool PobierzHalaSerwer(out ObiektHala obj, string url)
        {
            obj = new ObiektHala();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            try
            {
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if ((int)httpResponse.StatusCode < 200 && (int)httpResponse.StatusCode > 299)
                        return false;

                    var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    var rezultat = streamReader.ReadToEnd();
                    obj = JsonConvert.DeserializeObject<ObiektHala>(rezultat);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void PobierzHale_Click(object sender, EventArgs e)
        {
            ObiektHala obj;
            string url = "http://ania.feel3d.nazwa.pl/api/hala/read.php";
            PobierzHalaSerwer(out obj, url);
            dataGridView1.DataSource = obj.obiekt[0].records;
            int elementy = obj.obiekt[1].summary.ilosc;
            label15.Text = elementy.ToString();
        }

        public bool PobierzZawodnikSerwer(out ObiektZawodnik obj, string url)
        {
            obj = new ObiektZawodnik();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            try
            {
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if ((int)httpResponse.StatusCode < 200 && (int)httpResponse.StatusCode > 299)
                        return false;

                    var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    var rezultat = streamReader.ReadToEnd();
                    obj = JsonConvert.DeserializeObject<ObiektZawodnik>(rezultat);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void PobierzZawodnika()
        {
            ObiektZawodnik obj;
            string url = "http://ania.feel3d.nazwa.pl/api/zawodnicy/read.php";
            PobierzZawodnikSerwer(out obj, url);
            dataGridView1.DataSource = obj.obiekt[0].records;
            int elementy = obj.obiekt[1].summary.ilosc;
            label15.Text = elementy.ToString();
        }

        public void PobierzZawodnik_Click(object sender, EventArgs e)
        {
            PobierzZawodnika();
        }

        private bool DodajTreneraSerwer(Trener trener)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://ania.feel3d.nazwa.pl/api/trenerzy/create.php");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string JsonString = JsonConvert.SerializeObject(trener);

                    streamWriter.Write(JsonString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            try
            {
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if ((int)httpResponse.StatusCode < 200 && (int)httpResponse.StatusCode > 299)
                    {
                        return false;
                    }
                    var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void DodajTrenera_Click(object sender, EventArgs e)
        {
            Trener trener = new Trener();
            trener.trener_id = Int32.Parse(textBox1.Text);
            trener.nazwisko = textBox2.Text;
            DodajTreneraSerwer(trener);
            MessageBox.Show(null, "Dodano trenera!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PobierzTrenera();
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private bool EdytujTreneraSerwer(Trener trener)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://ania.feel3d.nazwa.pl/api/trenerzy/edit.php");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string JsonString = JsonConvert.SerializeObject(trener);

                    streamWriter.Write(JsonString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            try
            {
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if ((int)httpResponse.StatusCode < 200 && (int)httpResponse.StatusCode > 299)
                    {
                        return false;
                    }
                    var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void EdytujTrenera_Click(object sender, EventArgs e)
        {
            Trener trener = new Trener();
            trener.trener_id = Int32.Parse(textBox3.Text);
            trener.nazwisko = textBox4.Text;
            EdytujTreneraSerwer(trener);
            MessageBox.Show(null, "Edytowano trenera!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PobierzTrenera();
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
        }

        private bool UsunTreneraSerwer(Trener trener)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://ania.feel3d.nazwa.pl/api/trenerzy/delete.php");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string JsonString = JsonConvert.SerializeObject(trener);

                    streamWriter.Write(JsonString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            try
            {
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if ((int)httpResponse.StatusCode < 200 && (int)httpResponse.StatusCode > 299)
                    {
                        return false;
                    }
                    var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void UsunTrenera_Click(object sender, EventArgs e)
        {
            Trener trener = new Trener();
            trener.trener_id = Int32.Parse(textBox5.Text);
            UsunTreneraSerwer(trener);
            MessageBox.Show(null, "Usunięto trenera!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PobierzTrenera();
            textBox5.Text = String.Empty;
        }

        private bool DodajZawodnikaSerwer(Zawodnik zawodnik)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://ania.feel3d.nazwa.pl/api/zawodnicy/create.php");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string JsonString = JsonConvert.SerializeObject(zawodnik);

                    streamWriter.Write(JsonString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            try
            {
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if ((int)httpResponse.StatusCode < 200 && (int)httpResponse.StatusCode > 299)
                    {
                        return false;
                    }
                    var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void DodajZawodnika_Click(object sender, EventArgs e)
        {
            Zawodnik zawodnik = new Zawodnik();
            zawodnik.zawodnik_id = Int32.Parse(textBox6.Text);
            zawodnik.nazwisko = textBox7.Text;
            zawodnik.numer = Int32.Parse(textBox8.Text);
            zawodnik.data_urodzin = DateTime.Parse(textBox9.Text);
            DodajZawodnikaSerwer(zawodnik);
            MessageBox.Show(null, "Dodano zawodnika!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PobierzZawodnika();
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox8.Text = String.Empty;
            textBox9.Text = String.Empty;
        }

        private bool EdytujZawodnikaSerwer(Zawodnik zawodnik)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://ania.feel3d.nazwa.pl/api/zawodnicy/edit.php");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string JsonString = JsonConvert.SerializeObject(zawodnik);

                    streamWriter.Write(JsonString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            try
            {
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if ((int)httpResponse.StatusCode < 200 && (int)httpResponse.StatusCode > 299)
                    {
                        return false;
                    }
                    var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void EdytujZawodnika_Click(object sender, EventArgs e)
        {
            Zawodnik zawodnik = new Zawodnik();
            zawodnik.zawodnik_id = Int32.Parse(textBox12.Text);
            zawodnik.nazwisko = textBox13.Text;
            zawodnik.numer = Int32.Parse(textBox11.Text);
            zawodnik.data_urodzin = DateTime.Parse(textBox10.Text);
            EdytujZawodnikaSerwer(zawodnik);
            MessageBox.Show(null, "Edytowano zawodnika!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PobierzZawodnika();
            textBox12.Text = String.Empty;
            textBox13.Text = String.Empty;
            textBox11.Text = String.Empty;
            textBox10.Text = String.Empty;
        }

        private bool UsunZawodnikaSerwer(Zawodnik zawodnik)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://ania.feel3d.nazwa.pl/api/zawodnicy/delete.php");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string JsonString = JsonConvert.SerializeObject(zawodnik);

                    streamWriter.Write(JsonString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            try
            {
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    if ((int)httpResponse.StatusCode < 200 && (int)httpResponse.StatusCode > 299)
                    {
                        return false;
                    }
                    var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void UsunZawodnika_Click(object sender, EventArgs e)
        {
            Zawodnik zawodnik = new Zawodnik();
            zawodnik.zawodnik_id = Int32.Parse(textBox14.Text);
            UsunZawodnikaSerwer(zawodnik);
            MessageBox.Show(null, "Usunięto zawodnika!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PobierzZawodnika();
            textBox14.Text = String.Empty;
        }
    }

    public class Podsumowanie
    {
        public int ilosc;
    }

    public class OdpowiedzZespol
    {
        public List<Zespol> records;
        public Podsumowanie summary;
        public OdpowiedzZespol() { records = new List<Zespol>(); }
    }

    public class ObiektZespol
    {
        public List<OdpowiedzZespol> obiekt;
        public ObiektZespol() { obiekt = new List<OdpowiedzZespol>(); }
    }

    public class OdpowiedzPrezes
    {
        public List<Prezes> records;
        public Podsumowanie summary;
        public OdpowiedzPrezes() { records = new List<Prezes>(); }
    }

    public class ObiektPrezes
    {
        public List<OdpowiedzPrezes> obiekt;
        public ObiektPrezes() { obiekt = new List<OdpowiedzPrezes>(); }
    }

    public class OdpowiedzTrener
    {
        public List<Trener> records;
        public Podsumowanie summary;
        public OdpowiedzTrener() { records = new List<Trener>(); }
    }

    public class ObiektTrener
    {
        public List<OdpowiedzTrener> obiekt;
        public ObiektTrener() { obiekt = new List<OdpowiedzTrener>(); }
    }

    public class OdpowiedzHala
    {
        public List<Hala> records;
        public Podsumowanie summary;
        public OdpowiedzHala() { records = new List<Hala>(); }
    }

    public class ObiektHala
    {
        public List<OdpowiedzHala> obiekt;
        public ObiektHala() { obiekt = new List<OdpowiedzHala>(); }
    }

    public class OdpowiedzZawodnik
    {
        public List<Zawodnik> records;
        public Podsumowanie summary;
        public OdpowiedzZawodnik() { records = new List<Zawodnik>(); }
    }

    public class ObiektZawodnik
    {
        public List<OdpowiedzZawodnik> obiekt;
        public ObiektZawodnik() { obiekt = new List<OdpowiedzZawodnik>(); }
    }
}
