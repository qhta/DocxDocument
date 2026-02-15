namespace DocxEditor;

/// <summary>
/// Provides a validation rule that checks whether a hexadecimal binary string has an even number of characters.
/// </summary>
/// <remarks>This rule is typically used to ensure that input values representing hexadecimal binary data are
/// valid for scenarios where each byte is represented by two hexadecimal characters.
/// Whitespace in the input is ignored for the purpose of length validation.
/// If the input is null or not a string, the validation passes by default.</remarks>
public class HexBinaryEvenLengthValidationRule : ValidationRule
{
  /// <summary>
  /// Validates whether the specified value, after removing all spaces, has a length that is evenly divisible by two.
  /// </summary>
  /// <remarks>This method only applies validation logic to string values. All spaces are removed from the input
  /// before checking the length. Non-string values and null values are considered valid.</remarks>
  /// <param name="value">The value to validate. If the value is null or not a string, the validation succeeds by default.</param>
  /// <param name="cultureInfo">The culture-specific information for the validation process. This parameter is not used in the current
  /// implementation.</param>
  /// <returns>A ValidationResult that indicates whether the value is valid. Returns ValidationResult.ValidResult if the value is
  /// null, not a string, or has an even length after removing spaces; otherwise, returns a ValidationResult with an
  /// error message.</returns>
  public override ValidationResult Validate(object? value, CultureInfo cultureInfo)
  {
    if (value == null)
      return ValidationResult.ValidResult;

    if (value is not string text)
      return ValidationResult.ValidResult;

    var normalized = text.Replace(" ", string.Empty);
    return normalized.Length % 2 == 0
      ? ValidationResult.ValidResult
      : new ValidationResult(false, "Value length must be divisible by two.");
  }
}
