using Clinix.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinix.Core.Dtos.Requests
{
    public class CreateEmployeeRequestDto
    {
        public string Name { get; private set; } = string.Empty;
        public string PhoneNumber { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
    }
}
