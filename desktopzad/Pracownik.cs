using System;
using System.Text;

namespace DodajPracownika
{
    public class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Stanowisko { get; set; }
        public string Haslo { get; set; }

        private static readonly string maleLitery = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string wielkieLitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string cyfry = "0123456789";
        private static readonly string znakiSpecjalne = "!@#$%^&*()_+-=";

        public string GenerujHaslo(int dlugosc, bool czyLitery, bool czyCyfry, bool czyZnakiSpecjalne)
        {
            StringBuilder zbior = new StringBuilder();
            string haslo = "";

            if (czyLitery) zbior.Append(maleLitery + wielkieLitery);
            else zbior.Append(maleLitery);

            Random rnd = new Random();

            if (dlugosc >= 1 && czyCyfry)
                haslo += cyfry[rnd.Next(cyfry.Length)];

            if (dlugosc >= 2 && czyZnakiSpecjalne)
                haslo += znakiSpecjalne[rnd.Next(znakiSpecjalne.Length)];

            for (int i = haslo.Length; i < dlugosc; i++)
                haslo += zbior[rnd.Next(zbior.Length)];

            Haslo = new string(haslo.ToCharArray());
            return Haslo;
        }

        public override string ToString()
        {
            return $"Dane pracownika: {Imie} {Nazwisko} {Stanowisko} Hasło: {Haslo}";
        }
    }
}
