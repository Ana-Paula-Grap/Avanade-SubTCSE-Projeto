using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanada.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole

    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public string Id { get; set; }

        public string  RoleName { get; init; }
    }
}
