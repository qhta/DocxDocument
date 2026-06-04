
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlpieslicelocation?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlPieSliceLocation))]
public enum PieSliceLocation
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPieSliceLocation.xlHorizontalCoordinate))]
  HorizontalCoordinate = 1,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPieSliceLocation.xlVerticalCoordinate))]
  VerticalCoordinate
}
