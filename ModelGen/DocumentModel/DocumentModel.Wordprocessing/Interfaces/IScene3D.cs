namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Scene3D Class.
/// </summary>
public interface IScene3D // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Camera.
  /// </summary>
  public ICamera? Camera { get ; set; }
  
  /// <summary>
  /// LightRig.
  /// </summary>
  public ILightRig? LightRig { get ; set; }
  
}
