using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthRoot
{
    public static class NewtonMethod
    {
        /// <summary>
        /// Find nth root by using Newton's method.
        /// </summary>
        /// <param name="x">Number to find a root of</param>
        /// <param name="n">Degree of a root</param>
        /// <param name="eps">Accuracy 10^(-eps)</param>
        /// <exception cref="InvalidOperationException"> When n is less or equal than 0</exception>
        /// <exception cref="InvalidOperationException"> When eps is less or equal than 0 </exception>
        /// <exception cref="InvalidOperationException"> When x = 0 </exception>
        /// <exception cref="InvalidOperationException"> When you try to get even root of a negative number</exception>
        /// <returns></returns>
        public static double NthRoot(double x, int n, int eps)
        {
            if (n <= 0 || eps <= 0 || eps >= 16 || x == 0)
                throw new InvalidOperationException();

            if (x < 0 && n%2 == 0)
                throw new InvalidOperationException();

            double result;
            var newResult = x/n;
            var accuracy = Math.Pow(10, -eps);
            do
            {
                result = newResult;
                newResult = ((n - 1)*result + x/Math.Pow(result, n - 1))/n;
            } while (Math.Abs(result - newResult) > accuracy);
            return newResult;
        }
    }
}
