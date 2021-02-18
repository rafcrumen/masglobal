using model.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace bl
{
    public class EmployeeMonthly : IEmployee
    {
        public void setAnnualSalary(Employee employee)
        {
            employee.annualSalary = Constants.MonthsPerYear * employee.monthlySalary;
        }
    }
}
