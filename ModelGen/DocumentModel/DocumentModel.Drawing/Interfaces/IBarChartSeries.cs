namespace DocumentModel.Drawing;

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
  public DocumentModel.Drawing.ISeriesText? SeriesText { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// InvertIfNegative.
  /// </summary>
  public System.Boolean? InvertIfNegative { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public DocumentModel.Drawing.IPictureOptions? PictureOptions { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDataPoint>? DataPoints { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ITrendline>? Trendlines { get ; set; }
  
  public DocumentModel.Drawing.IErrorBars? ErrorBars { get ; set; }
  
  public DocumentModel.Drawing.ICategoryAxisData? CategoryAxisData { get ; set; }
  
  public DocumentModel.Drawing.IValues? Values { get ; set; }
  
  public DocumentModel.Drawing.ShapeKind? Shape { get ; set; }
  
  public DocumentModel.Drawing.IBarSerExtensionList? BarSerExtensionList { get ; set; }
  
}
