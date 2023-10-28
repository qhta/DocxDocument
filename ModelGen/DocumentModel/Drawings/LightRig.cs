namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the light rig associated with the table.  The light rig comes into play when there is a 3D bevel applied to a cell.  When 3D is used, the light rig defines the lighting properties associated with the scene.
/// </summary>
public partial class LightRig
{
  
  /// <summary>
  ///   Rotation.
  /// </summary>
  public DMD.Rotation? Rotation { get; set; }
  
}
