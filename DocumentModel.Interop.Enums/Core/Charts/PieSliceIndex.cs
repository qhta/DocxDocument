
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlpiesliceindex?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlPieSliceIndex")]
public enum PieSliceIndex
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlOuterCounterClockwisePoint")]
  OuterCounterClockwisePoint = 1,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlOuterCenterPoint")]
  OuterCenterPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlOuterClockwisePoint")]
  OuterClockwisePoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlMidClockwiseRadiusPoint")]
  MidClockwiseRadiusPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlCenterPoint")]
  CenterPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlMidCounterClockwiseRadiusPoint")]
  MidCounterClockwiseRadiusPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlInnerClockwisePoint")]
  InnerClockwisePoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlInnerCenterPoint")]
  InnerCenterPoint,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlInnerCounterClockwisePoint")]
  InnerCounterClockwisePoint
}
