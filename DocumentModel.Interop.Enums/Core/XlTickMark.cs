
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// position of major and minor tick marks for an axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xltickmark?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlTickMark")]
public enum TickMark
{
  /// <summary>
  /// Crosses the axis.
  /// </summary>
  [InteropEnumValue("xlTickMarkCross")]
  Cross = 4,
  /// <summary>
  /// Inside the axis.
  /// </summary>
  [InteropEnumValue("xlTickMarkInside")]
  Inside = 2,
  /// <summary>
  /// No mark.
  /// </summary>
  [InteropEnumValue("xlTickMarkNone")]
  None = -4142,
  /// <summary>
  /// Outside the axis.
  /// </summary>
  [InteropEnumValue("xlTickMarkOutside")]
  Outside = 3
}
