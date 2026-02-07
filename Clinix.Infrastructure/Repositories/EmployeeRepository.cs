using Clinix.Core.Entities;
using Clinix.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinix.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<Employee> CreateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
