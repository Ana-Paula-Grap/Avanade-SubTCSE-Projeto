using System.Threading.Tasks;

namespace Avanada.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository
{
    public interface IEmployeeRoleRepository
    {
        Task<Entities.EmployeeRole> AddEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
