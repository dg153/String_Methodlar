using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Num_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken_1 = " Dersimiz C#, Hoşgeldiniz.";

            string degisken_2 = " Dersimiz C#";

            //Length
            Console.WriteLine(degisken_1.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken_1.ToUpper());

            Console.WriteLine(degisken_1.ToLower());

            //Concat
            Console.WriteLine(string.Concat(degisken_1, "Merhaba."));

            //ConoareTo , Compare
            Console.WriteLine(degisken_1.CompareTo(degisken_2));

            Console.WriteLine(String.Compare(degisken_1, degisken_2, true));

            Console.WriteLine(String.Compare(degisken_1, degisken_2, false));

            //Contains
            Console.WriteLine(degisken_2.Contains(degisken_2));

            Console.WriteLine(degisken_1.EndsWith("Hosgeldiniz."));

            Console.WriteLine(degisken_1.StartsWith("Merhaba"));

            //IndexOf
            Console.WriteLine(degisken_1.IndexOf("C#"));

            Console.WriteLine(degisken_1.IndexOf("zikriye"));

            //Insert
            Console.WriteLine(degisken_1.Insert(0, "Merhaba!"));

            Console.WriteLine(degisken_1.LastIndexOf("i"));

            //PadLeft, PadRight
            Console.WriteLine(degisken_1 + degisken_2.PadLeft(30));

            Console.WriteLine(degisken_1 + degisken_2.PadLeft(30), "*");

            Console.WriteLine(degisken_1 + degisken_2.PadRight(30));

            Console.WriteLine(degisken_1 + degisken_2.PadRight(30), "-");

            //Remove
            Console.WriteLine(degisken_1.Remove(10));

            Console.WriteLine(degisken_1.Remove(5, 3));

            Console.WriteLine(degisken_1.Remove(0, 1));

            //Replace
            Console.WriteLine(degisken_1.Replace("C#", "CSharp"));

            Console.WriteLine(degisken_1.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken_1.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken_1.Substring(4));
            Console.WriteLine(degisken_1.Substring(4, 6));




            Console.ReadLine();
        }
    }
}
