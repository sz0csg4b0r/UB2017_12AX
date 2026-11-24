using UB2017_12AX.Model;

namespace UB2017_12AX
{
    internal class Program
    {
        public static List<Futo> futok = new List<Futo>();
        public static List<string[]> adatok = new List<string[]>();

        static void Main(string[] args)
        {
            Adatbetoltes();
            ObjFactory(adatok);
            Feladat03(futok);
            Feladat04(futok);
            Feladat05(futok);
            Feladat07(futok);
            Feladat08(futok);

        }

        private static void Feladat08(List<Futo> futok)
        {
            Futo noi = new Futo();
            Futo ferfi = new Futo();

            foreach (Futo futo in futok)
            {
                if (futo.Kategoria=="Noi" && futo.TeljSzazalek==100)
                {
                    if(noi.Nev == null || noi.IdoOraban > futo.IdoOraban)
                    {
                        noi = futo;
                    }
                }
            }
            //TODO: innen folytatjuk 2026.11.24 


        }

        private static void Feladat07(List<Futo> futok)
        {
            int ffiCounter = 0;
            double osszIdo = 0;
            foreach (Futo futo in futok)
            {
                if(futo.Kategoria == "Ferfi" && futo.TeljSzazalek == 100)
                {
                    ffiCounter++;
                    osszIdo += futo.IdoOraban;
                }
            }

            Console.WriteLine($"7. feladat: A teljesítő férfiak átlag ideje órában {osszIdo/ffiCounter:F2}");
        }

        private static void Teszt(List<Futo> futok)
        {
            Futo elso = futok[0];
            Console.WriteLine(elso.IdoOraban);

        }

        private static void Feladat05(List<Futo> futok)
        {
            Console.Write("5. feladat: ");
            Console.Write("Kérem a sportoló nevét: ");
            string futoNeve = Console.ReadLine();

            bool indultE = false;
            bool teljesitetteE = false;
            foreach (Futo futo in futok)
            {
                if (futo.Nev == futoNeve)
                {
                    indultE = true;
                    if (futo.TeljSzazalek == 100)
                    {
                        teljesitetteE= true;
                    }
                    break;
                }
            }
            
            Console.WriteLine($"Indult-e a versenyző: {(indultE ? "Igen" : "Nem")}"  );
            if (indultE) { 
            Console.WriteLine($"Teljesített-e a távot: {(teljesitetteE ? "Igen" : "Nem")}");
            }




        }

        private static void Feladat04(List<Futo> futok)
        {
            int womenCounter = 0;
            foreach (Futo futo in futok)
            {
                if (futo.Kategoria == "Noi" && futo.TeljSzazalek == 100)
                {
                    womenCounter++;
                }
            }
            Console.WriteLine($"4. feladat: A női futók száma akik teljesítették a teljes távot: {womenCounter}");
        }

        private static void Feladat03(List<Futo> futok)
        {
            Console.WriteLine($"3. feladat: Egyéni indulók {futok.Count}");
        }

        private static void ObjFactory(List<string[]> adatok)
        {
            foreach (string[] adatsor in adatok)
            {
                // Ha van üres konstr.
                //Futo segedObj = new Futo();
                //segedObj.Nev = adatsor[0];
                //segedObj.RajtSzam = Convert.ToInt32(adatsor[1]);
                //segedObj.Kategoria = adatsor[2];
                //segedObj.IdoEredmeny = adatsor[3];
                //segedObj.TeljSzazalek = Convert.ToInt32(adatsor[4]);
                // Paraméteres konstruktorral: 

                Futo segedObj2 = new Futo(adatsor[0], Convert.ToInt32(adatsor[1]), adatsor[2], adatsor[3], Convert.ToInt32(adatsor[4]));
                futok.Add(segedObj2);
            }
        }

        private static void Adatbetoltes()
        {
            adatok = FileIO2627.ReadFromFile.FileRead(@"data/ub2017egyeni.txt", 5, ';', 1);
        }
    }
}
