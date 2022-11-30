namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the AreaChartSeries Class.
/// </summary>
public interface IAreaChartSeries // : DocumentModel.ITypedOpenXmlCompositeElement
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
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IDataPoint>? DataPoints { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDataLabels? DataLabels { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ITrendline>? Trendlines { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IErrorBars>? ErrorBarses { get ; set; }
  
  public DocumentModel.Drawing.Charts.ICategoryAxisData? CategoryAxisData { get ; set; }
  
  public DocumentModel.Drawing.Charts.IValues? Values { get ; set; }
  
  public DocumentModel.Drawing.Charts.IAreaSerExtensionList? AreaSerExtensionList { get ; set; }
  
}
