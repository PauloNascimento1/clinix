using System;
using System.Net.Mail;

namespace Clinix.Core.ValueObjects;

public class Email
{
    

    public string Value { get; }

    public Email(string value)
    {
        if (!IsValid(value))
            throw new ArgumentException("E-mail inválido!");

        Value = value;
    }

    private static bool IsValid(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return false;

        try
        {
            var email = new MailAddress(value);
            return email.Address == value;
        }
        catch
        {
            return false;
        }
    }
}
