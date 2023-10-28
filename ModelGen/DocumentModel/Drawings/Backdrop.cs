namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a plane in which effects, such as glow and shadow, are applied in relation to the shape they are being applied to.  The points and vectors contained within the backdrop define a plane in 3D space.
/// </summary>
public partial class Backdrop
{
  
  /// <summary>
  ///   Anchor Point.
  /// </summary>
  public DMD.Anchor? Anchor { get; set; }
  
  
  /// <summary>
  ///   Normal.
  /// </summary>
  public DMD.Normal? Normal { get; set; }
  
  
  /// <summary>
  ///   Up Vector.
  /// </summary>
  public DMD.UpVector? UpVector { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
