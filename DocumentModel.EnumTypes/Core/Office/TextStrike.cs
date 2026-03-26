namespace DocumentMode.Office;

/// <summary>
/// Indicates the number of times a character is printed to darken the image.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextstrike?view=office-pia` for Office interop details.
/// </remarks>
public enum TextStrike
{
  /// <summary>
  /// Specifies that the text can contain a combination of double-strike and single- strike characters.
  /// </summary>
  /// <summary>
  /// Specifies that the character is not printed.
  /// </summary>
  NoStrike = 0,
  /// <summary>
  /// Specifies that the character is printed once.
  /// </summary>
  SingleStrike = 1,
  /// <summary>
  /// Specifies that the character is printed twice.
  /// </summary>
  DoubleStrike = 2
}
