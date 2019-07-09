using System;

namespace ModelGry
{
    
    // inner class
    public class Ruch
        {
            public enum Odp { ZaMalo = -1, Trafiono = 0, ZaDuzo = +1 };
            public readonly int Propozycja;
            public readonly Odp Odpowiedz;
            public readonly DateTime Kiedy;

            public Ruch(int prop, Odp odp)
            {
                Propozycja = prop;
                Odpowiedz = odp;
                Kiedy = DateTime.Now;
            }

            public override string ToString()
                => $"({Propozycja}, {Odpowiedz}, {Kiedy})";

        } // koniec wewnętrznej klasy Ruch
}
