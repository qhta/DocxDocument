namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Surface Chart Series.
/// </summary>
public class SurfaceChartSeries: ModelElement
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
  ///   CategoryAxisData.
  /// </summary>
  public CategoryAxisData? CategoryAxisData { get; set; }

  /// <summary>
  ///   Values.
  /// </summary>
  public Values? Values { get; set; }

  /// <summary>
  ///   Bubble3D.
  /// </summary>
  public bool? Bubble3D { get; set; }

  /// <summary>
  ///   SurfaceSerExtensionList.
  /// </summary>
  public SurfaceSerExtensionList? SurfaceSerExtensionList { get; set; }
}