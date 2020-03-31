using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt_bazodanowy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_bazodanowy.Tests
{

    [TestClass()]
    public class Form1TestBasketball
    {
        [TestMethod()]
        public void pobierzZespolSerwerTest_Pozytywny()
        {
            Form1 forma = new Form1(false);
            bool resultat = true;
            ObiektZespol obj;
            obj = new ObiektZespol();
            string url = "http://ania.feel3d.nazwa.pl/api/zespol/read.php";
            resultat = forma.PobierzZespolSerwer(out obj, url);

            Assert.AreEqual(resultat, true);
        }

        [TestMethod()]
        public void pobierzZespolSerwerTest_Negatywny()
        {
            Form1 forma = new Form1(false);
            bool resultat = true;
            ObiektZespol obj;
            obj = new ObiektZespol();
            string url = "http://ania.feel3d.nazwa.pl/api/zespol/read111.php";
            resultat = forma.PobierzZespolSerwer(out obj, url);

            Assert.AreEqual(resultat, false);
        }

        [TestMethod()]
        public void pobierzPrezesSerwerTest_Pozytyny()
        {
            Form1 forma = new Form1(false);
            bool resultat = false;
            ObiektPrezes obj;
            obj = new ObiektPrezes();
            string url = "http://ania.feel3d.nazwa.pl/api/prezes/read.php";
            resultat = forma.PobierzPrezesSerwer(out obj, url);

            Assert.AreEqual(resultat, true);
        }

        [TestMethod()]
        public void pobierzPrezesSerwerTest_Negatywny()
        {
            Form1 forma = new Form1(false);
            bool resultat = false;
            ObiektPrezes obj;
            obj = new ObiektPrezes();
            string url = "http://ania.feel3d.nazwa.pl/api/prezes/read222.php";
            resultat = forma.PobierzPrezesSerwer(out obj, url);

            Assert.AreEqual(resultat, false);
        }

        [TestMethod()]
        public void pobierzTrenerSerwerTest_Pozytywny()
        {
            Form1 forma = new Form1(false);
            bool resultat = false;
            ObiektTrener obj;
            obj = new ObiektTrener();
            string url = "http://ania.feel3d.nazwa.pl/api/trenerzy/read.php";
            resultat = forma.PobierzTrenerSerwer(out obj, url);

            Assert.AreEqual(resultat, true);
        }

        [TestMethod()]
        public void pobierzTrenerSerwerTest_Negatywny()
        {
            Form1 forma = new Form1(false);
            bool resultat = false;
            ObiektTrener obj;
            obj = new ObiektTrener();
            string url = "http://ania.feel3d.nazwa.pl/api/trenerzy/read333.php";
            resultat = forma.PobierzTrenerSerwer(out obj, url);

            Assert.AreEqual(resultat, false);
        }

        [TestMethod()]
        public void pobierzHalaSerwerTest_Pozytywny()
        {
            Form1 forma = new Form1(false);
            bool resultat = false;
            ObiektHala obj;
            obj = new ObiektHala();
            string url = "http://ania.feel3d.nazwa.pl/api/hala/read.php";
            resultat = forma.PobierzHalaSerwer(out obj, url);

            Assert.AreEqual(resultat, true);
        }

        [TestMethod()]
        public void pobierzHalaSerwerTest_Negatywny()
        {
            Form1 forma = new Form1(false);
            bool resultat = false;
            ObiektHala obj;
            obj = new ObiektHala();
            string url = "http://ania.feel3d.nazwa.pl/api/hala/read444.php";
            resultat = forma.PobierzHalaSerwer(out obj, url);

            Assert.AreEqual(resultat, false);
        }

        [TestMethod()]
        public void pobierzZawodnikSerwerTest_Pozytywny()
        {
            Form1 forma = new Form1(false);
            bool resultat = false;
            ObiektZawodnik obj;
            obj = new ObiektZawodnik();
            string url = "http://ania.feel3d.nazwa.pl/api/hala/read.php";
            resultat = forma.PobierzZawodnikSerwer(out obj, url);

            Assert.AreEqual(resultat, true);
        }

        [TestMethod()]
        public void pobierzZawodnikSerwerTest_Negatywny()
        {
            Form1 forma = new Form1(false);
            bool resultat = false;
            ObiektZawodnik obj;
            obj = new ObiektZawodnik();
            string url = "http://ania.feel3d.nazwa.pl/api/hala/read555.php";
            resultat = forma.PobierzZawodnikSerwer(out obj, url);

            Assert.AreEqual(resultat, false);
        }
    }
    


}