namespace DocumentModel.Drawing;

/// <summary>
/// Light Rig.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IRotation))]
public class LightRig: ILightRig
{
  /// <summary>
  /// Rig Preset
  /// </summary>
  public LightRigValues? Rig
  {
    get;
    set;
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  public DocumentModel.Drawing.LightRigDirectionValues? Direction
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public IRotation? Rotation
  {
    get;
    set;
  }
  
}
