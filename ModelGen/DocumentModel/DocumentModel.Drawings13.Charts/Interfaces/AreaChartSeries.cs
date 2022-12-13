namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the AreaChartSeries Class.
/// </summary>
public interface AreaChartSeries
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
  public DocumentModel.Drawings.Charts.SeriesText? SeriesText { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public DocumentModel.Drawings.Charts.PictureOptions? PictureOptions { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.DataPoint>? DataPoints { get ; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.Trendline>? Trendlines { get ; set; }
  
  public DocumentModel.Drawings.Charts.ErrorBars? ErrorBars { get ; set; }
  
  public DocumentModel.Drawings.Charts.CategoryAxisData? CategoryAxisData { get ; set; }
  
  public DocumentModel.Drawings.Charts.Values? Values { get ; set; }
  
  public DocumentModel.Drawings.Charts.AreaSerExtensionList? AreaSerExtensionList { get ; set; }
  
}
