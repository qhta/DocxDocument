namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the style of the arrowhead at the end of a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoarrowheadstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoArrowheadStyle")]
public enum ArrowheadStyle
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue("msoArrowheadStyleMixed")]
  StyleMixed = -2,
  /// <summary>
  /// No arrowhead.
  /// </summary>
  [OfficeInteropEnumValue("msoArrowheadNone")]
  None = 1,
  /// <summary>
  /// Triangular.
  /// </summary>
  [OfficeInteropEnumValue("msoArrowheadTriangle")]
  Triangle = 2,
  /// <summary>
  /// Open.
  /// </summary>
  [OfficeInteropEnumValue("msoArrowheadOpen")]
  Open = 3,
  /// <summary>
  /// Stealth-shaped.
  /// </summary>
  [OfficeInteropEnumValue("msoArrowheadStealth")]
  Stealth = 4,
  /// <summary>
  /// Diamond-shaped.
  /// </summary>
  [OfficeInteropEnumValue("msoArrowheadDiamond")]
  Diamond = 5,
  /// <summary>
  /// Oval-shaped.
  /// </summary>
  [OfficeInteropEnumValue("msoArrowheadOval")]
  Oval = 6
}
