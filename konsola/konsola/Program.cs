using System;
using System.Collections.Generic;


namespace Program
{
    public class MainProgram
    {
        public static void Main(string[] argc)
        {
            Console.WriteLine("Ile kostek chcesz rzucic?(3-10)"); 
            int numberFromRange  = int.Parse(Console.ReadLine());
            while (numberFromRange < 3 || numberFromRange > 10)
            {
                Console.WriteLine("Ile kostek chcesz rzucic?(3-10)");
                numberFromRange = int.Parse(Console.ReadLine());
            }

            List<int> wylosowaneOczke = new List<int>();

            for(int i = 1; i <= numberFromRange; i++)
            {
                Kostka kostka = new Kostka();
                kostka.WylosujLiczbeOczek();
                Console.WriteLine($"Kostka:{i}: {kostka.liczbaOczek}");
                wylosowaneOczke.Add(kostka.liczbaOczek);
            }

            Console.WriteLine($"Liczba uszyskanych punktow {SumaOczek(wylosowaneOczke)}");

            Console.WriteLine("Jeszcze raz? (t/n)");
            char odpowiedz = char.Parse(Console.ReadLine());
            while (true)
            {
                if (odpowiedz == 't')
                {
                    wylosowaneOczke.Clear();

                    for (int i = 1; i <= numberFromRange; i++)
                    {
                        Kostka kostka = new Kostka();
                        kostka.WylosujLiczbeOczek();
                        Console.WriteLine($"Kostka:{i}: {kostka.liczbaOczek}");
                        wylosowaneOczke.Add(kostka.liczbaOczek);
                    }
                    Console.WriteLine($"Liczba uszyskanych punktow {SumaOczek(wylosowaneOczke)}");

                    Console.WriteLine("Jeszcze raz? (t/n)");
                    odpowiedz = char.Parse(Console.ReadLine());

                }
                else if (odpowiedz == 'n')
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Niepoprawna odpowiedz");
                }
            }
        }

        public static int SumaOczek(List<int> Oczke)
        {
            int suma = 0;

            for(int i = 0; i < Oczke.Count; i++)
            {
                int count = 0;
                for(int j = 0; j < Oczke.Count;j++)
                {
                    if (Oczke[i] == Oczke[j])
                    {
                        count++;
                    }
                }


                if(count > 1)
                {
                    suma += Oczke[i];
                }
            }

            return suma;
        }
    };

    public class Kostka
    {
        public int liczbaOczek = 0;

        public void WylosujLiczbeOczek()
        {
            Random rand = new Random();
            liczbaOczek = rand.Next(1, 7);
        }
    }

}
