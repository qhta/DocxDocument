namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ScatterChartSeries Class.
/// </summary>
public interface IScatterChartSeries // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// Marker.
  /// </summary>
  public DocumentModel.Drawing.IMarker? Marker { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDataPoint>? DataPoints { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ITrendline>? Trendlines { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IErrorBars>? ErrorBarses { get ; set; }
  
  public DocumentModel.Drawing.IXValues? XValues { get ; set; }
  
  public DocumentModel.Drawing.IYValues? YValues { get ; set; }
  
  public System.Boolean? Smooth { get ; set; }
  
  public DocumentModel.Drawing.IScatterSerExtensionList? ScatterSerExtensionList { get ; set; }
  
}
