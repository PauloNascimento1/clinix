using AutoMapper;
using Clinix.Application.Dtos.Responses;
using Clinix.Core.Dtos.Requests;
using Clinix.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinix.Application.Mappings;

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<CreateEmployeeResponseDto, Employee>();
    }
}
