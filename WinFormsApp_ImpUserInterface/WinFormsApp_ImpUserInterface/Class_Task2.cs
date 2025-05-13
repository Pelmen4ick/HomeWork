using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_ImpUserInterface
{
    class Class_Task2 : IEvaluate
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
            string strValue = Math.Abs(ParamValue).ToString();
            if (string.IsNullOrEmpty(strValue))
                return "Число не содержит цифр";

            int minDigit = strValue.Select(c => int.Parse(c.ToString())).Min();
            return $"Наименьшая цифра числа {ParamValue}: {minDigit}";
        }
    }
}

