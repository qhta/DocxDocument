namespace DocumentModel.Drawing;

/// <summary>
/// Defines the CategoryFilterException Class.
/// </summary>
public interface ICategoryFilterException // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public String? SequenceOfReferences { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
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
  public IMarker? Marker { get ; set; }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public IDataLabel? DataLabel { get ; set; }
  
}
