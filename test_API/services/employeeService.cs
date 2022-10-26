using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using test_API.Models;

namespace test_API.services
{
    public class employeeService
    {
        static List<employee> employeeList { get; }
        static int nextEmp = 3;

        static employeeService()
        {
            employeeList = new List<employee>()
            {
                new employee
                {
                    id = 1, name = "Lama", salary = 1000, dateOfBrith = new DateTime(2 / 8 / 2000),
                    email = "lama.hasan@gmailcom"
                },
                new employee
                {
                    id = 2, name = "qossay", salary = 1000, dateOfBrith = new DateTime(18 / 10 / 2000),
                    email = "qossay.zeineddin@gmail.com"
                }
            };
        }

        public static List<employee> getAllEmployee() => employeeList;
        public static employee getById(double id) => employeeList.FirstOrDefault(p => p.id == id);

        public static void add(employee employee)
        {
            employee.id = nextEmp++;
            employeeList.Add(employee);
        }

        public static void update(employee employee)
        {
            //var index = employeeList.IndexOf(employee);
            var index = employeeList.FindIndex(p => p.id == employee.id);
            if (index == -1)
                return;
            employeeList.Insert(index, employee);
        }


        public static void delete(double id)
        {
            var employee = employeeList.FirstOrDefault(p => p.id == id);
            if (employee is null) return;

            employeeList.Remove(employee);
        }
    }
}