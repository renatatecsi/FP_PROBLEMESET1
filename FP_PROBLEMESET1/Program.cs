using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Intrinsics.Arm;


namespace ProblemeSetul1
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            //P17();
            //P18();
            //P19();
            //P20();

        }

        private static void P20()
        {
            // afisati fractia m/n in format zecimal

            int m, n;
            double d;
            Console.WriteLine("Introduceti doua numere:");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            d = (double)m / n;

            //separam paretea intrega de partea fractionara
            double intreg = Math.Truncate(d);
            double frac = Math.Truncate(d * 10);
            // 13/40 = 0.4333...
            // daca d * 10 = 4 si d * 10 * 10 = 43 atunci d * 10 * 10 % 10 = 3
            double frac2 = Math.Truncate(d * 10 * 10 % 10);

            if (m % n == 0) // fractie neperiodica
                Console.WriteLine($"{d}. {m} este divizibil cu {n}.");
            else if ((n % 2 == 1) || (n % 5 == 1)) // fractie periodica simpla
                Console.WriteLine($"{intreg}.({frac}). Fractia este periodica simpla.");
            else if ((n != 2) && (n != 5)) // fractie mixta
                Console.WriteLine($"{intreg}.{frac}({frac2}). Fractia este periodica mixta.");
            else
                Console.WriteLine($"{d}. Fractia este neperiodica.");
        }

        private static void P19()
        {
            // det daca e un nr format din 2 cifre care se pot repeta

            Console.WriteLine("Introduceti un numar pozitiv de mai multe cifre:");
            string n = Console.ReadLine(); //folosim nr ca string
            string rezultat = string.Empty;

            for (int i = 0; i < n.Length; i++) // verifica duplicatele
            {
                if (!rezultat.Contains(n[i])) // indeparteaza duplicatele
                    rezultat += n[i];
            }

            // ne da nr de cifre ramase dupa indepartarea duplicatelor
            int nr_cifre_ramase = rezultat.Length;

            if (nr_cifre_ramase == 2) // strict 2 cifre
                Console.WriteLine($"{n} este un numar format din doua cifre care se pot repeta.");
            else // daca sunt mai multe sau mai putine cifre
                Console.WriteLine($"{n} nu este un numar format din doua cifre care se pot repeta.");
        }

        private static void P18()
        {
            // descompunerea in factori primi al unui nr n

            int n, d, p;

            Console.WriteLine("Introduceti un numar natural pozitiv:");
            n = Convert.ToInt32(Console.ReadLine());

            for (d = 2; n > 1; d++)
            {
                if (n % d == 0)
                {
                    p = 0; // stocam repetitia puterii
                    while (n % d == 0)
                    {
                        n /= d;
                        p++;
                    }
                    Console.WriteLine($"{d} este un factor prim de {p} ori.");
                }
            }
        }

        private static void P17()
        {
            // c.m. mare divizor comun si c.m. mic multiplu comun al unui nr
            // folosind algoritmul lui Euclid

            int n, m, temp1, temp2;

            Console.WriteLine("Dati doua numere:");
            Console.WriteLine("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("m = ");
            m = Convert.ToInt32(Console.ReadLine());

            temp1 = n;
            temp2 = m;

            if ((n == 0) || (m == 0)) // sa fie diferite de 0
                Console.WriteLine("Numerele trebuie sa fie diferite de 0.");
            else
            {
                while (n != m)
                {
                    if (n > m)
                        n = n - m;
                    else
                        m = m - n;
                }
                Console.WriteLine($"Cel mai mare divizor comun al {temp1} si {temp2} este {n}.");

                // c.m. mic multiplu comun este produsul dintre n si m, impartit cu c.m. mare divizor comun
                int cmmmc = (temp1 * temp2) / n;
                Console.WriteLine($"Cel mai mic multimplu comun al {temp1} si {temp2} este {cmmmc}.");
            }
        }

        private static void P16()
        {
            // 5 numere, ordoneaza crescator

            int a, b, c, d, e, temp;

            Console.WriteLine("Dati 5 numere: ");
            Console.WriteLine("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b =");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c =");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("d =");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("e =");
            e = Convert.ToInt32(Console.ReadLine());

            // incercam fiecare combinatie de 5 valori
            if (a > b)
            {
                temp = a; //temp stocheaza valoarea a
                a = b; // a stocheaza b
                b = temp; // b stocheaza valoarea initiala a
            }
            if (c > d)
            {
                temp = c;
                c = d;
                d = temp;
            }
            if (a > c)
            {
                temp = c;
                a = c;
                c = temp;
            }
            if (b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if (a > e)
            {
                temp = a;
                a = e;
                e = temp;
            }
            if (b > e)
            {
                temp = b;
                b = e;
                e = temp;
            }
            if (c > e)
            {
                temp = c;
                c = e;
                e = temp;
            }
            if (d > e)
            {
                temp = d;
                d = e;
                e = temp;
            }
            Console.WriteLine($"Ordonate crescator: {a}, {b}, {c}, {d}, {e}.");
        }

        private static void P15()
        {
            // 3 numere, odoneaza crescator
            int a, b, c;
            Console.WriteLine("Dati valoarea lui a =");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati valoarea lui b =");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati valoarea lui c =");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a > b) && (a > c) && (b > c)) //abc
                Console.WriteLine($"Ordonate crescator: {a}, {b}, {c}");
            else if ((a > b) && (a > c) && (b < c)) //acb
                Console.WriteLine($"Ordonate crescator: {a}, {c}, {b}");
            else if ((a < b) && (a > c) && (b > c)) //bac
                Console.WriteLine($"Ordonate crescator: {b}, {a}, {c}");
            else if ((a < b) && (a < c) && (b > c)) //bca
                Console.WriteLine($"Ordonate crescator: {b}, {c}, {a}");
            else if ((a > b) && (a < c) && (b < c)) //cab
                Console.WriteLine($"Ordonate crescator: {c}, {a}, {b}");
            else // cba
                Console.WriteLine($"Ordonate crescator: {c}, {b}, {a}");
        }

        private static void P14()
        {
            // verificam daca un nr este palindrom

            int n, rev, temp;
            int sum = 0;
            Console.WriteLine("Dati un numar natural:");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n; //stocam n temporar in temp

            while (n > 0)
            {
                rev = n % 10;
                sum = (sum * 10) + rev;
                n = n / 10;
            }

            if (temp == sum)
                Console.WriteLine("Este palindrom.");
            else
                Console.WriteLine("Nu este palindrom.");
        }

        private static void P13()
        {
            // ani bisecti intre y1 si y2

            int y1, y2;
            int ani = 0; // stocam aici nr de ani

            Console.WriteLine("Introduceti y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if ((y1 % 4 == 0 && y1 % 100 != 0) || (y1 % 400 == 0)) // verificam daca este an bisect
                    ani++; //creste
                if (y1 + 1 == y2) // ne oprim la y2
                    break;
                y1++;
            }
            Console.WriteLine($"Intre {y1} si {y2} sunt {ani} ani bisecti.");
        }

        private static void P12()
        {
            // det cate nr intregi se divid cu n intre intervalul [a, b]

            int a, b, n, div = 1;
            int nr = 0;
            Console.WriteLine("Dati valoarea lui a =");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati valoarea lui b =");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati un numar n:");
            n = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (div % n == 0)
                    nr++;
                if (div + 1 == b) // ne oprim la b
                    break;
                div++;
            }
            Console.WriteLine($"Intre {a} si {b} exista {nr} numere intregi divizibile cu {n}.");
        }

        private static void P11()
        {
            //inversa nr

            int n, r;
            int inversa = 0;
            Console.WriteLine("Introduceti un numar de cel putin doua cifre:");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0) //n diferit de 0
            {
                r = n % 10;
                inversa = (inversa * 10) + r;
                n = n / 10;
            }
            Console.WriteLine($"Inversa numarului este {inversa}.");
        }


        private static void P10()
        {
            // test de primalitate

            int n, i;
            int m = 0, flag = 0;
            Console.WriteLine("Introduceti un numar:");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;

            // nr prime se divid cu 1 si cu ele insasi
            // 2 este singurul nr prim par
            // restul nr prime sunt impare

            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{n} nu este prim.");
                    flag = 1; // nr par
                    break;
                }
            }
            if ((n == 0) || (n < 0)) //daca user input este 0 sau nr negativ se afiseaza
                Console.WriteLine($"Numarul este negativ sau 0. {n} nu este prim.");
            else
            {
                if (flag == 0) // nr impar sau 2
                    Console.WriteLine($"{n} este prim.");
            }
        }

        private static void P9()
        {
            // divizorii nr. n

            int n, d;
            Console.WriteLine("Dati un numar natural:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Divizorii lui {n} sunt:");

            // un numar de divide cu 1 si cu el insusi
            for (d = 1; d <= n; d++)
            {
                if (n % d == 0) //verificam daca se divide fara rest
                    Console.WriteLine($"{d} ");
            }
        }

        private static void P8()
        {
            // inversarea 2 valori a si b (fara a folosi c)

            int a, b;
            Console.WriteLine("Dati valoarea lui a =");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati valoarea lui b =");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b; // a stocheaza suma lui a si b
            b = a - b; // b stocheaza suma din care scade valoarea b
            a = a - b; // a la fel

            Console.WriteLine($"a = {a}, b = {b}");
        }

        private static void P7()
        {
            // inversarea 2 valori a si b

            int a, b, c;
            Console.WriteLine("Dati valoarea lui a =");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati valoarea lui b =");
            b = Convert.ToInt32(Console.ReadLine());

            c = a; // c stocheaza valoarea lui a
            a = b; // a stocheaza valoarea lui b
            b = c; // b stocheaza valoarea initiala a lui a

            Console.WriteLine($"a = {a}, b = {b}");
        }

        private static void P6()
        {
            // daca 3 numere pot forma triunghi

            float a, b, c;

            Console.WriteLine("Introduceti latura a = ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latura b = ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latura c = ");
            c = float.Parse(Console.ReadLine());

            // a,b,c sa fie mai mare decat 0
            // suma a 2 laturi sa fie mai mare decat orice latura
            if ((a < b + c) && (b < a + c) && (c < a + b) && (a > 0) && (b > 0) && (c > 0))
            {
                Console.WriteLine("Numerele pot forma triunghiuri.");
                if ((a == b) && (a == c)) // laturile sunt egale
                    Console.WriteLine("Triunghi echilateral.");

                else if ((a == b) || (a == c) || (b == c)) // oricare 2 laturi sunt egale
                    Console.WriteLine("Triunghi isoscel.");

                else
                    Console.WriteLine("Triunghi oarecare.");
            }

            else
                Console.WriteLine("Numerele nu pot forma triunghi.");
        }

        private static void P5()
        {
            // a k-a cifra de la sfarsitul unui nr. (dreapta -> stanga)

            int nr, kth, rezultat;

            Console.WriteLine("Introduce un numar de mai multe cifre: ");
            nr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati o valoare pentru a cata cifra sa fie citita (de la dreapta la stanga): ");
            kth = Convert.ToInt32(Console.ReadLine());

            rezultat = (nr / (int)Math.Pow(10, kth - 1)) % 10;

            Console.WriteLine($"{rezultat}");
        }

        private static void P4()
        {
            // det daca y este an bisect

            int y;
            Console.WriteLine("Dati un an pentru a verifica daca este bisect:");
            y = Convert.ToInt32(Console.ReadLine());

            if (y % 4 == 0) // bisect daca se divide curat cu 4
            {
                if (y % 100 == 0) // cu exceptia nr. divizibile cu 100
                {
                    if (y % 400 == 0) // inafara de cazul in care se divide si cu 400
                        Console.WriteLine($"{y} este an bisect.");
                    else
                        Console.WriteLine($"{y} nu este an bisect.");
                }
                else
                    Console.WriteLine($"{y} este an bisect.");
            }
            else
                Console.WriteLine($"{y} nu este an bisect.");
        }

        private static void P3()
        {
            // det daca n se divide cu k

            int n, k;

            Console.WriteLine("Introduce valoarea n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce valoarea k = ");
            k = Convert.ToInt32(Console.ReadLine());

            if (n % k == 0) // daca se divide curat
                Console.WriteLine("N se divide cu k.");
            else // daca impartirea da rest
                Console.WriteLine("N nu se divide cu k.");
        }

        private static void P2()
        {
            // ecuatia de gradul 2: ax^2 + bx + c = 0

            int a, b, c;
            double x1, x2, delta, rezultat;

            Console.WriteLine("Introduceti valoarea a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea c = ");
            c = Convert.ToInt32(Console.ReadLine());

            delta = b * b - (4 * a * c); //calculam delta

            if (delta < 0) // daca delta mai mic decat 0
                Console.WriteLine("Nu exista solutii in multimea numerelor reale.");
            else
            {
                if (delta == 0) // daca delta egal cu 0
                {
                    rezultat = x1 = x2 = -b / (2 * a);
                    Console.WriteLine($"Solutiile x1 si x2 sunt egale : {rezultat}");
                }
                else // daca delta mai mare decat 0
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Solutiile: x1 = {x1} si x2 = {x2}");
                }
            }
        }

        private static void P1()
        {
            // ecuatia de gradul 1: ax + b = 0

            int a, b;
            float x;

            Console.WriteLine("Introduceti doua numere:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (a != 0) // check a
            {
                x = -(float)b / (float)a;
                Console.WriteLine($"X = {x}.");
            }
            else // daca a = 0, atunci:
            {
                if (b == 0) // check b 
                {
                    Console.WriteLine("Avem o infinitate de solutii.");
                }
                else
                {
                    Console.WriteLine("Nu exista solutii reale.");
                }
            }
        }
    }
}