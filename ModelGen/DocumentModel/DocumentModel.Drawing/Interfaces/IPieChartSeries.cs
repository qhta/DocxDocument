namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PieChartSeries Class.
/// </summary>
public interface IPieChartSeries // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// Explosion.
  /// </summary>
  public System.UInt32? Explosion { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IDataPoint>? DataPoints { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public DocumentModel.Drawing.ICategoryAxisData? CategoryAxisData { get ; set; }
  
  public DocumentModel.Drawing.IValues? Values { get ; set; }
  
  public DocumentModel.Drawing.IPieSerExtensionList? PieSerExtensionList { get ; set; }
  
}
