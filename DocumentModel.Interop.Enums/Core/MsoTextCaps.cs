namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the capitalization of the text.
/// </summary>
public enum MsoTextCaps
{
  /// <summary>
  /// Specifies the capitalization of the text.
  /// </summary>
  msoCapsMixed = -2,
  /// <summary>
  /// Display the text with no uppercase letters. msoSmallCaps1 Display the text with any lowercase letters
  /// displayed as uppercase that are the same height as lowercase for the current font and size.
  /// </summary>
  msoNoCaps = 0,
  /// <summary>
  /// Specifies the capitalization of the text.
  /// </summary>
  msoSmallCaps = 1,
  /// <summary>
  /// Display the text as all uppercase letters.
  /// </summary>
  msoAllCaps = 2
}
