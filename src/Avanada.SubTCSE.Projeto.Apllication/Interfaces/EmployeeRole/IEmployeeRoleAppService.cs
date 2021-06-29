using Avanada.SubTCSE.Projeto.Apllication.Dtos.EmployeeRole;
using System.Threading.Tasks;

namespace Avanada.SubTCSE.Projeto.Apllication.Interfaces.EmployeeRole
{
    public interface IEmployeeRoleAppService
    {
        Task<EmployeRoleDto> AddEmployeeRole(EmployeRoleDto employeeRoleDto);
    }
}
