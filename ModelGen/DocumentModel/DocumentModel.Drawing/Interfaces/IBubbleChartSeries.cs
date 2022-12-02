namespace DocumentModel.Drawing;

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
  public DocumentModel.Drawing.ISeriesText? SeriesText { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public DocumentModel.Drawing.IPictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// InvertIfNegative.
  /// </summary>
  public System.Boolean? InvertIfNegative { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDataPoint>? DataPoints { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ITrendline>? Trendlines { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IErrorBars>? ErrorBarses { get ; set; }
  
  public DocumentModel.Drawing.IXValues? XValues { get ; set; }
  
  public DocumentModel.Drawing.IYValues? YValues { get ; set; }
  
  public DocumentModel.Drawing.IBubbleSize? BubbleSize { get ; set; }
  
  public System.Boolean? Bubble3D { get ; set; }
  
  public DocumentModel.Drawing.IBubbleSerExtensionList? BubbleSerExtensionList { get ; set; }
  
}
