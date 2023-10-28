namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the CategoryFilterException Class.
/// </summary>
public partial class CategoryFilterException
{
  
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  public DMDC13.SequenceOfReferences? SequenceOfReferences { get; set; }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public DMDC13.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Explosion.
  /// </summary>
  public UInt32? Explosion { get; set; }
  
  
  /// <summary>
  ///   InvertIfNegativeBoolean.
  /// </summary>
  public DMDC13.InvertIfNegativeBoolean? InvertIfNegativeBoolean { get; set; }
  
  
  /// <summary>
  ///   Bubble3D.
  /// </summary>
  public DMDC13.Bubble3D? Bubble3D { get; set; }
  
  
  /// <summary>
  ///   Marker.
  /// </summary>
  public DMDC13.Marker? Marker { get; set; }
  
  
  /// <summary>
  ///   DataLabel.
  /// </summary>
  public DMDC13.DataLabel? DataLabel { get; set; }
  
}
