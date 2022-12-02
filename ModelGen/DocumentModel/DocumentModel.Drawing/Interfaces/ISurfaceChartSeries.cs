namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SurfaceChartSeries Class.
/// </summary>
public interface ISurfaceChartSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// Order.
  /// </summary>
  public UInt32? Order { get ; set; }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public ISeriesText? SeriesText { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public IPictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// CategoryAxisData.
  /// </summary>
  public ICategoryAxisData? CategoryAxisData { get ; set; }
  
  /// <summary>
  /// Values.
  /// </summary>
  public IValues? Values { get ; set; }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  public Boolean? Bubble3D { get ; set; }
  
  /// <summary>
  /// SurfaceSerExtensionList.
  /// </summary>
  public ISurfaceSerExtensionList? SurfaceSerExtensionList { get ; set; }
  
}
