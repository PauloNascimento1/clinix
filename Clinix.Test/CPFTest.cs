namespace Clinix.Test;

public class CPFTest
{
    [Fact]
    public void Constructor_WhenCpfIsNull_ShouldThrowArgumentNullException()
    {
        string value = "";

        Assert.Throws<ArgumentException>(() =>
            new CPF(value)
        );
    }

    [Fact]
    public void Constructor_WhenCpfInvalidLength_ShouldThrowArgumentNullException()
    {
        string value = "1234567890";

        Assert.Throws<ArgumentException>(() =>
            new CPF(value)
        );
    }
}
