using Clinix.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinix.Application.Dtos.Responses;

public class CreateEmployeeResponseDto
{
    public string Name { get; private set; } = string.Empty;
    public PhoneNumber PhoneNumber { get; private set; }
    public Email Email { get; private set; }
}
