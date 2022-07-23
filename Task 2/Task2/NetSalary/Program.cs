using System;

namespace NetSalary
{
    internal class Program
    {
        private const decimal IncomeTax = 0.10M;
        private const decimal SocialContributionsTax = 0.15M;

        /// <summary>
        /// New taxes could be added to the system via const fields 
        /// and if checks respectively in the calculating net salary method.
        /// Dictionary with KeyValue pairs, containing the different taxes is an option as well,
        /// but didn't found this way more efficient compared to the current solution.
        /// </summary>
        internal static void Main()
        {
            Console.WriteLine("Enter your gross salary:");

            var input = decimal.Parse(Console.ReadLine());
            var message = "Your net salary is:";

            if (input <= 1000)
            {
                message += $" {input} IDR. {"\n"}";
            }
            else
            {
                var netSalary = CalculateNetSalary(input);
                message += $" {netSalary} IDR. {"\n"}";
            }

            Console.WriteLine(message);
        }
        
        private static decimal CalculateNetSalary(decimal grossSalary)
        {
            var incomeTaxAmount = (grossSalary - 1000) * IncomeTax;

            var socialContributionsTaxAmount = 0M;
            if (grossSalary - 1000 <= 3000)
            {
                socialContributionsTaxAmount = (grossSalary - 1000) * SocialContributionsTax;
            }

            var netSalary = grossSalary - (incomeTaxAmount + socialContributionsTaxAmount);

            return netSalary;
        }
    }
}
