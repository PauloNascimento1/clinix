using Clinix.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinix.Core.Entities;

public class Employee : EntityBase
{
    public Employee(string name, PhoneNumber phoneNumber, Email email)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
        Email = email ?? throw new ArgumentNullException(nameof(email));
    }

    public string Name { get; private set; } = string.Empty;
    public PhoneNumber PhoneNumber { get; private set; }
    public Email Email { get; private set; }
}
