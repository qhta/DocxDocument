namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of the legend on a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xllegendposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlLegendPosition))]
public enum LegendPosition
{
  /// <summary>
  /// In the upper right-hand corner of the chart border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLegendPosition.xlLegendPositionCorner))]
  Corner = 2,
  /// <summary>
  /// A custom position.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLegendPosition.xlLegendPositionCustom))]
  Custom = -4161,
  /// <summary>
  /// Above the chart.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLegendPosition.xlLegendPositionTop))]
  Top = -4160,
  /// <summary>
  /// Right of the chart.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLegendPosition.xlLegendPositionRight))]
  Right = -4152,
  /// <summary>
  /// Left of the chart.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLegendPosition.xlLegendPositionLeft))]
  Left = -4131,
  /// <summary>
  /// Below the chart.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLegendPosition.xlLegendPositionBottom))]
  Bottom = -4107
}
