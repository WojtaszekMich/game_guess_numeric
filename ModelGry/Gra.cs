using System;
using System.Collections.Generic;
using System.Diagnostics;
using static ModelGry.Ruch;

namespace ModelGry
{
    public partial class Gra
    {
        // typy
        public enum StanGry { Trwa, Poddana, Odgadnieta };

        // pola
        private readonly int wylosowana;
        public readonly int ZakresOd, ZakresDo;
        public StanGry Stan { get; private set; }
        public int LicznikRuchow { get; private set; }  = 0;
        private bool AllowCheat = true;
        private int CheatNumber;
        //ToDo: historia rozgrywki

        public Gra(int min, int max)
        {
            ZakresOd = min;
            ZakresDo = max;
            wylosowana = Losuj(ZakresOd, ZakresDo);
            Stan = StanGry.Trwa;
            Historia = new List<Ruch>();
            CheatNumber = new Random().Next(0,10);
        }

        private int Losuj(int min = 1, int max = 100)
        {
            Random generator = new Random();
            int los = generator.Next(min, max + 1);
            return los;
        }

        public Odp Ocena(int propozycja)
        {
            LicznikRuchow++;
            Odp odp;
            if (propozycja < wylosowana)
                odp = Odp.ZaMalo;
            else if (propozycja > wylosowana)
                odp = Odp.ZaDuzo;
            else // ==
            {
                Stan = StanGry.Odgadnieta;
                odp = Odp.Trafiono;
            }

            var random = new Random().Next(0, 10);
            if (AllowCheat && random == CheatNumber)
            {
                odp = Cheat(odp);
            }

            Historia.Add(new Ruch(propozycja, odp));
            return odp;
        }

        public Odp Cheat(Odp odp)
        {
            AllowCheat = false;
            if (odp == Odp.ZaDuzo)
            {
                return Odp.ZaMalo;
            }
            else if (odp == Odp.ZaMalo)
            {
                return Odp.ZaDuzo;
            }
            else
            {
                return Odp.ZaDuzo;
            }
        }

        public void Poddaj()
        {
            Stan = StanGry.Poddana;
        }

        public int CoByloWylosowane()
        {
             return wylosowana;
        }
    }
}
