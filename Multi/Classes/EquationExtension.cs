using EquationSolver;
using System;


namespace Multi.Classes
{
    public static class EquationExtension
    {
        public static void Initialization(this Equation equation)
        {
            Random random = new Random();
            equation.A = Math.Round(random.NextDouble(), 3);
            equation.B = Math.Round(random.NextDouble(), 3);
            equation.C = Math.Round(random.NextDouble(), 3);
        }

        public static void Initialization(this Equation equation, double[] array)
        {
            equation.A = array[0];
            equation.B = array[1];
            equation.C = array[2];
        }
    }
}
