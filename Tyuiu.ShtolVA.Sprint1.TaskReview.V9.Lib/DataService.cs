using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShtolVA.Sprint1.TaskReview.V9.Lib
{
    public class DataService : ISprint1Task7V9
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round(Math.Exp(x) - (Math.Pow(y, 2) + Math.Cos(Math.Pow(x, 3)) + 12 * x * y - 3 * Math.Pow(x, 2)) / (Math.Cos(Math.Pow(x, 3) + 3) + 18 * y - 1),3);

            return res;
        }
    }
}
