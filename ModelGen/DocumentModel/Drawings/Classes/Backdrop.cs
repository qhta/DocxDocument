namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a plane in which effects, such as glow and shadow, are applied in relation to the shape they are being applied to.  The points and vectors contained within the backdrop define a plane in 3D space.
/// </summary>
public partial class Backdrop
{
  
  /// <summary>
  ///   Anchor Point.
  /// </summary>
  public DocumentModel.Drawings.Anchor? Anchor { get; set; }
  
  
  /// <summary>
  ///   Normal.
  /// </summary>
  public DocumentModel.Drawings.Vector3DType? Normal { get; set; }
  
  
  /// <summary>
  ///   Up Vector.
  /// </summary>
  public DocumentModel.Drawings.Vector3DType? UpVector { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
