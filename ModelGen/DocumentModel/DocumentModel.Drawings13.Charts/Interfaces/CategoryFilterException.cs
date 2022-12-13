namespace DocumentModel.Drawings13.Charts;

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
  public DocumentModel.Drawings13.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
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
  public DocumentModel.Drawings13.Charts.Marker? Marker { get ; set; }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataLabel? DataLabel { get ; set; }
  
}
