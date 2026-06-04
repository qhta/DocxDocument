namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of tick-mark labels on the specified axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlticklabelposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlTickLabelPosition))]
public enum TickLabelPosition
{
  /// <summary>
  /// Next to axis (where axis is not at either side of the chart).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTickLabelPosition.xlTickLabelPositionNextToAxis))]
  NextToAxis = 4,
  /// <summary>
  /// No tick marks.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTickLabelPosition.xlTickLabelPositionNone))]
  None = -4142,
  /// <summary>
  /// Bottom or left side of the chart.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTickLabelPosition.xlTickLabelPositionLow))]
  Low = -4134,
  /// <summary>
  /// Top or right side of the chart.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTickLabelPosition.xlTickLabelPositionHigh))]
  High = -4127
}
