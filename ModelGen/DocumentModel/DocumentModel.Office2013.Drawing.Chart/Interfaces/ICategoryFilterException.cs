namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the CategoryFilterException Class.
/// </summary>
public interface ICategoryFilterException // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public ISequenceOfReferences? SequenceOfReferences { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public IExplosion? Explosion { get ; set; }
  
  /// <summary>
  /// InvertIfNegativeBoolean.
  /// </summary>
  public InvertIfNegativeBoolean? InvertIfNegativeBoolean { get ; set; }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  public IBubble3D? Bubble3D { get ; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public IMarker? Marker { get ; set; }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public IDataLabel? DataLabel { get ; set; }
  
}
