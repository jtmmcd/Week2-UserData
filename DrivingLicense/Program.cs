using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //kui kasutaja on noorem, kui 18 siis programm kuvab konsoolis
            //"oled liiga noor, et juhilube saada";
            //kui kasutaja on vanem, kui 18 siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhilube saada";
            //kui kasutaja on 18 siis programm kuva´b konsoolis
            //"palju õnne, nüüd saad juhilube taotleda";

            Console.WriteLine("Palun sisestage oma sünniaasta:");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int UserAge = 2021 - YearOfBirth;

            if (UserAge < 18)
            { Console.WriteLine("Olete liiga noor, et juhilube saada."); }

            else if (UserAge > 18)
            { Console.WriteLine("Olete piisavalt vana, et juhilube saada."); }

            else
            { Console.WriteLine("Palju õnne, nüüd saate juhilube taotleda."); }

            Console.Read();

        }
    }
}
