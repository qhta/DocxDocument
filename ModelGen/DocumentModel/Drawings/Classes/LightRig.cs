namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the light rig associated with the table.  The light rig comes into play when there is a 3D bevel applied to a cell.  When 3D is used, the light rig defines the lighting properties associated with the scene.
/// </summary>
public partial class LightRig
{
  
  /// <summary>
  ///   Defines the preset type of light rig which is to be applied to the scene.
  /// </summary>
  public DocumentModel.Drawings.LightRigKind? Rig { get; set; }
  
  
  /// <summary>
  ///   Defines the direction from which the light rig is oriented in relation to the scene.
  /// </summary>
  public DocumentModel.Drawings.LightRigDirectionKind? Direction { get; set; }
  
  
  /// <summary>
  ///   Rotation.
  /// </summary>
  public DocumentModel.Drawings.Rotation? Rotation { get; set; }
  
}
