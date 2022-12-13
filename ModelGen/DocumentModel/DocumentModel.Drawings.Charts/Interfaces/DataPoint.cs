namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
public interface DataPoint
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
  public DocumentModel.Drawings.Charts.Marker? Marker { get ; set; }
  
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
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public DocumentModel.Drawings.Charts.PictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
