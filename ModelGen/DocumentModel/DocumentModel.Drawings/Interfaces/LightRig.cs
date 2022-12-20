namespace DocumentModel.Drawings;

/// <summary>
/// Light Rig.
/// </summary>
public partial interface LightRig
{
  /// <summary>
  /// Rig Preset
  /// </summary>
  public DocumentModel.Drawings.LightRigKind? Rig { get; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public DocumentModel.Drawings.LightRigDirectionKind? Direction { get; set; }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public DocumentModel.Drawings.Rotation? Rotation { get; set; }
  
}
