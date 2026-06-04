
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// position of major and minor tick marks for an axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xltickmark?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlTickMark))]
public enum TickMark
{
  /// <summary>
  /// Crosses the axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlTickMark.xlTickMarkCross))]
  Cross = 4,
  /// <summary>
  /// Inside the axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlTickMark.xlTickMarkInside))]
  Inside = 2,
  /// <summary>
  /// No mark.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlTickMark.xlTickMarkNone))]
  None = -4142,
  /// <summary>
  /// Outside the axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlTickMark.xlTickMarkOutside))]
  Outside = 3
}
