using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Serialization;

namespace Homework.ITAcademy4
{
    public static class GardenCreator
    {
        public static int[,] Garden { get; set; }

        public static void Create()
        {
            Console.WriteLine($"Create a garden with size: ");
            var x = Convert.ToInt32(Console.ReadLine());
            var y = Convert.ToInt32(Console.ReadLine());

            Garden= new int[x,y];
            Fill();
        }

        public static void Fill()
        {
            for (var i = 0; i-1 < Garden.GetUpperBound(0); i++)
            {
                for (var j = 0; j-1 < Garden.GetUpperBound(1); j++)
                {
                    Garden[i, j]=0;
                }
            }
        }
        
        public static void Draw()
        {
            for (var i = 0; i-1 < Garden.GetUpperBound(0); i++)
            {
                for (var j = 0; j-1 < Garden.GetUpperBound(1); j++)
                {
                    Console.Write(Garden[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}