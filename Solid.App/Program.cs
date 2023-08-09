using Solid.App.OCPGood2;
using static Solid.App.OCPBad.SalaryCalculator;

SalaryCalculator salaryCalculator = new SalaryCalculator();

// Bad Way
//Console.WriteLine($"Low salary : {salaryCalculator.Calculate(1000, SalaryType.Low)}");
//Console.WriteLine($"Middle salary : {salaryCalculator.Calculate(1000, SalaryType.Middle)}");
//Console.WriteLine($"High salary : {salaryCalculator.Calculate(1000, SalaryType.High)}");

// Good Way
//Console.WriteLine($"Low salary : {salaryCalculator.Calculate(1000, new LowSalaryCalculate())}");
//Console.WriteLine($"Middle salary : {salaryCalculator.Calculate(1000, new MiddleSalaryCalculate())}");
//Console.WriteLine($"High salary : {salaryCalculator.Calculate(1000, new HighSalaryCalculate())}");
//Console.WriteLine($"Manager salary : {salaryCalculator.Calculate(1000, new ManagerSalaryCalculate())}");

// Good secondWay
Console.WriteLine($"Low salary : {salaryCalculator.Calculate(1000, new LowSalaryCalculate().Calculate)}");
Console.WriteLine($"Middle salary : {salaryCalculator.Calculate(1000, new MiddleSalaryCalculate().Calculate)}");
Console.WriteLine($"High salary : {salaryCalculator.Calculate(1000, new HighSalaryCalculate().Calculate)}");
Console.WriteLine($"Manager salary : {salaryCalculator.Calculate(1000, new ManagerSalaryCalculate().Calculate)}");

Console.WriteLine($"Custom salary : {salaryCalculator.Calculate(1000, x =>
{
    return x * 10;
}
)}");



