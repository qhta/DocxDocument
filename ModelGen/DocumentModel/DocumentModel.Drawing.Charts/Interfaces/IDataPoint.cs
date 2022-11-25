namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
public interface IDataPoint // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
  /// <summary>
  /// Invert if Negative.
  /// </summary>
  public System.Boolean? InvertIfNegative { get ; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Drawing.Charts.IMarker? Marker { get ; set; }
  
  /// <summary>
  /// 3D Bubble.
  /// </summary>
  public System.Boolean? Bubble3D { get ; set; }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public System.UInt32? Explosion { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public DocumentModel.Drawing.Charts.IPictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
