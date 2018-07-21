using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Roster
{
    class Program
    {
        private static List<Employee> Employees;

        private static decimal HighestAvgSalaryByDepartment = 0.0m;

        //Department with highest avarage salary
        private static string Department = null;

        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            AddEmployees(lines);

            HighAverageSalary();

            Console.WriteLine($"Highest Average Salary: {Department}");
            foreach (var employee in Employees.OrderByDescending(s =>s.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }

        private static void HighAverageSalary()
        {
            var departmentsEmployees = new Dictionary<string, List<Employee>>();

            foreach (var employee in Employees)
            {
                if (!departmentsEmployees.ContainsKey(employee.Department))
                {
                    departmentsEmployees[employee.Department] = new List<Employee>();
                }
                departmentsEmployees[employee.Department].Add(employee);

            }

            //Pair.Value = Employees in department
            foreach (var pair in departmentsEmployees)
            {
                decimal avgSalary = AverageSalaryByDepartment(pair.Value);

                // Check if current department`s avarage salary is greatest
                if (avgSalary > HighestAvgSalaryByDepartment)
                {
                    Employees = null;
                    Department = null;
                    HighestAvgSalaryByDepartment = avgSalary;
                    Employees = pair.Value;
                    Department = pair.Key;
                }       
            }
        }

        private static decimal AverageSalaryByDepartment(List<Employee> employeesByDepartment)
        {
            var sumSalary = 0.0m;

            foreach (var employee in employeesByDepartment)
                sumSalary += employee.Salary;

            return sumSalary / employeesByDepartment.Count;
        }

        private static void AddEmployees(int lines)
        {
            Employees = new List<Employee>();

            for (int i = 0; i < lines; i++)
            {
                var newEmployee = Console.ReadLine()
                    .Split()
                    .ToArray();

                var employee = new Employee
                {
                    Name = newEmployee[0],
                    Salary = decimal.Parse(newEmployee[1]),
                    Position = newEmployee[2],
                    Department = newEmployee[3]
                };

                if (newEmployee.Length < 5)
                {
                    employee.Email = "n/a";
                    employee.Age = -1;
                }
                else if (newEmployee.Length < 6)
                {
                    //true = Email ; false = Age
                    bool isEmailOrAge = IsEmailOrAge(newEmployee);
                    if (isEmailOrAge)
                    {
                        employee.Email = newEmployee[4];
                        employee.Age = short.Parse("-1");
                    }
                    else
                    {
                        employee.Email = "n/a";
                        employee.Age = short.Parse(newEmployee[4]);
                    }
                }
                else
                {
                    employee.Email = newEmployee[4];
                    employee.Age = short.Parse(newEmployee[5]);
                }
                Employees.Add(employee);

            }
        }

        private static bool IsEmailOrAge(string[] newEmployee)
        {
            return Char.IsLetter(newEmployee[4][0]);
        }
    }
}
