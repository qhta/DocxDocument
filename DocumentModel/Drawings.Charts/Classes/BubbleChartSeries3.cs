namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BubbleChartSeries Class.
/// </summary>
public class BubbleChartSeries3: ModelElement
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

  /// <summary>
  ///   InvertIfNegative.
  /// </summary>
  public bool? InvertIfNegative { get; set; }

  public Collection<DataPoint>? DataPoints { get; set; }

  public DataLabels? DataLabels { get; set; }

  public Collection<Trendline>? Trendlines { get; set; }

  public Collection<ErrorBars>? ErrorBars { get; set; }

  public XValues? XValues { get; set; }

  public YValues? YValues { get; set; }

  public BubbleSize? BubbleSize { get; set; }

  public bool? Bubble3D { get; set; }

  public BubbleSerExtensionList? BubbleSerExtensionList { get; set; }
}