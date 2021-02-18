using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using model.dal;
using System.Threading.Tasks;

namespace dal
{
    public class EmployeeRepository: IEmployeeRepository
    {
        public EmployeeRepository() { }
        public async Task<List<Employee>> getDataAsync()
        {
            List<Employee> result = new List<Employee>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(EndPoint.url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<List<Employee>>(apiResponse);
                }
            }
            return result;
        }
    }
}
