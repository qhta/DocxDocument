namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
public interface IDataPoint // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public Index? Index { get ; set; }
  
  /// <summary>
  /// Invert if Negative.
  /// </summary>
  public InvertIfNegative? InvertIfNegative { get ; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public IMarker? Marker { get ; set; }
  
  /// <summary>
  /// 3D Bubble.
  /// </summary>
  public IBubble3D? Bubble3D { get ; set; }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public IExplosion? Explosion { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public IPictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
