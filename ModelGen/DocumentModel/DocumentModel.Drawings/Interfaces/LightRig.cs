namespace DocumentModel.Drawings;

/// <summary>
/// Light Rig.
/// </summary>
public interface LightRig
{
  /// <summary>
  /// Rig Preset
  /// </summary>
  public LightRigKind? Rig { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public LightRigDirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public Rotation? Rotation { get ; set; }
  
}
