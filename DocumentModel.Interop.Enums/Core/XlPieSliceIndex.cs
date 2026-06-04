
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlpiesliceindex?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlPieSliceIndex")]
public enum PieSliceIndex
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlOuterCounterClockwisePoint")]
  OuterCounterClockwisePoint = 1,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlOuterCenterPoint")]
  OuterCenterPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlOuterClockwisePoint")]
  OuterClockwisePoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlMidClockwiseRadiusPoint")]
  MidClockwiseRadiusPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlCenterPoint")]
  CenterPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlMidCounterClockwiseRadiusPoint")]
  MidCounterClockwiseRadiusPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlInnerClockwisePoint")]
  InnerClockwisePoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlInnerCenterPoint")]
  InnerCenterPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlInnerCounterClockwisePoint")]
  InnerCounterClockwisePoint
}
