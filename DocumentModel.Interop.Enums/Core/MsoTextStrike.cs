namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the number of times a character is printed to darken the image.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextstrike?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoTextStrike))]
public enum TextStrike
{
  /// <summary>
  /// Specifies that the text can contain a combination of double-strike and single- strike characters.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextStrike.msoStrikeMixed))]
  Mixed = -2,
  /// <summary>
  /// Specifies that the character is not printed.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextStrike.msoNoStrike))]
  NoStrike = 0,
  /// <summary>
  /// Specifies that the character is printed once.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextStrike.msoSingleStrike))]
  SingleStrike = 1,
  /// <summary>
  /// Specifies that the character is printed twice.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextStrike.msoDoubleStrike))]
  DoubleStrike = 2
}
