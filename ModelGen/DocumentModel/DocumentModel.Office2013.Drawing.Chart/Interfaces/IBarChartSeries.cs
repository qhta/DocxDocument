namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the BarChartSeries Class.
/// </summary>
public interface IBarChartSeries // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// InvertIfNegative.
  /// </summary>
  public System.Boolean? InvertIfNegative { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public DocumentModel.Drawing.Charts.IPictureOptions? PictureOptions { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IDataPoint>? DataPoints { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDataLabels? DataLabels { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ITrendline>? Trendlines { get ; set; }
  
  public DocumentModel.Drawing.Charts.IErrorBars? ErrorBars { get ; set; }
  
  public DocumentModel.Drawing.Charts.ICategoryAxisData? CategoryAxisData { get ; set; }
  
  public DocumentModel.Drawing.Charts.IValues? Values { get ; set; }
  
  public DocumentModel.Drawing.Charts.ShapeKind? Shape { get ; set; }
  
  public DocumentModel.Drawing.Charts.IBarSerExtensionList? BarSerExtensionList { get ; set; }
  
}
