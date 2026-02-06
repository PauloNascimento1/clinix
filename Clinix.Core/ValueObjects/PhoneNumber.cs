using System;

namespace Clinix.Core.ValueObjects;

public sealed class PhoneNumber
{
    public PhoneNumber(string number)
    {
        if (!IsValid(number))
            throw new ArgumentException("Telefone inválido!");

        Number = Normalize(number);
    }

    public string Number { get; }

    private string Normalize(string number)
    => new string(number.Where(char.IsDigit).ToArray());

    private static bool IsValid(string number)
    {
        if (string.IsNullOrWhiteSpace(number))
            return false;

        return true;
    }
}
