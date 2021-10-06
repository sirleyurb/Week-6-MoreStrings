using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada perekonnanime
            //programm kuvab, mitu "a" tähte kasutaja eesnimes ja 
            //pereonnanimes kokku on 

            int counter = 0;
            
            Console.WriteLine("sisesta oma eesnimi");
            string userName = Console.ReadLine();

            Console.WriteLine("sisesta oma perekonnanimi:");
            string userLastName = Console.ReadLine();

            string fullName = $"{userName}{userLastName}".ToLower();
            
            foreach(char character in fullName)
            {
                if(character == 'a')
                {
                    counter++; //counter = + 1
                }
            }
            Console.WriteLine($"sinu nimes on {counter} a-tähte");

        }
    }
}
