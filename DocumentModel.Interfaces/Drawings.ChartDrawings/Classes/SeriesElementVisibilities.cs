namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the SeriesElementVisibilities Class.
/// </summary>
public interface SeriesElementVisibilities:
{
  /// <summary>
  ///   connectorLines
  /// </summary>
  public bool? ConnectorLines { get; set; }
  /// <summary>
  ///   meanLine
  /// </summary>
  public bool? MeanLine { get; set; }
  /// <summary>
  ///   meanMarker
  /// </summary>
  public bool? MeanMarker { get; set; }
  /// <summary>
  ///   nonoutliers
  /// </summary>
  public bool? Nonoutliers { get; set; }
  /// <summary>
  ///   outliers
  /// </summary>
  public bool? Outliers { get; set; }
}