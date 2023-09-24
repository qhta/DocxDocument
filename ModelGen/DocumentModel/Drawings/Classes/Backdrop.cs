namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a plane in which effects, such as glow and shadow, are applied in relation to the shape they are being applied to.  The points and vectors contained within the backdrop define a plane in 3D space.
/// </summary>
public partial class Backdrop
{
  
  /// <summary>
  ///   Anchor Point.
  /// </summary>
  public Anchor? Anchor { get; set; }
  
  
  /// <summary>
  ///   Normal.
  /// </summary>
  public Vector3DType? Normal { get; set; }
  
  
  /// <summary>
  ///   Up Vector.
  /// </summary>
  public Vector3DType? UpVector { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
  
}
