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


            var fastercar = new List<Car>();
            var slowercar = new List<Car>(); //listy uzywane do zbierania a potem wypisywania najszybszych i najwolniejszych czasow













            Console.WriteLine("Nurburgring - Nordschleife");
            Console.WriteLine("Witamy w naszej aplikacji przygotowanej pod tor wyscigowy Nurburgring");
            Console.WriteLine("1. Pokaz rekordy okrazen");
            Console.WriteLine("2. Wyswietl czasy okrazen wedlug klasy samochodu");
            Console.WriteLine("3. Symulacja okrazenia");
            Console.WriteLine("4. Porownaj okrazenie");
            
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
                    string stop5 = "0";         //stop to top(czyli czas) zapisany w stringu

                    

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
                case 3:
                    Console.WriteLine("Podaj wage samochodu");
                    double waga = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Podaj moc samochodu(KM)");
                    double moc = Convert.ToDouble(Console.ReadLine());

                    double ratio2 = waga / moc;  //najlatwiej porownac potencjal samochodu przez stosunek masy do mocy, wiec szukam najblizszego ratio z istniejacych juz samochodow i wypisuje jego czas jako najblizszy

                    double roznica = 0;

                    bool done = false;
                    
                    foreach(Car car in carlist)
                    {
                        roznica = Math.Abs(car.ratio - ratio2);
                        if (roznica <= 0.2)
                        {
                            Console.WriteLine(roznica);
                            Console.WriteLine("Twoj samochod powinien osiagnac czas okolo {0} ", car.czas2);
                            done = true;
                            break;
                        }
                        
                    }
                    
                    foreach (Car car in carlist)
                    {
                        roznica = Math.Abs(car.ratio - ratio2);
                        if (roznica <= 0.5 & roznica > 0.2 & done == false)
                        {
                            Console.WriteLine(roznica);
                            Console.WriteLine("Twoj samochod powinien osiagnac czas okolo2 {0} ", car.czas2);
                            done = true;
                            break;
                        }
                        
                    }
                    if (done)
                        break;
                    foreach (Car car in carlist)
                    {
                        roznica = Math.Abs(car.ratio - ratio2);
                        if (roznica <= 0.75 & roznica>0.5 & done == false)
                        {
                            Console.WriteLine(roznica);
                            Console.WriteLine("Twoj samochod powinien osiagnac w przyblizeniu3 {0} ", car.czas2);
                            done = true;
                            break;
                        }
                        
                    }
                    foreach (Car car in carlist)
                    {
                        roznica = Math.Abs(car.ratio - ratio2);
                        if (roznica <= 1.25 & roznica >0.75 & done == false)
                        {
                            Console.WriteLine(roznica);
                            Console.WriteLine("Twoj samochód w przyblizeniu moze osiagnac czas4 {0}", car.czas2);
                            Console.WriteLine("!!! Z powodu braku mozliwosci porownania, osiagniety czas moze sie duzo roznic od podanego");
                            done = true;
                            break;
                        }
                        
                    }

                    foreach (Car car in carlist)
                    {
                        roznica = Math.Abs(car.ratio - ratio2);

                        if (roznica > 1.25 && done == false)
                        {
                            Console.WriteLine("Niestety nie posiadamy odpowiednich danych aby moc podac przyblizony czas");
                            done = true;
                            break;
                        }

                    }
                    Console.ReadLine();
                    break;
                case 4:

                    Console.WriteLine("Podaj minute swojego okrazenia");
                    string min = Console.ReadLine();
                    Console.WriteLine("Podaj sekundy swojego okrazenia");
                    string sek = Console.ReadLine();
                    
                    string czasOkr2 = min + sek;            //2 stringi tworza jeden uzywany do wypisywania czasu w odpowiednim formacie

                    

                    int czasOkr = Convert.ToInt32(czasOkr2);  //string polaczony z dwoch przekonwertowany na int, dzieki ktoremu moge porownac czasy
                    

                    carlist.Sort((x, y) => x.czas.CompareTo(y.czas)); //sortuje liste zeby moc latwiej porownywac(tak wiem, moglem to zrobic juz w poprzednim punkcie)

                    int i = 0;

                    Console.WriteLine("Twoj czas to " + min + ":" + sek);

                    while (fastercar.Count<=3 & slowercar.Count<=3 & i<20)
                    {


                        if (czasOkr < carlist[0].czas)  //na poczatku sprawdzam czy podany czas nie jest tym najszybszym z istniejacej juz lsity, jesli tak to nie ma po co wypisywac szybszych
                        {
                            for (int j = 0; j <= 2; j++)
                            {
                                
                                slowercar.Add(carlist[(j)]);
                            }
                            Console.WriteLine("Marka | Model | Klasa | Czas");
                            foreach (Car car in slowercar)
                            {

                                Console.WriteLine(car.marka + " " + car.model + " " + car.klasa + " " + car.czas2);
                            }
                            break;
                        }

                        if(czasOkr>carlist[i].czas & czasOkr < carlist[i + 1].czas)
                        {
                            
                            for (int j=0; j <= 2; j++)
                            {
                                fastercar.Add(carlist[(i-j)]);
                                slowercar.Add(carlist[(i+1)+j]);
                            }
                            Console.WriteLine("Wolniejsze okrazenia:");
                            Console.WriteLine("Marka | Model | Klasa | Czas");
                            foreach (Car car in slowercar)
                            {

                                Console.WriteLine(car.marka + " " + car.model + " " + car.klasa + " " + car.czas2);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Szybsze okrazenia");
                            Console.WriteLine("Marka | Model | Klasa | Czas");
                            foreach (Car car in fastercar)
                            {

                                Console.WriteLine(car.marka + " " + car.model + " "+car.klasa+" "+ car.czas2);
                            }
                            break;
                        }
                        if (czasOkr > carlist[20].czas) //na koncu sprawdzam czy podany czas nie jest tym najwolniejszym
                        {
                            
                            for (int j = 0; j <= 2; j++)
                            {

                                fastercar.Add(carlist[(20-j)]);
                            }
                            foreach (Car car in fastercar)
                            {

                                Console.WriteLine(car.marka + " " + car.model + " " + car.czas2);
                            }

                            break;
                        }
                        
                        
                        i++;
                    }

                    

                    Console.ReadLine();
                    
                    
                    

















                    break;





                    

            }
            Console.ReadLine();
        }
    }
}
