namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of tick-mark labels on the specified axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlticklabelposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlTickLabelPosition")]
public enum TickLabelPosition
{
  /// <summary>
  /// Next to axis (where axis is not at either side of the chart).
  /// </summary>
  [WordInteropEnumValue("xlTickLabelPositionNextToAxis")]
  NextToAxis = 4,
  /// <summary>
  /// No tick marks.
  /// </summary>
  [WordInteropEnumValue("xlTickLabelPositionNone")]
  None = -4142,
  /// <summary>
  /// Bottom or left side of the chart.
  /// </summary>
  [WordInteropEnumValue("xlTickLabelPositionLow")]
  Low = -4134,
  /// <summary>
  /// Top or right side of the chart.
  /// </summary>
  [WordInteropEnumValue("xlTickLabelPositionHigh")]
  High = -4127
}
