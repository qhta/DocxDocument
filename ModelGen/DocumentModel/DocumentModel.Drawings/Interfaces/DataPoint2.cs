namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
public interface DataPoint2
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// Invert if Negative.
  /// </summary>
  public Boolean? InvertIfNegative { get ; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public Marker1? Marker { get ; set; }
  
  /// <summary>
  /// 3D Bubble.
  /// </summary>
  public Boolean? Bubble3D { get ; set; }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public UInt32? Explosion { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public PictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList { get ; set; }
  
}
