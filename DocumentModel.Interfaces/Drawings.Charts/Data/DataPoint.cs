namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a data point in a chart series.
///   A data point defines the value, formatting, and visual properties for a single entry in a chart, such as a bar, line, or marker.
///   This interface allows configuration of index, marker, shape, and additional options for each data point.
/// </summary>
public interface DataPoint: CollectionItem
{
  /// <summary>
  ///   Index of the data point within the series or collection.
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Indicates whether the data point should be inverted if its value is negative.
  /// </summary>
  public bool? InvertIfNegative { get; set; }

  /// <summary>
  ///   Marker configuration for the data point, used in line and scatter charts.
  /// </summary>
  public Marker? Marker { get; set; }

  /// <summary>
  ///   Indicates whether the data point is rendered as a 3D bubble (for bubble charts).
  /// </summary>
  public bool? Bubble3D { get; set; }

  /// <summary>
  ///   Explosion value for the data point, used in pie and doughnut charts to separate the slice.
  /// </summary>
  public UInt32? Explosion { get; set; }

  /// <summary>
  ///   Visual and shape properties for the data point.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Picture options for the data point, such as fill or image settings.
  /// </summary>
  public PictureOptions? PictureOptions { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional data point customization.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}