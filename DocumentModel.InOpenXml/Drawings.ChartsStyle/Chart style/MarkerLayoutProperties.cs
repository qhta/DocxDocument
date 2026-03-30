using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
/// Describes the layout properties for chart markers, including symbol type and size settings.
/// </summary>
public class MarkerLayoutProperties
{
  /// <summary>
  /// Marker symbol type used for data points in the chart.
  /// </summary>
  public MarkerStyle? Symbol { get; set; }
  /// <summary>
  /// Size value for the marker symbols.
  /// </summary>
  public Byte? Size { get; set; }
}