namespace DocumentModel.Drawing;

/// <summary>
/// Light Rig.
/// </summary>
public interface ILightRig // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Rig Preset
  /// </summary>
  public LightRigValues? Rig { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public LightRigDirectionValues? Direction { get ; set; }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public IRotation? Rotation { get ; set; }
  
}
