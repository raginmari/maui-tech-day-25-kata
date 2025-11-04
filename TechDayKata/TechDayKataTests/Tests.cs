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

    [Test]
    public void WhenGivenDecimal_3_ThenReturnsRoman_III()
    {
        var sut = new RomanNumeralsConverter();
        Assert.That(sut.ToRomanNumerals(3), Is.EqualTo("III"));
    }

    [Test]
    public void WhenGivenDecimal_4_ThenReturnsRoman_IV()
    {
        var sut = new RomanNumeralsConverter();
        Assert.That(sut.ToRomanNumerals(4), Is.EqualTo("IV"));
    }

    [Test]
    public void WhenGivenDecimal_5_ThenReturnsRoman_V()
    {
        var sut = new RomanNumeralsConverter();
        Assert.That(sut.ToRomanNumerals(5), Is.EqualTo("V"));
    }
}
