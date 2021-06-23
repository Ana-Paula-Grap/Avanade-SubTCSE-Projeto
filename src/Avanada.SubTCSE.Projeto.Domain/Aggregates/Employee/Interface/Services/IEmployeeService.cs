using System.Threading.Tasks;

namespace Avanada.SubTCSE.Projeto.Domain.Aggregates.Employee.Interface.Services
{
    public interface IEmployeeService
    {
        Task<Entities.Employee> AddEmployee(Entities.Employee employee);
    }
}
