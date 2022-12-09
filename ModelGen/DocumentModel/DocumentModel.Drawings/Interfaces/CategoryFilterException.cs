namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CategoryFilterException Class.
/// </summary>
public interface CategoryFilterException
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public String? SequenceOfReferences { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties2? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public UInt32? Explosion { get ; set; }
  
  /// <summary>
  /// InvertIfNegativeBoolean.
  /// </summary>
  public Boolean? InvertIfNegativeBoolean { get ; set; }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  public Boolean? Bubble3D { get ; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public Marker2? Marker { get ; set; }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DataLabel3? DataLabel { get ; set; }
  
}
