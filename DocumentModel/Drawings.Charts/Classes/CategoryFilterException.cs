namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the CategoryFilterException Class.
/// </summary>
public partial class CategoryFilterException
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public String? SequenceOfReferences { get; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShapeProperties3? ShapeProperties { get; set; }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public UInt32? Explosion { get; set; }
  
  /// <summary>
  /// InvertIfNegativeBoolean.
  /// </summary>
  public Boolean? InvertIfNegativeBoolean { get; set; }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  public Boolean? Bubble3D { get; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Drawings.Charts.Marker3? Marker { get; set; }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DocumentModel.Drawings.Charts.DataLabel3? DataLabel { get; set; }
  
}
