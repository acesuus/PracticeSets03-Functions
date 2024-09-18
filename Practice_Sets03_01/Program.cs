using System;

namespace OOP.PracticeSets03
{
    class AreaofTriangle
    {
        double Heron_Formula(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return Area;
        }
    }
}