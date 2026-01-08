namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Describes the layout properties for chart markers, including symbol type and size settings.
/// </summary>
public interface MarkerLayoutProperties
{
  /// <summary>
  /// Marker symbol type used for data points in the chart.
  /// </summary>
  public MarkerStyleKind? Symbol { get; set; }

  /// <summary>
  /// Size value for the marker symbols.
  /// </summary>
  public Byte? Size { get; set; }
}