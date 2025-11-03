namespace TechDayKata;

/// <summary>
/// Converts decimal numbers to Roman numerals.
///
/// Roman numerals recap:
///
/// I = 1
/// V = 5
/// X = 10
/// L = 50
/// C = 100
/// D = 500
/// M = 1000
///
/// Numbers go I, II, III, IV (subtracting I from V), V etc. same for XL, CD, CM
///
/// See also https://en.wikipedia.org/wiki/Roman_numerals.
///
/// Happy Tech Day MMXXV!
///
/// </summary>
public sealed class RomanNumeralsConverter
{
    /// <summary>
    /// Converts the given <param name="decimalNumber" /> to the corresponding Roman numeral.
    /// </summary>
    /// <param name="decimalNumber">The positive (> 0) decimal number to convert to Roman numerals.</param>
    /// <returns>The Roman numeral representation of the given decimal number.</returns>
    /// <exception cref="NotImplementedException">As long as this method is not implemented by the participants.</exception>
    /// <remarks>The Roman numerals do not support 0. For simplicity, 0 is therefore ignored during the kata.</remarks>
    public string ToRomanNumerals(int decimalNumber)
    {
        return decimalNumber is 2 ? "II" : "I";
    }
}
