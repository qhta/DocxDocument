
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Indicates the
/// position of data labels relative to the data markers.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xldatalabelposition?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlDataLabelPosition))]
public enum DataLabelPosition
{
  /// <summary>
  /// Data label centered on data point or inside bar or pie.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDataLabelPosition.xlLabelPositionCenter))]
  Center = -4108,
  /// <summary>
  /// Data label positioned above point.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDataLabelPosition.xlLabelPositionAbove))]
  Above = 0,
  /// <summary>
  /// Data label positioned below point.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDataLabelPosition.xlLabelPositionBelow))]
  Below = 1,
  /// <summary>
  /// Data label positioned at bottom of bar or pie.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDataLabelPosition.xlLabelPositionLeft))]
  Left = -4131,
  /// <summary>
  /// Data label positioned at top of bar or pie.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDataLabelPosition.xlLabelPositionRight))]
  Right = -4152,
  /// <summary>
  /// Data label positioned at top of bar or pie.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDataLabelPosition.xlLabelPositionOutsideEnd))]
  OutsideEnd = 2,
  /// <summary>
  /// Data label positioned arbitrarily.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDataLabelPosition.xlLabelPositionInsideEnd))]
  InsideEnd = 3,
  /// <summary>
  /// Data label positioned arbitrarily.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDataLabelPosition.xlLabelPositionInsideBase))]
  InsideBase = 4,
  /// <summary>
  /// Office application controls position of data label.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDataLabelPosition.xlLabelPositionBestFit))]
  BestFit = 5,
  /// <summary>
  /// Data label positioned at bottom of bar or pie.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDataLabelPosition.xlLabelPositionMixed))]
  Mixed = 6,
  /// <summary>
  /// Data label centered on data point or inside bar or pie.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlDataLabelPosition.xlLabelPositionCustom))]
  Custom = 7
}
