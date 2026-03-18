namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series in a pie chart, including index, order, text, shape properties, picture options, explosion, data points, labels, axis data, values, and extensions.
/// </summary>
public class PieChartSeries : CollectionItem
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
  ///   Explosion value indicating how far a slice is pulled from the pie.
  /// </summary>
  public UInt32? Explosion { get; set; }

  /// <summary>
  ///   Data points contained in the series.
  /// </summary>
  public DataPoints? DataPoints { get; set; }

  /// <summary>
  ///   Data labels configuration for the series.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Category axis data for the series.
  /// </summary>
  public CategoryAxisData? CategoryAxisData { get; set; }

  /// <summary>
  ///   Values for the series.
  /// </summary>
  public Values? Values { get; set; }

  /// <summary>
  ///   Extension list for additional series properties.
  /// </summary>
  public PieSerExtensionList? PieSerExtensionList { get; set; }
}