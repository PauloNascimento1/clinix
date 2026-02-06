
public sealed class CPF
{
    public string Value { get; }

    public CPF(string value)
    {
        if (!IsValid(value))
            throw new ArgumentException("Invalid CPF");

        Value = Normalize(value);
    }

    private static string Normalize(string cpf)
        => new string(cpf.Where(char.IsDigit).ToArray());

    private static bool IsValid(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
            return false;

        cpf = Normalize(cpf);

        if (!HasValidLength(cpf))
            return false;

        if (HasAllSameDigits(cpf))
            return false;

        return HasValidCheckDigits(cpf);
    }

    private static bool HasValidLength(string cpf)
        => cpf.Length == 11;

    private static bool HasAllSameDigits(string cpf)
        => cpf.All(c => c == cpf[0]);

    private static bool HasValidCheckDigits(string cpf)
    {
        int firstCheckDigit = CalculateCheckDigit(cpf, 9, 10);
        int secondCheckDigit = CalculateCheckDigit(cpf, 10, 11);

        return cpf[9] - '0' == firstCheckDigit &&
               cpf[10] - '0' == secondCheckDigit;
    }

    private static int CalculateCheckDigit(string cpf, int length, int weightStart)
    {
        int sum = 0;

        for (int i = 0; i < length; i++)
            sum += (cpf[i] - '0') * (weightStart - i);

        int remainder = sum % 11;
        return remainder < 2 ? 0 : 11 - remainder;
    }

    public override bool Equals(object obj)
        => obj is CPF other && Value == other.Value;

    public override int GetHashCode()
        => Value.GetHashCode();

    public override string ToString()
        => Value;
}