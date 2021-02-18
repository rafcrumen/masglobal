using model.dal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> getDataAsync();
    }
}
