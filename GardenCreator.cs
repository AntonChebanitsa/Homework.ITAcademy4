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
            int x = 0;
            int y = 0;

            Console.WriteLine($"Create a garden with size: ");

            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                Environment.Exit(0);
            }
            Garden = new int[x, y];
            Fill();
            AddImpassablePoint();
        }

        public static void Fill()
        {
            for (var i = 0; i < Garden.GetUpperBound(0); i++)
            {
                for (var j = 0; j < Garden.GetUpperBound(1); j++)
                {
                    Garden[i, j] = 0;
                }
            }
            Draw();
        }

        public static void Draw()
        {
            for (var i = 0; i - 1 < Garden.GetUpperBound(0); i++)
            {
                for (var j = 0; j - 1 < Garden.GetUpperBound(1); j++)
                {
                    Console.Write(Garden[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void AddImpassablePoint()
        {
            string input = "";
            Console.WriteLine("If you want to add impassable point enter \"y\"");
            try
            {
                input = Convert.ToString(Console.ReadLine()).ToLowerInvariant();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Environment.Exit(0);
            }

            if (input != "y") return;
            {
                int x = 0;
                int y = 0;
                Console.WriteLine("Enter the coordinates of the impassable point");
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(0);
                }

                Garden[x-1, y-1] = 5;
            }
        }
    }
}