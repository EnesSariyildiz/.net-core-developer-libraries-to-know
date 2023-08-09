using Solid.App.OCPBad;
using static Solid.App.OCPBad.SalaryCalculator;

SalaryCalculator salaryCalculator = new SalaryCalculator();


Console.WriteLine($"Low salary : {salaryCalculator.Calculate(1000, SalaryType.Low)}");
Console.WriteLine($"Middle salary : {salaryCalculator.Calculate(1000, SalaryType.Middle)}");
Console.WriteLine($"High salary : {salaryCalculator.Calculate(1000, SalaryType.High)}");

Console.ReadKey();
