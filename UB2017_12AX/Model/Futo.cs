namespace UB2017_12AX.Model
{
    internal class Futo
    {
        private string _nev;
        private int _rajtSzam;
        private string _kategoria;
        private string _idoEredmeny;
        private int _teljSzazalek;

        public Futo()
        {
        }

        public Futo(string nev, int rajtSzam, string kategoria, string idoEredmeny, int teljSzazalek)
        {
            Nev = nev;
            RajtSzam = rajtSzam;
            Kategoria = kategoria;
            IdoEredmeny = idoEredmeny;
            TeljSzazalek = teljSzazalek;
        }

        public string Nev { get => _nev; set => _nev = value; }
        public int RajtSzam { get => _rajtSzam; set => _rajtSzam = value; }
        public string Kategoria { get => _kategoria; set => _kategoria = value; }
        public string IdoEredmeny { get => _idoEredmeny; set => _idoEredmeny = value; }
        public int TeljSzazalek { get => _teljSzazalek; set => _teljSzazalek = value; }

        public double IdoOraban
        {
            //6. feladat. Készíts egy jellemzőt/property-t
            get
            {
                string[] idoDarabok = IdoEredmeny.Split(':');
                int ora = int.Parse(idoDarabok[0]);
                int perc = int.Parse(idoDarabok[1]);
                int mp = int.Parse(idoDarabok[2]);

                return ora + perc / 60.0 + mp / 3600.0;
            }
        }

        public override string ToString()
        {
            return $"Név: {Nev} (kat:{Kategoria}), rajszám: {RajtSzam}, idő: {IdoEredmeny}, teljesítés százaléka: {TeljSzazalek}";
        }
    }
}
