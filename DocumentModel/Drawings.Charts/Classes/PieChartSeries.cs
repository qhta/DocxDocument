namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Pie Chart Series.
/// </summary>
public class PieChartSeries: ModelElement
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
  ///   Explosion.
  /// </summary>
  public UInt32? Explosion { get; set; }

  public Collection<DataPoint>? DataPoints { get; set; }

  public DataLabels? DataLabels { get; set; }

  public CategoryAxisData? CategoryAxisData { get; set; }

  public Values? Values { get; set; }

  public PieSerExtensionList? PieSerExtensionList { get; set; }
}