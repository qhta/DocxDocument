namespace DocumentModel.Drawings;

/// <summary>
/// Pie Chart Series.
/// </summary>
public interface PieChartSeries1
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
  
  public DataLabels1? DataLabels { get ; set; }
  
  public CategoryAxisData? CategoryAxisData { get ; set; }
  
  public Values? Values { get ; set; }
  
  public PieSerExtensionList? PieSerExtensionList { get ; set; }
  
}
