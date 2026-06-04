namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where the data label is positioned.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xldatalabelposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlDataLabelPosition))]
public enum DataLabelPosition
{
  /// <summary>
  /// Data label is positioned above the data point.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDataLabelPosition.xlLabelPositionAbove))]
  Above = 0,
  /// <summary>
  /// Data label is positioned below the data point.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDataLabelPosition.xlLabelPositionBelow))]
  Below = 1,
  /// <summary>
  /// Data label is positioned outside the data point at the top edge.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDataLabelPosition.xlLabelPositionOutsideEnd))]
  OutsideEnd = 2,
  /// <summary>
  /// Data label is positioned inside the data point at the top edge.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDataLabelPosition.xlLabelPositionInsideEnd))]
  InsideEnd = 3,
  /// <summary>
  /// Data label is positioned inside the data point at the bottom edge.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDataLabelPosition.xlLabelPositionInsideBase))]
  InsideBase = 4,
  /// <summary>
  /// 1st_Word12 sets the position of the data label.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDataLabelPosition.xlLabelPositionBestFit))]
  BestFit = 5,
  /// <summary>
  /// Data labels are in multiple positions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDataLabelPosition.xlLabelPositionMixed))]
  Mixed = 6,
  /// <summary>
  /// Data label is in a custom position.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDataLabelPosition.xlLabelPositionCustom))]
  Custom = 7,
  /// <summary>
  /// Data label is positioned to the right of the data point.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDataLabelPosition.xlLabelPositionRight))]
  Right = -4152,
  /// <summary>
  /// Data label is positioned to the left of the data point.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDataLabelPosition.xlLabelPositionLeft))]
  Left = -4131,
  /// <summary>
  /// Data label is centered on the data point or is inside a bar or pie chart.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDataLabelPosition.xlLabelPositionCenter))]
  Center = -4108
}
