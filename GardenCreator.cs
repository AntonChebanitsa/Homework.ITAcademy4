using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Serialization;

namespace Homework.ITAcademy4
{
    public class GardenCreator
    {
        public int[,] Garden { get; private set; }

        public void Create()
        {
            Console.WriteLine($"Create a garden with size: ");
            var x = Convert.ToInt32(Console.ReadLine());
            var y = Convert.ToInt32(Console.ReadLine());

            Garden= new int[x,y];
            Draw();
        }
        
        public void Draw()
        {
            var upper = Garden.GetUpperBound(0)+1;
            for (var i = 0; i < Garden.Length; i++)
            {
                if (i%upper==0)
                {
                    Console.WriteLine();
                }
                Console.Write("*");
            }
            
        }
    }
}