namespace DocumentModel.Drawing;

/// <summary>
/// Light Rig.
/// </summary>
public interface ILightRig // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public IRotation? Rotation { get ; set; }
  
}
