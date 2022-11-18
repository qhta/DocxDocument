namespace DocumentModel.Drawing;

/// <summary>
/// Light Rig.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IRotation))]
public interface ILightRig // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Rig Preset
  /// </summary>
  public LightRig? Rig { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public DocumentModel.Drawing.LightRigDirection? Direction { get ; set; }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public IRotation? Rotation { get ; set; }
  
}
