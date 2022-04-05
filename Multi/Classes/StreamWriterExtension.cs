using EquationSolver;
using System.Collections.Generic;
using System.IO;


namespace Multi.Classes
{
    public static class StreamWriterExtension
    {
        public static void AddEquation(this StreamWriter streamWriter, Equation equation)
        {
            streamWriter.Write(equation.A);
            streamWriter.Write(" ");
            streamWriter.Write(equation.B);
            streamWriter.Write(" ");
            streamWriter.WriteLine(equation.C);
            streamWriter.Flush();
        }

        public static void AddEquations(this StreamWriter streamWriter, List<Equation> equations)
        {
            foreach (var equation in equations)
            {
                streamWriter.AddEquation(equation);
            }
        }
    }
}
