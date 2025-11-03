using TechDayKata;

namespace TechDayKataTests;

public class Tests
{
    [Test]
    public void WhenGivenDecimal_1_ThenReturnsRoman_I()
    {
        var sut = new RomanNumeralsConverter();
        Assert.That(sut.ToRomanNumerals(1), Is.EqualTo("I"));
    }

    [Test]
    public void WhenGivenDecimal_2_ThenReturnsRoman_II()
    {
        var sut = new RomanNumeralsConverter();
        Assert.That(sut.ToRomanNumerals(2), Is.EqualTo("II"));
    }
}
