using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_ImpUserInterface
{
    interface IEvaluate
    {
        int NumOfVariant { get; set; }
        int ParamValue { get; set; }
        void Invoke_Variant(int numOfVariant, int EvaluateValueDefault);
        string Execute_Variant();
    }
}
