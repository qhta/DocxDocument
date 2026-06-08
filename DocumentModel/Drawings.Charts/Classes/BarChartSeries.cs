namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Bar IChart ISeries.
/// </summary>
public class BarChartSeries: ModelElement
{
  /// <summary>
  ///   IIndex.
  /// </summary>
  public UInt32? IIndex { get; set; }

  /// <summary>
  ///   Order.
  /// </summary>
  public UInt32? Order { get; set; }

  /// <summary>
  ///   ISeries Text.
  /// </summary>
  public SeriesText? SeriesText { get; set; }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   InvertIfNegative.
  /// </summary>
  public bool? InvertIfNegative { get; set; }

  /// <summary>
  ///   PictureOptions.
  /// </summary>
  public PictureOptions? PictureOptions { get; set; }

  public Collection<DataPoint>? DataPoints { get; set; }

  public IDataLabels? IDataLabels { get; set; }

  public Collection<ITrendline>? ITrendlines { get; set; }

  public IErrorBars? IErrorBars { get; set; }

  public CategoryAxisData? CategoryAxisData { get; set; }

  public Values? Values { get; set; }

  public ShapeKind? IShape { get; set; }

  public BarSerExtensionList? BarSerExtensionList { get; set; }
}
