namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the capitalization of the text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextcaps?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoTextCaps))]
public enum TextCaps
{
  /// <summary>
  /// Display the text as mixed uppercase and lowercase letters.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextCaps.msoCapsMixed))]
  Mixed = -2,
  /// <summary>
  /// Display the text with no uppercase letters.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextCaps.msoNoCaps))]
  NoCaps = 0,
  /// <summary>
  /// Display the text with any lowercase letters displayed as uppercase that are the same height as lowercase for
  /// the current font and size.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextCaps.msoSmallCaps))]
  SmallCaps = 1,
  /// <summary>
  /// Display the text as all uppercase letters.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextCaps.msoAllCaps))]
  AllCaps = 2
}
