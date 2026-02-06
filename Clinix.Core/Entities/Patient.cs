using Clinix.Core.ValueObjects;
using System;


namespace Clinix.Core.Entities;

public class Patient : EntityBase
{
    public Patient(string name, CPF cpf, PhoneNumber phoneNumber, Email email)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        CPF = cpf ?? throw new ArgumentNullException(nameof(cpf));
        PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
        Email = email ?? throw new ArgumentNullException(nameof(email));
    }

    public string Name { get; private set; } = string.Empty;
    public CPF CPF { get; private set; }
    public PhoneNumber PhoneNumber { get; private set; }
    public Email Email { get; private set; }
}
