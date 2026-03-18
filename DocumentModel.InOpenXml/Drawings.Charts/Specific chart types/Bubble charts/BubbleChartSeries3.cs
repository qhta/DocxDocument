namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series in a bubble chart, including index, order, text, shape properties, picture options, inversion, data points, labels, Trendline, error bars, values, bubble size, 3D bubbles, and extensions.
/// </summary>
public class BubbleChartSeries3
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
  ///   Indicates whether to invert colors if the value is negative.
  /// </summary>
  public bool? InvertIfNegative { get; set; }

  /// <summary>
  ///   Data points contained in the series.
  /// </summary>
  public DataPoints? DataPoints { get; set; }

  /// <summary>
  ///   Data labels configuration for the series.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Trendline associated with the series.
  /// </summary>
  public Trendline? Trendline { get; set; }

  /// <summary>
  ///   Error bars for the series.
  /// </summary>
  public ErrorBars? ErrorBars { get; set; }

  /// <summary>
  ///   X values for the bubbles in the series.
  /// </summary>
  public XValues? XValues { get; set; }

  /// <summary>
  ///   Y values for the bubbles in the series.
  /// </summary>
  public YValues? YValues { get; set; }

  /// <summary>
  ///   Size values for the bubbles in the series.
  /// </summary>
  public BubbleSize? BubbleSize { get; set; }

  /// <summary>
  ///   Indicates whether bubbles are rendered in 3D.
  /// </summary>
  public bool? Bubble3D { get; set; }

  /// <summary>
  ///   Extension list for additional series properties.
  /// </summary>
  public BubbleSerExtensionList? BubbleSerExtensionList { get; set; }
}