using EquationSolver;
using Multi.Classes;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;

namespace Multi
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\ProjectForMult";
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
            DirectoryInfo directory = Directory.CreateDirectory(path);
            string filenameInput = $"{directory}\\input.txt";
            string filenameOutput = $"{directory}\\output.txt";

            using (StreamWriter streamWriter = new StreamWriter(filenameInput))
                for (int i = 0; i < 10; i++)
                {
                    Equation equation = new Equation();
                    equation.Initialization();
                    streamWriter.AddEquation(equation);
                }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            List<Equation> equations = new List<Equation>();

            using (StreamReader streamReader = new StreamReader(filenameInput))
                equations = Reader.ReadFromFile(streamReader);

            StreamWriter streamWriter1 = new StreamWriter(filenameOutput);
            ThreatParams threatParams = new ThreatParams(streamWriter1, equations, stopWatch);
            Thread myThread = new Thread(new ParameterizedThreadStart(WriterForExplanation.WriteExplanation));
            myThread.Start(threatParams);
        }

    }
}
