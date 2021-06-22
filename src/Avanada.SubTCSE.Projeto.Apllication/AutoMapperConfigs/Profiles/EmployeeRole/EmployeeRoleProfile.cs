using AutoMapper;

namespace Avanada.SubTCSE.Projeto.Apllication.AutoMapperConfigs.Profiles.EmployeeRole
{
    public class EmployeeRoleProfile : Profile
    {
        public EmployeeRoleProfile()
        {
           CreateMap<Dtos.EmployeeRole.EmployeRoleDto, Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParm("roleName", IMappingOperationOptions => IMappingOperationOptions.M)
        }
    }
}
