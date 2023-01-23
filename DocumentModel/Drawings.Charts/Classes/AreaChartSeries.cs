namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Area Chart Series.
/// </summary>
public class AreaChartSeries
{
  /// <summary>
  ///   Index.
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Order.
  /// </summary>
  public UInt32? Order { get; set; }

  /// <summary>
  ///   Series Text.
  /// </summary>
  public SeriesText? SeriesText { get; set; }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   PictureOptions.
  /// </summary>
  public PictureOptions? PictureOptions { get; set; }

  public Collection<DataPoint>? DataPoints { get; set; }

  public DataLabels? DataLabels { get; set; }

  public Collection<Trendline>? Trendlines { get; set; }

  public Collection<ErrorBars>? ErrorBars { get; set; }

  public CategoryAxisData? CategoryAxisData { get; set; }

  public Values? Values { get; set; }

  public AreaSerExtensionList? AreaSerExtensionList { get; set; }
}