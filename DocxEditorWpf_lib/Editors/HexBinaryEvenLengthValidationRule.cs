using System.Globalization;
using System.Windows.Controls;

namespace DocxEditor;

public class HexBinaryEvenLengthValidationRule : ValidationRule
{
  public override ValidationResult Validate(object? value, CultureInfo cultureInfo)
  {
    if (value == null)
    {
      return ValidationResult.ValidResult;
    }

    if (value is not string text)
    {
      return ValidationResult.ValidResult;
    }

    var normalized = text.Replace(" ", string.Empty);
    return normalized.Length % 2 == 0
      ? ValidationResult.ValidResult
      : new ValidationResult(false, "Value length must be divisible by two.");
  }
}
