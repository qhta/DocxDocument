namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Surface Chart Series.
/// </summary>
public interface ISurfaceChartSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
  /// <summary>
  /// Order.
  /// </summary>
  public System.UInt32? Order { get ; set; }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public DocumentModel.Drawing.Charts.ISeriesText? SeriesText { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public DocumentModel.Drawing.Charts.IPictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// CategoryAxisData.
  /// </summary>
  public DocumentModel.Drawing.Charts.IAxisDataSourceType? CategoryAxisData { get ; set; }
  
  /// <summary>
  /// Values.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumberDataSourceType? Values { get ; set; }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  public System.Boolean? Bubble3D { get ; set; }
  
  /// <summary>
  /// SurfaceSerExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? SurfaceSerExtensionList { get ; set; }
  
}
