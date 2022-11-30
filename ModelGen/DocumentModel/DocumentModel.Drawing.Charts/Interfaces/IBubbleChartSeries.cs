namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BubbleChartSeries Class.
/// </summary>
public interface IBubbleChartSeries // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// InvertIfNegative.
  /// </summary>
  public System.Boolean? InvertIfNegative { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IDataPoint>? DataPoints { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDataLabels? DataLabels { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ITrendline>? Trendlines { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IErrorBars>? ErrorBarses { get ; set; }
  
  public DocumentModel.Drawing.Charts.IXValues? XValues { get ; set; }
  
  public DocumentModel.Drawing.Charts.IYValues? YValues { get ; set; }
  
  public DocumentModel.Drawing.Charts.IBubbleSize? BubbleSize { get ; set; }
  
  public System.Boolean? Bubble3D { get ; set; }
  
  public DocumentModel.Drawing.Charts.IBubbleSerExtensionList? BubbleSerExtensionList { get ; set; }
  
}
