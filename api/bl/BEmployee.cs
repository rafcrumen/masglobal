using dal;
using Microsoft.Extensions.DependencyInjection;
using model.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace bl
{
    public class BEmployee
    {

        public BEmployee(IEmployeeRepository repo)
        {
            this.repo = repo;
        }
        private IEmployeeRepository repo;

        public Employee getEmployee(int id)
        {
            Employee employee =  this.repo.getDataAsync().Result.Find(e => e.id == id);
            if (employee != null)
            {
                setEmployee(employee);
            }
            return employee;
        }
        public List<Employee> getEmployee()
        {
            List<Employee> employees = this.repo.getDataAsync().Result;
            foreach(Employee e in employees)
            {
                setEmployee(e);
            }
            return employees;
        }
        private void setEmployee(Employee dataEmployee)
        {
            IEmployee employee;
            if (dataEmployee.contractTypeName == "HourlySalaryEmployee")
            {
                employee = new EmployeeHourly();
            }
            else
            {
                employee = new EmployeeMonthly();
            }
            employee.setAnnualSalary(dataEmployee);
        }
    }
}
