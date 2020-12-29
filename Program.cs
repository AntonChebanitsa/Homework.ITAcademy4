using System;

namespace Homework.ITAcademy4
{
    class Program
    {
        static void Main(string[] args)
        {
            GardenCreator.Create();
            GardenCreator.Draw();

            Console.Write("\nPress Enter to handle");
            Console.ReadLine();

            var fg=new FirstGardener();
            fg.Handle();

            GardenCreator.Draw();
        }
    }
}
