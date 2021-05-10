using System;

namespace NfiSharp8
{
    class Program
    {
        static void Main(string[] args)
        {


            int menyVal = 1; // 1 och 4

            switch (menyVal)
            {
                case 1:
                    Console.WriteLine("Menyval 1");
                    break;
                case 2:
                    Console.WriteLine("Menyval 2");
                    break;
                case 3:
                    Console.WriteLine("Menyval 3");
                    break;
                case 4:
                    Console.WriteLine("Menyval 4");
                    break;
                default:
                    Console.WriteLine("Felaktigt menyval");
                    break;
            }


            int i = 12;
            string namn = "Stefan";
            if (i ==  12 && namn == "Stefan" )
            {
                Console.WriteLine("dasadsads");
                Console.WriteLine("33");
            }

            if (i == 12 || i == 13)
                Console.WriteLine("12or13");
            else if (i == 14)
            {
                Console.WriteLine("14");
            }
            else if (i == 15)
            {
                Console.WriteLine("155");
            }
            else
                Console.WriteLine("Nåt annat");





            Console.WriteLine("33");




            Console.WriteLine("Mata in pris");
            string s = Console.ReadLine();
            decimal d = Convert.ToDecimal( s  );

            decimal moms = d * 0.25m;
            //decimal total = moms +d;
            //Förbereder bara ;)

            //MEN NI: Det finns OÄNDLIGT många sätt att måla en tavla
            //och att skriva KOD
            //Tro inte att jag sitter på FACIT! Find your coding style
            Console.WriteLine($"Moms är {moms} kr och totalen är {moms+d}" );
            
            Console.WriteLine("Moms är " + moms
                              + " kr och totalen är " + (moms+d));

            Console.Write("Moms är ");
            Console.Write(moms);
            Console.Write(" kr och totalen är ");
            Console.WriteLine(moms + d);

        }
    }
}
