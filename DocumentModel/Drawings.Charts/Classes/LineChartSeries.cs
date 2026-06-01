namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the LineChartSeries Class.
/// </summary>
public class LineChartSeries: ModelElement
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
  ///   Marker.
  /// </summary>
  public Marker? Marker { get; set; }

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

  public bool? Smooth { get; set; }

  public LineSerExtensionList? LineSerExtensionList { get; set; }
}
