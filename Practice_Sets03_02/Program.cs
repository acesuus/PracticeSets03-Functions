﻿using System;

namespace OOP.PracticeSets03
{
    class Year
    {
        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    return false;
                }
                return true;
                

            }
            return false;
        }
    }
}
