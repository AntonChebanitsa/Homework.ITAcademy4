﻿using System;

namespace Homework.ITAcademy4
{
    public class FirstGardener
    {
        public async void Handle()
        {
            var obverse = true;
            
            for (var i = 0; i <= GardenCreator.Garden.GetUpperBound(1); i++)
            {
                if (obverse)
                {
                    for (var j = 0; j <= GardenCreator.Garden.GetUpperBound(0); j++)
                    {
                        if (GardenCreator.Garden[i, j]==0)
                        {
                            GardenCreator.Garden[i, j] = 1;
                        }
                        else if (GardenCreator.Garden[i, j] == 5)
                        {
                            continue;
                        }
                    }
                }

                else
                {
                    for (var j = GardenCreator.Garden.GetUpperBound(0); j >= 0; j--)
                    {
                        if (GardenCreator.Garden[i, j] == 0)
                        {
                            GardenCreator.Garden[i, j] = 1;
                        }
                        else if (GardenCreator.Garden[i, j] == 5)
                        {
                            continue;
                        }
                    }
                }

                obverse = !obverse;
            }
        }
    }
}