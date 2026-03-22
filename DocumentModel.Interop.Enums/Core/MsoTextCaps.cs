namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the capitalization of the text.
/// </summary>
public enum MsoTextCaps
{
  /// <summary>
  /// Specifies the capitalization of the text.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Display the text with no uppercase letters. msoSmallCaps1 Display the text with any lowercase letters
  /// displayed as uppercase that are the same height as lowercase for the current font and size.
  /// </summary>
  NoCaps = 0,
  /// <summary>
  /// Specifies the capitalization of the text.
  /// </summary>
  SmallCaps = 1,
  /// <summary>
  /// Display the text as all uppercase letters.
  /// </summary>
  AllCaps = 2
}
