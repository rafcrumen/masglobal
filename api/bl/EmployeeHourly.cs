using model.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace bl
{
    public class EmployeeHourly : IEmployee
    {
        public void setAnnualSalary(Employee employee)
        {
            employee.annualSalary = Constants.HoursPerMonth * employee.hourlySalary * Constants.MonthsPerYear;
        }
    }
}
