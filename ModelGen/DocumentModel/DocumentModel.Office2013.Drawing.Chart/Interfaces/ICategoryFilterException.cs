namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the CategoryFilterException Class.
/// </summary>
public interface ICategoryFilterException // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public System.String? SequenceOfReferences { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public System.UInt32? Explosion { get ; set; }
  
  /// <summary>
  /// InvertIfNegativeBoolean.
  /// </summary>
  public System.Boolean? InvertIfNegativeBoolean { get ; set; }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  public System.Boolean? Bubble3D { get ; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IMarker? Marker { get ; set; }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IDataLabel? DataLabel { get ; set; }
  
}
