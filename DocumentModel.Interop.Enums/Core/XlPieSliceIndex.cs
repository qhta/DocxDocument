
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlpiesliceindex?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlPieSliceIndex))]
public enum PieSliceIndex
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPieSliceIndex.xlOuterCounterClockwisePoint))]
  OuterCounterClockwisePoint = 1,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPieSliceIndex.xlOuterCenterPoint))]
  OuterCenterPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPieSliceIndex.xlOuterClockwisePoint))]
  OuterClockwisePoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPieSliceIndex.xlMidClockwiseRadiusPoint))]
  MidClockwiseRadiusPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPieSliceIndex.xlCenterPoint))]
  CenterPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPieSliceIndex.xlMidCounterClockwiseRadiusPoint))]
  MidCounterClockwiseRadiusPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPieSliceIndex.xlInnerClockwisePoint))]
  InnerClockwisePoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPieSliceIndex.xlInnerCenterPoint))]
  InnerCenterPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPieSliceIndex.xlInnerCounterClockwisePoint))]
  InnerCounterClockwisePoint
}
