namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the capitalization of the text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextcaps?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoTextCaps")]
public enum TextCaps
{
  /// <summary>
  /// Display the text as mixed uppercase and lowercase letters.
  /// </summary>
  [OfficeInteropEnumValue("msoCapsMixed")]
  Mixed = -2,
  /// <summary>
  /// Display the text with no uppercase letters.
  /// </summary>
  [OfficeInteropEnumValue("msoNoCaps")]
  NoCaps = 0,
  /// <summary>
  /// Display the text with any lowercase letters displayed as uppercase that are the same height as lowercase for
  /// the current font and size.
  /// </summary>
  [OfficeInteropEnumValue("msoSmallCaps")]
  SmallCaps = 1,
  /// <summary>
  /// Display the text as all uppercase letters.
  /// </summary>
  [OfficeInteropEnumValue("msoAllCaps")]
  AllCaps = 2
}
