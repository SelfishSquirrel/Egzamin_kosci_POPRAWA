using System;
using System.Collections.Generic;

namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        Dictionary<int, string> images = new Dictionary<int, string>()
        {
            { 1,  "k1.jpg" },
            { 2,  "k2.jpg" },
            { 3,  "k3.jpg" },
            { 4,  "k4.jpg" },
            { 5,  "k5.jpg" },
            { 6,  "k6.jpg" },
        };

        List<int> WylosowaneLiczby = new List<int>();

        int sumaOczek = 0;
        int sumaGry = 0;
        
        public MainPage()
        {
            InitializeComponent();

            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           WylosowaneLiczby.Clear();

           Random random = new Random(); 

            for(int i = 0; i < 5; i++)
            {
                int liczba = random.Next(1, 7);
                WylosowaneLiczby.Add(liczba);
            }

            DisplayLiczby();
            sumaOczek = SumaOczek(WylosowaneLiczby);
            sumaGry += sumaOczek;
            WynikLosowania.Text = $"Wynik tego losowania: {sumaOczek.ToString()}";
            WynikGry.Text = $"Wynik gry: {sumaGry.ToString()}";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Obraz1.Source = "question.jpg";
            Obraz2.Source = "question.jpg";
            Obraz3.Source = "question.jpg";
            Obraz4.Source = "question.jpg";
            Obraz5.Source = "question.jpg";

            WynikLosowania.Text = $"Wynik tego losowania: 0";
            WynikGry.Text = $"Wynik gry: 0";
        }

        public void DisplayLiczby()
        {
            for(int i = 0; i < WylosowaneLiczby.Count;i++)
            {
                string path = images[WylosowaneLiczby[i]];

                if(i == 0)
                {
                    Obraz1.Source = path;
                }
                else if(i == 1)
                {
                    Obraz2.Source = path;
                }
                else if(i == 2)
                {
                    Obraz3.Source = path;
                }
                else if( i == 3)
                {
                    Obraz4.Source = path;
                }
                else if(i == 4)
                {
                    Obraz5.Source = path;
                }
            }

        }

        public int SumaOczek(List<int> Oczke)
        {
            int suma = 0;

            for (int i = 0; i < Oczke.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < Oczke.Count; j++)
                {
                    if (Oczke[i] == Oczke[j])
                    {
                        count++;
                    }
                }


                if (count > 1)
                {
                    suma += Oczke[i];
                }
            }

            return suma;
        }
    }
}
