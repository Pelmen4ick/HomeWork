using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_ImpUserInterface
{
    class Class_Task1 : IEvaluate
    {
        private const int N = 11; 

        public int NumOfVariant { get; set; }
        public int ParamValue { get; set; }

        public void Invoke_Variant(int numOfVariant, int paramValueDefault)
        {
            NumOfVariant = numOfVariant;
            
            ParamValue = Math.Max(-N, Math.Min(N, paramValueDefault * N));
        }

        public string Execute_Variant()
        {
            return $"Результат умножения на {N}: {ParamValue}";
        }
    }
}
