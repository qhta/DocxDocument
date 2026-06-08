namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the RadarChartSeries Class.
/// </summary>
public class RadarChartSeries: ModelElement
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
  ///   PictureOptions.
  /// </summary>
  public PictureOptions? PictureOptions { get; set; }

  /// <summary>
  ///   Marker.
  /// </summary>
  public Marker? Marker { get; set; }

  public Collection<DataPoint>? DataPoints { get; set; }

  public IDataLabels? IDataLabels { get; set; }

  public CategoryAxisData? CategoryAxisData { get; set; }

  public Values? Values { get; set; }

  public RadarSerExtensionList? RadarSerExtensionList { get; set; }
}
