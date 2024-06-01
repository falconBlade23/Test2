using System;
using DexCompany;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            var employee = new Employee { Name = "John Doe", Age = 30, Position = "Developer" };
            UpdateContract(employee);
            Console.WriteLine($"Employee Contract: {employee.Contract}");

            var currency = new Currency { Code = "USD", Value = 100.50m };
            UpdateCurrency(ref currency);
            Console.WriteLine($"Currency Value: {currency.Value}");
        }   

        static void UpdateContract(Employee employee)
        {
            employee.Contract = $"Contract for {employee.Name}, Position: {employee.Position}, Age: {employee.Age}";
        }

        static void UpdateCurrency(ref Currency currency)
        {
            currency.UpdateValue(120.75m);
        }
    }
    
}
