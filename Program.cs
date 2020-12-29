using System;

namespace Homework.ITAcademy4
{
    class Program
    {
        static void Main()
        {
            GardenCreator.Create();

            Console.Write("\nPress Enter to handle");
            Console.ReadLine();

            var fg = new FirstGardener();
            fg.Handle();

            var sg = new SecondGardener();
            sg.Handle();

            GardenCreator.Draw();
        }
    }
}
