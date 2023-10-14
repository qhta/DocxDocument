namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the CategoryFilterException Class.
/// </summary>
public partial class CategoryFilterException
{
  
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  public DocumentModel.Drawings.Charts.SequenceOfReferences? SequenceOfReferences { get; set; }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Explosion.
  /// </summary>
  public UInt32? Explosion { get; set; }
  
  
  /// <summary>
  ///   InvertIfNegativeBoolean.
  /// </summary>
  public DocumentModel.Drawings.Charts.InvertIfNegativeBoolean? InvertIfNegativeBoolean { get; set; }
  
  
  /// <summary>
  ///   Bubble3D.
  /// </summary>
  public DocumentModel.Drawings.Charts.Bubble3D? Bubble3D { get; set; }
  
  
  /// <summary>
  ///   Marker.
  /// </summary>
  public DocumentModel.Drawings.Charts.Marker? Marker { get; set; }
  
  
  /// <summary>
  ///   DataLabel.
  /// </summary>
  public DocumentModel.Drawings.Charts.DataLabel? DataLabel { get; set; }
  
}
