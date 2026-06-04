namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style of the arrowhead at the end of a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoarrowheadstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoArrowheadStyle")]
public enum ArrowheadStyle
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [InteropEnumValue("msoArrowheadStyleMixed")]
  StyleMixed = -2,
  /// <summary>
  /// No arrowhead.
  /// </summary>
  [InteropEnumValue("msoArrowheadNone")]
  None = 1,
  /// <summary>
  /// Triangular.
  /// </summary>
  [InteropEnumValue("msoArrowheadTriangle")]
  Triangle = 2,
  /// <summary>
  /// Open.
  /// </summary>
  [InteropEnumValue("msoArrowheadOpen")]
  Open = 3,
  /// <summary>
  /// Stealth-shaped.
  /// </summary>
  [InteropEnumValue("msoArrowheadStealth")]
  Stealth = 4,
  /// <summary>
  /// Diamond-shaped.
  /// </summary>
  [InteropEnumValue("msoArrowheadDiamond")]
  Diamond = 5,
  /// <summary>
  /// Oval-shaped.
  /// </summary>
  [InteropEnumValue("msoArrowheadOval")]
  Oval = 6
}
