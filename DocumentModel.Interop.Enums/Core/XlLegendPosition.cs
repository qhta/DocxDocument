
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// position of the legend on a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xllegendposition?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlLegendPosition")]
public enum LegendPosition
{
  /// <summary>
  /// Below the chart.
  /// </summary>
  [InteropEnumValue("xlLegendPositionBottom")]
  Bottom = -4107,
  /// <summary>
  /// In the upper right-hand corner of the chart border.
  /// </summary>
  [InteropEnumValue("xlLegendPositionCorner")]
  Corner = 2,
  /// <summary>
  /// Left of the chart.
  /// </summary>
  [InteropEnumValue("xlLegendPositionLeft")]
  Left = -4131,
  /// <summary>
  /// Right of the chart.
  /// </summary>
  [InteropEnumValue("xlLegendPositionRight")]
  Right = -4152,
  /// <summary>
  /// Above the chart.
  /// </summary>
  [InteropEnumValue("xlLegendPositionTop")]
  Top = -4160,
  /// <summary>
  /// A custom position.
  /// </summary>
  [InteropEnumValue("xlLegendPositionCustom")]
  Custom = -4161
}
