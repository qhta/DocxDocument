
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// position of the legend on a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xllegendposition?view=office-pia` for Office interop details.
/// </remarks>
public enum XlLegendPosition
{
  /// <summary>
  /// Below the chart.
  /// </summary>
  Bottom = -4107,
  /// <summary>
  /// In the upper right-hand corner of the chart border.
  /// </summary>
  Corner = 2,
  /// <summary>
  /// Left of the chart.
  /// </summary>
  Left = -4131,
  /// <summary>
  /// Right of the chart.
  /// </summary>
  Right = -4152,
  /// <summary>
  /// Above the chart.
  /// </summary>
  Top = -4160,
  /// <summary>
  /// A custom position.
  /// </summary>
  Custom = -4161
}
