using Avanada.SubTCSE.Projeto.Apllication.Dtos.Base;
using System;

namespace Avanada.SubTCSE.Projeto.Apllication.Dtos.Employee
{
    public class EmployeeDto : BaseDto
    {
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Aniversario { get; set; }
        public bool Ativo { get; set; }
        public decimal Salario { get; set; }
        public EmployeeRole.EmployeRoleDto Cargo { get; set; }
    }
}
