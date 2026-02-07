using AutoMapper;
using Clinix.Application.Dtos.Responses;
using Clinix.Application.Interfaces;
using Clinix.Core.Dtos.Requests;
using Clinix.Core.Entities;
using Clinix.Core.Interfaces;
using Clinix.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Clinix.Application.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }

    public async Task<CreateEmployeeResponseDto> CreateEmployeeServiceAsync(CreateEmployeeRequestDto employeeDto)
    {
        var employee = new Employee(
        employeeDto.Name,
        new PhoneNumber(employeeDto.PhoneNumber),
        new Email(employeeDto.Email),
        DateTime.UtcNow
        );

        await _employeeRepository.CreateEmployeeRepoAsync(employee);

        return _mapper.Map<CreateEmployeeResponseDto>(employee);
    }
}
