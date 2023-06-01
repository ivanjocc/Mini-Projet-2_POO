using System;

namespace Project2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire newObject = new CompteBancaire(123123123, "tigro feliz", 10000);

            newObject.Afficher();
            Console.WriteLine();
            
            newObject.Versement(1000);
            newObject.Afficher();
            Console.WriteLine();

            newObject.Retrait(20000);
            newObject.Afficher();
            Console.WriteLine();

            newObject.Agios();
            newObject.Afficher();
        }
    }
}