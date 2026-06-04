namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style of the arrowhead at the end of a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoarrowheadstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoArrowheadStyle))]
public enum ArrowheadStyle
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoArrowheadStyle.msoArrowheadStyleMixed))]
  StyleMixed = -2,
  /// <summary>
  /// No arrowhead.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoArrowheadStyle.msoArrowheadNone))]
  None = 1,
  /// <summary>
  /// Triangular.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoArrowheadStyle.msoArrowheadTriangle))]
  Triangle = 2,
  /// <summary>
  /// Open.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoArrowheadStyle.msoArrowheadOpen))]
  Open = 3,
  /// <summary>
  /// Stealth-shaped.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoArrowheadStyle.msoArrowheadStealth))]
  Stealth = 4,
  /// <summary>
  /// Diamond-shaped.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoArrowheadStyle.msoArrowheadDiamond))]
  Diamond = 5,
  /// <summary>
  /// Oval-shaped.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoArrowheadStyle.msoArrowheadOval))]
  Oval = 6
}
