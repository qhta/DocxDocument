namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Scene3D Class.
/// </summary>
public interface IScene3D // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Camera.
  /// </summary>
  public DocumentModel.Wordprocessing.ICamera? Camera { get ; set; }
  
  /// <summary>
  /// LightRig.
  /// </summary>
  public DocumentModel.Wordprocessing.ILightRig? LightRig { get ; set; }
  
}
