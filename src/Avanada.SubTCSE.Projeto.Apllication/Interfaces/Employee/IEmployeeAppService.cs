using Avanada.SubTCSE.Projeto.Apllication.Dtos.Employee;
using System.Threading.Tasks;

namespace Avanada.SubTCSE.Projeto.Apllication.Interfaces.Employee
{
    public interface IEmployeeAppService
    {
        Task<EmployeeDto> AddEmployee(EmployeeDto employeeDto);
    }
}
