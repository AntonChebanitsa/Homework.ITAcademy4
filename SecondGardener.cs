using System;

namespace Homework.ITAcademy4
{
    public class SecondGardener
    {
        public void Handle()
        {
            //var upperBound = GardenCreator.Garden.GetUpperBound(0) + 1;

            //for (var i = 0; i < GardenCreator.Garden.Length; i++)
            //{
            //    if (i % upperBound == 0)
            //    {
            //        Console.WriteLine();
            //    }

            //    Console.Write("1");
            //}

            bool reverse = false;
            for (int i = GardenCreator.Garden.GetLength(1); i == 0; i--)
            {
                if (reverse)
                {
                    for (int j = GardenCreator.Garden.GetLength(0) - 1; j >= 0; j--)
                    {
                        Console.Write(GardenCreator.Garden[j, i] + " ");
                    }
                }

                else
                {
                    for (int j = 0; j < GardenCreator.Garden.GetLength(0); j++)
                    {
                        Console.Write(GardenCreator.Garden[j, i] + " ");
                    }
                }

                reverse = !reverse;
            }
        }
    }
}