using System;

namespace project
{
    class Program
    {
        static void Main()
        {

            CarSpec audi = new CarSpec();
            audi.SetValues("Audi RS3", 400);


            CarSpec masinaCopie = audi;


            masinaCopie.SetValues("BMW E36", 250);

            Console.WriteLine("--- STRUCTURA ORIGINALA ---");
            audi.PrintValues();

            Console.WriteLine("\n--- STRUCTURA COPIE ---");
            masinaCopie.PrintValues();
        }
    }
}