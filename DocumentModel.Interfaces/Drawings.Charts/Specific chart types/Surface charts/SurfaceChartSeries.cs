namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series in a surface chart, including index, order, text, shape properties, picture options, axis data, values, 3D bubble option, and extensions.
/// </summary>
public interface SurfaceChartSeries : CollectionItem
{
  /// <summary>
  ///   Index of the series within the chart.
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Order of the series in the chart.
  /// </summary>
  public UInt32? Order { get; set; }

  /// <summary>
  ///   Text or name of the series.
  /// </summary>
  public SeriesText? SeriesText { get; set; }

  /// <summary>
  ///   Shape properties for the chart series.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Picture options for the series.
  /// </summary>
  public PictureOptions? PictureOptions { get; set; }

  /// <summary>
  ///   Category axis data for the series.
  /// </summary>
  public CategoryAxisData? CategoryAxisData { get; set; }

  /// <summary>
  ///   Values for the series.
  /// </summary>
  public Values? Values { get; set; }

  /// <summary>
  ///   Indicates whether bubbles are rendered in 3D.
  /// </summary>
  public bool? Bubble3D { get; set; }

  /// <summary>
  ///   Extension list for additional series properties.
  /// </summary>
  public SurfaceSerExtensionList? SurfaceSerExtensionList { get; set; }
}