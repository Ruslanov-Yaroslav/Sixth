using EquationSolver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi.Classes
{
    class WriterForExplanation
    {
        public static void WriteExplanation(object parameters)
        {
            ThreatParams threatParams = (ThreatParams)parameters;
            var streamWriter = threatParams.streamWriter;
            var equations = threatParams.equations;
            var stopWatch = threatParams.stopWatch;
            EqSolver eqSolver = new EqSolver();
            foreach (var equation in equations)
            {
                var result = eqSolver.ResolveEquation(equation);
                var r = result.Result;
                streamWriter.WriteLine(r.Explanation);
            }
            stopWatch.Stop();
            streamWriter.WriteLine(GetTime.GetExecutionTime(stopWatch));
            streamWriter.Close();
        }
    }
}
