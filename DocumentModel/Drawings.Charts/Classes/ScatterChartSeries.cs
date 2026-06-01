namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ScatterChartSeries Class.
/// </summary>
public class ScatterChartSeries: ModelElement
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

  public Collection<DataPoint>? DataPoints { get; set; }

  public IDataLabels? IDataLabels { get; set; }

  public Collection<ITrendline>? ITrendlines { get; set; }

  public Collection<IErrorBars>? IErrorBars { get; set; }

  public XValues? XValues { get; set; }

  public YValues? YValues { get; set; }

  public bool? Smooth { get; set; }

  public ScatterSerExtensionList? ScatterSerExtensionList { get; set; }
}
