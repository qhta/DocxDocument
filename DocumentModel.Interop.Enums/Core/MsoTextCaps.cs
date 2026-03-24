namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the capitalization of the text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextcaps?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoTextCaps
{
  /// <summary>
  /// Specifies the capitalization of the text.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Display the text with no uppercase letters.
  /// </summary>
  NoCaps = 0,
  /// <summary>
  /// Display the text with any lowercase letters displayed as uppercase that are the same height as lowercase for
  /// the current font and size.
  /// </summary>
  SmallCaps = 1,
  /// <summary>
  /// Display the text as all uppercase letters.
  /// </summary>
  AllCaps = 2
}
