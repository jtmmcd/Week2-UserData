using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun sisestage oma sünniaasta:");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2021 - YearOfBirth;

            //Console.WriteLine("Oled " + UserAge + " aastat vana.");

            //string interpolation

            Console.WriteLine($"Oled {UserAge} aastat vana.");  
            
            Console.Read();

            



        }
    }
}
