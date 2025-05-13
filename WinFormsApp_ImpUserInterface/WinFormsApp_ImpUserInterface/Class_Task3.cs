using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_ImpUserInterface
{
    class Class_Task3 : IEvaluate
    {
        public int NumOfVariant { get; set; }
        public int ParamValue { get; set; }

        public void Invoke_Variant(int numOfVariant, int paramValueDefault)
        {
            NumOfVariant = numOfVariant;
            ParamValue = paramValueDefault;
        }

        public string Execute_Variant()
        {
            double sum = 0;
            for (int i = 0; i < ParamValue; i++)
            {
                sum += 1 / Math.Pow(2, i);
            }
            double error = Math.Abs(sum - 2) / 2 * 100;
            return $"Результат: {sum:0.0000}\nТочное значение: 2.0000\nПогрешность: {error:0.00}%";
        }
    }
}
