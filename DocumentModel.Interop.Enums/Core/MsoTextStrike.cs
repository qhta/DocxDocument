namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the number of times a character is printed to darken the image.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextstrike?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoTextStrike
{
  /// <summary>
  /// Indicates the number of times a character is printed to darken the image.
  /// </summary>
  Mixed = -2,
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
