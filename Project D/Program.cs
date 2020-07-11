using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Project_D
{
    
    class Program
    {
        static void Main(string[] args)
        {

            
                Car c1 = new Car(1, "BMW", "M3", 'B', "8:35", 5.1);
                Car c2 = new Car(2, "BMW", "M4", 'A', "8:01", 3.9);
                Car c3 = new Car(3, "BMW", "M2", 'A', "8:10", 4.2);
                Car c4 = new Car(4, "Peugeot", "406", 'D', "9:37", 7.6);
                Car c5 = new Car(5, "VW", "Golf", 'C', "8:59", 6.6);
                Car c6 = new Car(6, "VW", "Corrado", 'D', "9:31", 7.1);
                Car c7 = new Car(7, "Mazda", "RX-7", 'B', "8:40", 5.8);
                Car c8 = new Car(8, "Mazda", "RX-8", 'C', "8:50", 6.4);
                Car c9 = new Car(9, "Toyota", "Supra", 'B', "8:37", 5.3);
                Car c10 = new Car(10, "Nissan", "Skyline", 'B', "8:36", 5.2);
                Car c11 = new Car(11, "Porsche", "911 GT3", 'S', "7:48", 3.1);
                Car c12 = new Car(12, "Nissan", "GT-R Nismo", 'S', "7:08", 3.1);
                Car c13 = new Car(13, "Ferrari", "488 GTB", 'S', "7:21", 2.5);
                Car c14 = new Car(14, "Saab", "9-3 Aero", 'B', "8:35", 5.1);
                Car c15 = new Car(15, "Ford", "Focus ST", 'B', "8:20", 5.7);
                Car c16 = new Car(16, "Mazda", "MX-5", 'D', "9:40", 7.8);
                Car c17 = new Car(17, "Honda", "Civic Type-R", 'C', "8:55", 6.5);
                Car c18 = new Car(18, "Audi", "TT", 'D', "9:55", 8.3);
                Car c19 = new Car(19, "Audi", "RS7", 'A', "7:57", 3.7);
                Car c20 = new Car(20, "Peugeot", "205 GTI", 'D', "9:33", 7.5);
                Car c21 = new Car(21, "BMW", "330i", 'C', "8:50", 6.8);

            












            Console.WriteLine("Nurburgring - Nordschleife");
            Console.WriteLine("Witamy w naszej aplikacji przygotowanej pod tor wyscigowy Nurburgring");
            Console.WriteLine("1. Pokaz rekordy okrazen");
            Console.WriteLine("2. Wyswietl czasy okrazen wedlug klasy samochodu");
            Console.WriteLine("3. Symulacja okrazenia");
            Console.WriteLine("4. Porownaj okrazenie");
            Console.WriteLine(c1.ID);
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
