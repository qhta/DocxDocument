namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the number of times a character is printed to darken the image.
/// </summary>
public enum MsoTextStrike
{
  /// <summary>
  /// Indicates the number of times a character is printed to darken the image.
  /// </summary>
  msoStrikeMixed = -2,
  /// <summary>
  /// Specifies that the character is not printed.
  /// </summary>
  msoNoStrike = 0,
  /// <summary>
  /// Specifies that the character is printed once.
  /// </summary>
  msoSingleStrike = 1,
  /// <summary>
  /// Specifies that the character is printed twice.
  /// </summary>
  msoDoubleStrike = 2
}
