
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// position of major and minor tick marks for an axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xltickmark?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlTickMark")]
public enum TickMark
{
  /// <summary>
  /// Crosses the axis.
  /// </summary>
  [OfficeInteropEnumValue("xlTickMarkCross")]
  Cross = 4,
  /// <summary>
  /// Inside the axis.
  /// </summary>
  [OfficeInteropEnumValue("xlTickMarkInside")]
  Inside = 2,
  /// <summary>
  /// No mark.
  /// </summary>
  [OfficeInteropEnumValue("xlTickMarkNone")]
  None = -4142,
  /// <summary>
  /// Outside the axis.
  /// </summary>
  [OfficeInteropEnumValue("xlTickMarkOutside")]
  Outside = 3
}
