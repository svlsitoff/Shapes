using System;

namespace ClassLibShapes
{
    public class Shape
    {
        double[] sides;
        public Shape(params double[] inputSides)
        {
            if (inputSides != null)
            {
                for(int i = 0; i < inputSides.Length; i++)
                {
                    if (inputSides[i] <= 0)
                    {
                        Console.WriteLine("Input data is incorrect");
                        return;                   
                    }
                }
                sides = new double[inputSides.Length];
                for (int i = 0; i < inputSides.Length; i++)
                {
                    sides[i] = inputSides[i];
                }
                if (sides.Length == 3)
                {
                    double a = sides[0], b = sides[1], c = sides[2];
                    if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2) || Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2) || Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                    {
                        Console.WriteLine("Это  прямоугольный треугольник");
                    }
                }
            }

        }

        public double getArea()
        {
            if (sides != null)
            {
                if (sides.Length == 1)
                {
                    return Math.Pow(sides[0], 2) * 3.14;
                }
                if (sides.Length == 3)
                {
                    double a = sides[0], b = sides[1], c = sides[2];
                    double p = (a + b + c) / 2;
                    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
            }

            return 0;
        }
    }
}
