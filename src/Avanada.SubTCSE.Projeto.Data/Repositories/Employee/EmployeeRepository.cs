using Avanada.SubTCSE.Projeto.Data.Repositories.Base;
using Avanada.SubTCSE.Projeto.Domain.Aggregates.Employee.Interface.Repositories;

namespace Avanada.SubTCSE.Projeto.Data.Repositories.Employee
{
    public class EmployeeRepository
        : BaseRepository<Domain.Aggregates.Employee.Entities.Employee, string>
        , IEmployeeRepository
    {

    }
}
