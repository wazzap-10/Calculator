using System;

namespace Kalkulator_Final_
{
    class Program
    {
        static void Main(string[] args)
        {
            var rezultat = new Kalkulator(10, 5);
            Console.WriteLine(rezultat.sobiranje(10, 5));
            Console.WriteLine(rezultat.odzimanje(10, 5));
            Console.WriteLine(rezultat.mnozenje(10, 5));
            Console.WriteLine(rezultat.delenje(10, 5));
            Console.WriteLine(rezultat.ostatok(10, 5));
            Console.WriteLine(rezultat.komparacija(10, 5));

        }
        public class Kalkulator
        {
            public int a;
            public int b;
            public Kalkulator(int a, int b)
            {
                this.a = a;
                this.b = b;

            }
            public int sobiranje(int a, int b)
            {
                int c = a + b;
                Console.WriteLine("Prviot broj e: " + a + " a vtoriot broj e: " + b + " i nivniot zbir e: ");
                return c;
            }
            public int odzimanje(int a, int b)
            {
                int c = a - b;
                Console.WriteLine("Prviot broj e: " + a + " a vtoriot broj e: " + b + " i nivnata razlika e: ");
                return c;
            }
            public int mnozenje(int a, int b)
            {
                int c = a * b;
                Console.WriteLine("Prviot broj e: " + a + " a vtoriot broj e: " + b + " i nivniot proizvod e: ");
                return c;
            }
            public int delenje(int a, int b)
            {
                int c = a / b;
                Console.WriteLine("Prviot broj e: " + a + " a vtoriot broj e: " + b + " i nivniot kolicnik e: ");
                return c;
            }
            public int ostatok(int a, int b)
            {
                int c = a % b;
                Console.WriteLine("Prviot broj e: " + a + " a vtoriot broj e: " + b + " i nivniot ostatok e: ");
                return c;
            }

            public int komparacija(int a, int b)
            {

                if (a < b)
                {
                    Console.WriteLine("Prviot broj: " + a + "e pomal od vtoriot broj: " + b);
                    return b;

                }
                else
                {
                    Console.WriteLine("Prviot broj: " + a + " e pogolem od vtoriot broj: " + b);
                    return a;
                }

            }
        }
    }
}

                

            
        
        
    

