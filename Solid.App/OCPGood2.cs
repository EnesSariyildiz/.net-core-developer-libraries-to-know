using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.OCPGood2
{
    //Open Closed Prenciple

    //C#'daki delegeler; methodları işaret eden yapılardır.


    public interface ISalaryCalculate
    {
        decimal Calculate(decimal salary);
    }

    public class LowSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }

    public class MiddleSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }

    public class HighSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 6;
        }
    }

    public class ManagerSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 7;
        }
    }


    public class SalaryCalculator
    {
        // Action => void
        // Predicate // bool
        // Function

        public decimal Calculate(decimal salary, Func<decimal, decimal> calculateDelegate)
        {
            return calculateDelegate(salary);
        }
    }
}
