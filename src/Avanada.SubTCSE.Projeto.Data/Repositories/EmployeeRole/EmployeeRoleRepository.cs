using Avanada.SubTCSE.Projeto.Data.Repositories.Base;
using Avanada.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository;
using System.Threading.Tasks;

namespace Avanada.SubTCSE.Projeto.Data.Repositories.EmployeeRole
{
    public class EmployeeRoleRepository 
        : BaseRepository<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, string>
        ,IEmployeeRoleRepository
    {
        public override Task<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole> Add(Domain.Aggregates.EmployeeRole.Entities.EmployeeRole entity)
        {
            return base.Add(entity);
        }
    }
}
