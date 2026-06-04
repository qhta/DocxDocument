namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of the legend on a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xllegendposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlLegendPosition")]
public enum LegendPosition
{
  /// <summary>
  /// In the upper right-hand corner of the chart border.
  /// </summary>
  [WordInteropEnumValue("xlLegendPositionCorner")]
  Corner = 2,
  /// <summary>
  /// A custom position.
  /// </summary>
  [WordInteropEnumValue("xlLegendPositionCustom")]
  Custom = -4161,
  /// <summary>
  /// Above the chart.
  /// </summary>
  [WordInteropEnumValue("xlLegendPositionTop")]
  Top = -4160,
  /// <summary>
  /// Right of the chart.
  /// </summary>
  [WordInteropEnumValue("xlLegendPositionRight")]
  Right = -4152,
  /// <summary>
  /// Left of the chart.
  /// </summary>
  [WordInteropEnumValue("xlLegendPositionLeft")]
  Left = -4131,
  /// <summary>
  /// Below the chart.
  /// </summary>
  [WordInteropEnumValue("xlLegendPositionBottom")]
  Bottom = -4107
}
