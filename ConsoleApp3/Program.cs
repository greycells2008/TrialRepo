using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace jaggedarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][][] GPSArray = new string[2][][];
            for(int i=0;i<GPSArray.Length;i++)
            {
                Console.Write("Enter name of the place");
                GPSArray[i][0][0] = Console.ReadLine();
                Console.Write("Enter longitude of the place");
                GPSArray[i][1][0] = Console.ReadLine();
                Console.Write("Enter latitude of the place");
                GPSArray[i][2][0] = Console.ReadLine();
                Console.Write("Enter distance of the place");
                GPSArray[i][3][0] = Console.ReadLine();
                Console.Write("Enter number of places of interest:");
                int.TryParse(Console.ReadLine(), out int Numofplaces);
                string[] placesofinterest = new string[Numofplaces];
                for(int j=0;j<Numofplaces;j++)
                {
                    placesofinterest[j] = Console.ReadLine();
                }
                GPSArray[i][4] = placesofinterest;
            }
            for (int i = 0; i < GPSArray.Length; i++)
            {
                Console.Write(GPSArray[i][0][0]);
                Console.Write(GPSArray[i][1][0]);
                Console.Write(GPSArray[i][2][0]);
                Console.Write(GPSArray[i][3][0]);
                for(int x=0;x<GPSArray[i][4].Length;x++)
                {
                    Console.Write(GPSArray[i][4][x]);
                }
            }
        }
    }
}