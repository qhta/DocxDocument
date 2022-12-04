namespace DocumentModel.Drawings;

/// <summary>
/// Camera.
/// </summary>
public class Camera
{
  /// <summary>
  /// Preset Camera Type
  /// </summary>
  public PresetCameraKind? Preset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public Rotation? Rotation
  {
    get;
    set;
  }
  
}
