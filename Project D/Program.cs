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

            var carlist = new List<Car>()
            {


                new Car(1, "BMW", "M3", 'B', 835,"8:35", 5.1),
                new Car(2, "BMW", "M4", 'A', 801,"8:01", 3.9),
                new Car(3, "BMW", "M2", 'A', 810,"8:10", 4.2),
                new Car(4, "Peugeot", "406", 'D', 937,"9:37", 7.6),
                new Car(5, "VW", "Golf", 'C', 859,"8:59", 6.6),
                new Car(6, "VW", "Corrado", 'D', 931,"9:31", 7.1),
                new Car(7, "Mazda", "RX-7", 'B', 840,"8:40", 5.8),
                new Car(8, "Mazda", "RX-8", 'C', 850,"8:50", 6.4),
                new Car(9, "Toyota", "Supra", 'B', 837,"8:37", 5.3),
                new Car(10, "Nissan", "Skyline", 'B', 836,"8:36", 5.2),
                new Car(11, "Porsche", "911 GT3", 'S', 748,"7:48", 3.1),
                new Car(12, "Nissan", "GT-R Nismo", 'S', 708,"7:08", 3.1),
                new Car(13, "Ferrari", "488 GTB", 'S', 721,"7:21", 2.5),
                new Car(14, "Saab", "9-3 Aero", 'B', 835,"8:35", 5.1),
                new Car(15, "Ford", "Focus ST", 'B', 820,"8:20", 5.7),
                new Car(16, "Mazda", "MX-5", 'D', 940,"9:40", 7.8),
                new Car(17, "Honda", "Civic Type-R", 'C', 855,"8:55", 6.5),
                new Car(18, "Audi", "TT", 'D', 955,"9:55", 8.3),
                new Car(19, "Audi", "RS7", 'A', 757,"7:57", 3.7),
                new Car(20, "Peugeot", "205 GTI", 'D', 933,"9:33", 7.5),
                new Car(21, "BMW", "330i", 'C', 850,"8:50", 6.8)
        };


            











            Console.WriteLine("Nurburgring - Nordschleife");
            Console.WriteLine("Witamy w naszej aplikacji przygotowanej pod tor wyscigowy Nurburgring");
            Console.WriteLine("1. Pokaz rekordy okrazen");
            Console.WriteLine("2. Wyswietl czasy okrazen wedlug klasy samochodu");
            Console.WriteLine("3. Symulacja okrazenia");
            Console.WriteLine("4. Porownaj okrazenie");
            Console.WriteLine(carlist[0].ID);
            int opcja = Convert.ToInt32(Console.ReadLine());


            switch (opcja)
            {
                case 1:
                    Console.WriteLine("5 najszybszych okrazen");
                    double top1 = carlist[0].czas;
                    double top2 = carlist[1].czas;
                    double top3 = carlist[2].czas;
                    double top4 = carlist[3].czas;
                    double top5 = carlist[4].czas;


                    string marka1 = "0";
                    string marka2 = "0";
                    string marka3 = "0";
                    string marka4 = "0";
                    string marka5 = "0";

                    string model1 = "0";
                    string model2 = "0";
                    string model3 = "0";
                    string model4 = "0";
                    string model5 = "0";


                    string stop1 = "0";
                    string stop2 = "0";
                    string stop3 = "0";
                    string stop4 = "0";
                    string stop5 = "0";

                    

                    foreach (Car car in carlist)
                    {
                       

                        if (top1 > car.czas)
                        {
                            top1 = car.czas;
                            stop1 = car.czas2;
                            marka1 = car.marka;
                            model1 = car.model;

                        }
                        else if(car.czas > top1 && car.czas < top2){
                            top2 = car.czas;
                            stop2 = car.czas2;
                            marka2 = car.marka;
                            model2 = car.model;
                        }
                        else if(car.czas > top2 && car.czas < top3){
                            top3 = car.czas;
                            stop3 = car.czas2;
                            marka3 = car.marka;
                            model3 = car.model;
                        }
                        else if(car.czas > top3 && car.czas < top4){
                            top4 = car.czas;
                            stop4 = car.czas2;
                            marka4 = car.marka;
                            model4 = car.model;

                        }
                        else if(car.czas > top4 && car.czas < top5){
                            top5 = car.czas;
                            stop5 = car.czas2;
                            marka5 = car.marka;
                            model5 = car.model;
                        }
                        




                    }

                    
                    



                    Console.WriteLine("Model | Marka | Czas");
                    Console.WriteLine(model1+" | "+marka1+" | "+stop1);
                    Console.WriteLine(model2 + " | " + marka2 + " | " + stop2);
                    Console.WriteLine(model3 + " | " + marka3 + " | " + stop3);
                    Console.WriteLine(model4 + " | " + marka4 + " | " + stop4);
                    Console.WriteLine(model5 + " | " + marka5 + " | " + stop5);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Wyswietl czasy okrazen wedlug klasy samochodu");
                    Console.WriteLine("Podaj klase (S,A,B,C,D)");
                    
                    var klasa = 'S';
                    klasa = Convert.ToChar(Console.Read()) ;
                    switch (klasa)
                    {
                       
                        case 'S':
                            Console.WriteLine("Marka | Model | Waga/Moc | Czas");
                            Console.WriteLine(" ");
                            foreach (Car car in carlist)
                            {
                                if (car.klasa == 'S')
                                {
                                    Console.WriteLine(car.marka + " | " + car.model + " | " + car.ratio + " | " + car.czas);
                                }
                            }

                            Console.ReadLine();
                            break;

                        case 'A':

                            Console.WriteLine("Marka | Model | Waga/Moc | Czas");
                            Console.WriteLine(" ");
                            foreach (Car car in carlist)
                            {
                                if (car.klasa == 'A')
                                {
                                    Console.WriteLine(car.marka + " | " + car.model + " | " + car.ratio + " | " + car.czas);
                                }
                            }
                            Console.ReadLine();
                            break;
                        case 'B':

                            Console.WriteLine("Marka | Model | Waga/Moc | Czas");
                            Console.WriteLine(" ");
                            foreach (Car car in carlist)
                            {
                                if (car.klasa == 'B')
                                {
                                    Console.WriteLine(car.marka + " | " + car.model + " | " + car.ratio + " | " + car.czas);
                                }
                            }
                            Console.ReadLine();
                            break;
                        case 'C':

                            Console.WriteLine("Marka | Model | Waga/Moc | Czas");
                            Console.WriteLine(" ");
                            foreach (Car car in carlist)
                            {
                                if (car.klasa == 'C')
                                {
                                    Console.WriteLine(car.marka + " | " + car.model + " | " + car.ratio + " | " + car.czas);
                                }
                            }
                            Console.ReadLine();
                            break;
                        case 'D':
                            
                            Console.WriteLine("Marka | Model | Waga/Moc | Czas");
                            Console.WriteLine(" ");
                            foreach (Car car in carlist)
                            {
                                if (car.klasa == 'D')
                                {
                                    Console.WriteLine(car.marka +" | "+car.model+" | "+car.ratio+" | "+car.czas);
                                }
                            }
                            Console.ReadLine();
                            break;
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
