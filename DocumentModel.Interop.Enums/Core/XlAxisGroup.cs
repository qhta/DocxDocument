
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of axis group.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlaxisgroup?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlAxisGroup))]
public enum AxisGroup
{
  /// <summary>
  /// Primary axis group.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlAxisGroup.xlPrimary))]
  Primary = 1,
  /// <summary>
  /// Secondary axis group.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlAxisGroup.xlSecondary))]
  Secondary
}
