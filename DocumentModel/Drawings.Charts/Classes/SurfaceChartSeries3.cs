namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SurfaceChartSeries Class.
/// </summary>
public partial class SurfaceChartSeries3
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get; set; }
  
  /// <summary>
  /// Order.
  /// </summary>
  public UInt32? Order { get; set; }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public DocumentModel.Drawings.Charts.SeriesText? SeriesText { get; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public DocumentModel.Drawings.Charts.PictureOptions? PictureOptions { get; set; }
  
  /// <summary>
  /// CategoryAxisData.
  /// </summary>
  public DocumentModel.Drawings.Charts.CategoryAxisData? CategoryAxisData { get; set; }
  
  /// <summary>
  /// Values.
  /// </summary>
  public DocumentModel.Drawings.Charts.Values? Values { get; set; }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  public Boolean? Bubble3D { get; set; }
  
  /// <summary>
  /// SurfaceSerExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Charts.SurfaceSerExtensionList? SurfaceSerExtensionList { get; set; }
  
}
