namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SeriesElementVisibilities Class.
/// </summary>
public class SeriesElementVisibilities: ModelElement
{
  /// <summary>
  ///   connectorLines, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? ConnectorLines { get; set; }

  /// <summary>
  ///   meanLine, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? MeanLine { get; set; }

  /// <summary>
  ///   meanMarker, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? MeanMarker { get; set; }

  /// <summary>
  ///   nonoutliers, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Nonoutliers { get; set; }

  /// <summary>
  ///   outliers, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Outliers { get; set; }
}