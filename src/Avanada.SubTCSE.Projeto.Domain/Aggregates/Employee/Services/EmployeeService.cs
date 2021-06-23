using Avanada.SubTCSE.Projeto.Domain.Aggregates.Employee.Interface.Services;
using System;
using System.Threading.Tasks;

namespace Avanada.SubTCSE.Projeto.Domain.Aggregates.Employee.Services
{
    public class EmployeeService : IEmployeeService

    {
        public async Task<Entities.Employee> AddEmployee(Entities.Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
