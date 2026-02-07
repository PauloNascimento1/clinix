using Clinix.Core.Dtos.Requests;
using Clinix.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinix.Core.Interfaces;

public interface IEmployeeRepository
{
    Task<Employee> CreateEmployee(Employee employee);
}
