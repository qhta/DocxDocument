namespace DocumentModel.Drawing;

/// <summary>
/// Light Rig.
/// </summary>
public interface ILightRig // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Rig Preset
  /// </summary>
  public DocumentModel.Drawing.LightRigKind? Rig { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public DocumentModel.Drawing.LightRigDirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public DocumentModel.Drawing.IRotation? Rotation { get ; set; }
  
}
