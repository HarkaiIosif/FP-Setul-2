using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FP_Setul_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool daca = true;
            while (daca)
            {
                Console.WriteLine("Introduceti problema pe care doriti sa o rezolvati");
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    S1();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 2)
                {
                    S2();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 3)
                {
                    S3();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 4)
                {
                    S4();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 5)
                {
                    S5();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 6)
                {
                    S6();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 7)
                {
                    S7();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 8)
                {
                    S8();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 9)
                {
                    S9();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 10)
                {
                    S10();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 11)
                {
                    S11();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 12)
                {
                    S12();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 13)
                {
                    S13();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 14)
                {
                    S14();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 15)
                {
                    S15();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 16)
                {
                    S16();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }
                if (s == 17)
                {
                    S17();
                    Console.WriteLine("Doriti sa mai rezolvati o problema ? Pentru da introduceti 1 , pentru nu introduceti 0");
                    int l = int.Parse(Console.ReadLine());
                    if (l == 0) daca = false;

                }

            }
        }
        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
        /// </summary>
        private static void S1()
        {
            Console.WriteLine("Introduceti numarul n , iar apoi cele n numere ale seriei");
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0) nr++;
            }
            Console.WriteLine($"Numarul de numere pare din secventa este {nr}");
            Console.ReadKey();
        }
        /// <summary>
        /// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        /// </summary>
        private static void S2()
        {
            Console.WriteLine("Introduceti numarul n , iar apoi cele n numere ale seriei");
            int n = int.Parse(Console.ReadLine());
            int nrp = 0, nr0 = 0, nrn = 0;
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a > 0) nrp++;
                else if (a == 0) nr0++;
                else nrn++;
            }
            Console.WriteLine($"Numarul de numere negative este {nrn}, de numere pozitive {nrp} iar de numere egale cu zero {nr0}");
            Console.ReadKey();
        }
        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n. 
        /// </summary>
        private static void S3()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int S = 0, P = 1;
            for (int i = 1; i <= n; i++)
            {
                S = S + i;
                P = P * i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n} este {S} iar produsul lor este {P}");
            Console.ReadKey();
        }
        /// <summary>
        /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
        /// </summary>
        private static void S4()
        {
            Console.WriteLine("Introduceti secventa n ,numarul a si cele n numere ale secventei ");
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int p = -1;
            for (int i = 0; i <= n - 1; i++)
            {
                int k = int.Parse(Console.ReadLine());
                if (k == a) p = i;
            }
            Console.WriteLine($"Elementul {a} se afla pe pozitia {p}");
            Console.ReadKey();
        }
        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0
        /// </summary>
        private static void S5()
        {
            Console.WriteLine("Introduceti numarul n si cele n elemente ale seriei");
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                int k = int.Parse(Console.ReadLine());
                if (k == i) nr++;
            }
            Console.WriteLine($"{nr} elemente ale seriei sunt egale cu pozitia pe care o ocupa in serie");
            Console.ReadKey();
        }
        /// <summary>
        /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        /// </summary>
        private static void S6()
        {
            Console.WriteLine("Introduceti numarul n si cele n elemente ale seriei");
            int n = int.Parse(Console.ReadLine());
            bool da = true;
            int b = -999999999;
            for (int i = 0; i <= n - 1; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (b > a) da = false;
                b = a;
            }
            if (da) Console.WriteLine("Elementele seriei sunt in ordine crescatoare");
            else Console.WriteLine("Elementele seriei nu sunt in ordine crescatoare");
            Console.ReadKey();
        }
        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
        /// </summary>
        private static void S7()
        {
            Console.WriteLine("Introduceti numarul n si cele n elemente ale seriei");
            int n = int.Parse(Console.ReadLine());
            int max = -999999999, min = 999999999;
            for (int i = 0; i <= n - 1; i++)
            {
                int a = int.Parse(Console.ReadLine());


                if (a > max) max = a;
                if (a < min) min = a;

            }
            Console.WriteLine($"Maximul seriei este {max} iar minimul seriei este {min}");
            Console.ReadKey();
        }
        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </summary>
        private static void S8()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int fn, f1 = 0, f2 = 1;
            for (int i = 3; i <= n ; i++)
            {
                fn = f1 + f2;
                f1 = f2;
                f2 = fn;
            }
            Console.WriteLine($"Termenul {n} al sirului lui Fibonacci este {f2}");
            Console.ReadKey();
        }
        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
        /// </summary>
        private static void S9()
        {
            Console.WriteLine("Introduceti numarul n si cele n elemente ale seriei");
            int n = int.Parse(Console.ReadLine());
            bool crescatoare = true, descrescatoare = true;
            int b = -999999999;
            int c = 999999999;
            for (int i = 0; i <= n - 1; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (b > a) crescatoare = false;
                b = a;
                if (c < a) descrescatoare = false;
                c = a;
            }
            if (crescatoare || descrescatoare) Console.WriteLine("Seria este monotona");
            else Console.WriteLine("Serie nu este monotona");
            Console.ReadKey();
        }
        /// <summary>
        /// Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
        /// </summary>
        private static void S10()
        {
            Console.WriteLine("Introduceti numarul n si cele n elemente ale seriei");
            int n = int.Parse(Console.ReadLine());
            int b = 0, nr = 0;
            for (int i = 1; i <= n ; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i == 1) b = a;
                if (a == b) nr++;
                else
                {
                    b = a;
                    nr = 1;
                }
            }
            Console.WriteLine($"Numarul maxim de elemente egale consecutive ale sirului este {nr}");
            Console.ReadKey();
        }
        /// <summary>
        /// Se da o secventa de n numere.Se cere sa se caculeze suma inverselor acestor numere.
        /// </summary>
        private static void S11()
        {
            Console.WriteLine("Introduceti numarul n si cele n elemente ale seriei");
            int n = int.Parse(Console.ReadLine());
            double S = 0;
            for (int i = 1; i <= n ; i++)
            {
                double a = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Unul dintre elemente este 0,programul va afisa suma pana la valoarea 0");
                    break;
                }
                S = S + 1 / a;
            }
            S = S * 100;
            S = Math.Truncate(S);
            S = S / 100;
            Console.WriteLine($"Suma inverselor este {S}");
            Console.ReadKey();
        }
        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
        /// Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
        /// De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
        /// </summary>
        private static void S12()
        {
            Console.WriteLine("Introduceti numarul n si cele n elemente ale seriei");
            int n = int.Parse(Console.ReadLine());
            int nr = 0, b=0;
            bool consecutiv = true;
            for (int i = 1; i <= n - 1; i++)
            { 
                int a = int.Parse(Console.ReadLine());
                if (b == 0) b = a;
                if (a != 0) if (a == b + 1) consecutiv = true;
                    else consecutiv = false;
                else { if (consecutiv) nr++;
                    b = 0;
                }
                  
            }
            Console.WriteLine($"Numarul maxim de grupuri de numere consecutive este {nr}");
            Console.ReadKey();
        }
        /// <summary>
        /// O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive 
        /// (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). 
        /// Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
        /// </summary>
        private static void S13()
        {
            Console.WriteLine("Introduceti numarul n urmat de cele n elemnte ale seriei");
            int n = int.Parse(Console.ReadLine());
            int b = 0, c = 0;
            bool crescatoarerotita = true;
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i >= 3)

                    if ((b > c && b < a && c < a) || (b < c && b < a && c > a)) crescatoarerotita = false;
                
                b = c;
                c = a;


            }
            if (crescatoarerotita) Console.WriteLine("Seria este crescatoare rotita");
            else Console.WriteLine("Seria nu este crescatoare rotita");
        }
        /// <summary>
        /// O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. 
        /// Determinati daca o secventa de n numere este o secventa monotona rotita. 
        /// </summary>
        private static void S14()
        {
            Console.WriteLine("Introduceti numarul n urmat de cele n elemnte ale seriei");
            int n = int.Parse(Console.ReadLine());
            int b = 0, c = 0;
            bool crescatoarerotita = true;
            bool descrescatoarerotita = true;
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i >= 3)

                    if ((b > c && b < a && c < a) || (b < c && b < a && c > a)) crescatoarerotita = false;
                if ((b < c && c > a && b > a) || (b > c && c < a && b > a)) descrescatoarerotita = false;
                b = c;
                c = a;


            }
            if (crescatoarerotita||descrescatoarerotita) Console.WriteLine("Seria este monotona rotita");
            else Console.WriteLine("Seria nu este monotona rotita");
            
        }
        /// <summary>
        /// O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. 
        /// De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. 
        /// Sa se determine daca este bitonica. 
        /// </summary>
        private static void S15()
        {
            Console.WriteLine("Introduceti numarul n si cele n numere ale seriei");
            int n = int.Parse(Console.ReadLine());
            int b = -999999999, max = 0;
            bool descrescatoare = false, bitonica = true;
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (b > a)
                {

                    descrescatoare = true;
                    max = b;
                }
                if (descrescatoare)
                {
                    if (a > max || b < a)
                    {
                        descrescatoare = false;
                        bitonica = false;
                    }

                }
                b = a;

            }
            if (bitonica) Console.WriteLine("Seria este bitonica");
            else Console.WriteLine("Seria nu este bitonica");
        }
        /// <summary>
        /// O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive 
        /// (rotire = primul element devine ultimul). 
        /// Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
        /// </summary>
        private static void S16()
        {
            Console.WriteLine("Introduceti numarul n si cele n numere ale seriei");
            int n=int.Parse(Console.ReadLine());
            int b = 0, max = 0, contor = 0;
            bool bitonicarotita = true, descrescatoare = false;
            for(int i = 1; i <= n; i++) { int a = int.Parse(Console.ReadLine());
                if (i == 1) contor = a;
                if (b > a)
                {

                    descrescatoare = true;
                    max = b;
                }
                if (descrescatoare)
                {
                    if (a > max || b < a)
                    {
                        if (contor < a) bitonicarotita = true;
                        else
                        {
                            descrescatoare = false;
                            bitonicarotita = false;
                        }
                    }

                }
                b = a;
            }
            if (bitonicarotita) Console.WriteLine("Seria este bitonica rotita");
            else Console.WriteLine("Seria nu este bitonica rotita");

        }
        /// <summary>
        /// Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. 
        /// Determinati daca secventa reprezinta o secventa de paranteze corecta si,daca este,determinati nivelul maxim de incuibare a parantezelor. 
        /// De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 
        /// </summary>
        private static void S17()
        {
            Console.WriteLine("Introduceti seria de paranteze");
            string t = Console.ReadLine();
            int n,nrt0=0,nrt1=0,nrd0=0,nru0=0,gr=0;
            bool corect = true;
            foreach(char c in t)
            {
                n = Convert.ToInt32(c);
                switch (n) { case 48: { nrt0++;
                            nrd0++;
                            nru0++;
                        } break;
                    case 49: { if(nru0>gr) gr = nru0;
                            nru0 = 0;
                            if (nrd0 > 0) { nrt1++;
                                nrd0--;
                            }
                            else corect = false;
                        } break;
                }
            }
            if (corect && (nrt1 == nrt0)&&nrd0==0) Console.WriteLine($"Seria este corecta iar gradul maxim da incuibire este {gr}");
            else Console.WriteLine("Seria nu este corecta");
        }
    }
}