using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Project_D
{
    class Car
    {
        public int ID;
        public string Marka;
        public string Model;
        public char Klasa;
        public string Czas;

        public Car(int ID, string marka, string model, char klasa, string czas)
        {
            
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nurburgring - Nordschleife");
            Console.WriteLine("Witamy w naszej aplikacji przygotowanej pod tor wyscigowy Nurburgring");
            Console.WriteLine("1. Pokaz rekordy okrazen");
            Console.WriteLine("2. Wyswietl czasy okrazen wedlug klasy samochodu");
            Console.WriteLine("3. Symulacja okrazenia");
            Console.WriteLine("4. Porownaj okrazenie");
            var opcja=1;
            switch (opcja)
            {
                case 0:
                    Console.WriteLine("Pokaz rekordy okrazen");
                    break;
                case 1:
                    Console.WriteLine("Wyswietl czasy okrazen wedlug klasy samochodu");
                    
                    var klasa = 'A';
                    klasa = Convert.ToChar(Console.Read()) ;
                    switch (klasa)
                    {
                       
                        case 'S':
                            Console.WriteLine("test");
                            Console.ReadLine();
                            break;

                        case 'A':
                            Console.WriteLine("test");
                            Console.ReadLine();
                            break;
                        case 'B':
                            Console.WriteLine("test");
                            Console.ReadLine();
                            break;
                        case 'C':
                            Console.WriteLine("test");
                            Console.ReadLine();
                            break;
                        case 'D':
                            
                            Console.WriteLine("test");
                            Console.ReadLine();
                            break;
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
