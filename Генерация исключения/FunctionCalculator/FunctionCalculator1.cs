using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionCalculator
{
    public class FunctionCalculator1
    {
        public void Calculate(double N, int iterations, double k)
        {
            
            double step = 0.1;

            try
            {
                for (double x = 0; x <= k; x += step)
                {
                    if (Math.Abs(x - N) < double.Epsilon)
                    {
                        throw new ArgumentException("Деление на ноль не допускается. ");
                    }

                    double result = 1 / (x - N);
                    Console.WriteLine($"f({x}) = {result}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Исключение поймано: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"произошла непредвиденная ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Расчет завершен.");
            }
        }
    }


}
