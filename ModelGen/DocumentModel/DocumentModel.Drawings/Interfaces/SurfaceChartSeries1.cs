namespace DocumentModel.Drawings;

/// <summary>
/// Surface Chart Series.
/// </summary>
public interface SurfaceChartSeries1
{
  /// <summary>
  /// Series Text.
  /// </summary>
  public SeriesText? SeriesText { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public PictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// CategoryAxisData.
  /// </summary>
  public CategoryAxisData? CategoryAxisData { get ; set; }
  
  /// <summary>
  /// Values.
  /// </summary>
  public Values? Values { get ; set; }
  
  /// <summary>
  /// SurfaceSerExtensionList.
  /// </summary>
  public SurfaceSerExtensionList? SurfaceSerExtensionList { get ; set; }
  
}
