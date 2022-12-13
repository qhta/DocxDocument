namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Scene3D Class.
/// </summary>
public interface Scene3D
{
  /// <summary>
  /// Camera.
  /// </summary>
  public DocumentModel.Wordprocessing.Camera? Camera { get ; set; }
  
  /// <summary>
  /// LightRig.
  /// </summary>
  public DocumentModel.Wordprocessing.LightRig? LightRig { get ; set; }
  
}
