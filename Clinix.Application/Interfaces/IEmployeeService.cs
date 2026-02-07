using Clinix.Application.Dtos.Responses;
using Clinix.Core.Dtos.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinix.Application.Interfaces;

public interface IEmployeeService
{
    Task<CreateEmployeeResponseDto> CreateEmployeeServiceAsync(CreateEmployeeRequestDto employee);
}
