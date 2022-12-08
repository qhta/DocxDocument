namespace DocumentModel.Drawings;

/// <summary>
/// Camera.
/// </summary>
public interface Camera
{
  /// <summary>
  /// Preset Camera Type
  /// </summary>
  public PresetCameraKind? Preset { get ; set; }
  
  /// <summary>
  /// Field of View
  /// </summary>
  public Int32? FieldOfView { get ; set; }
  
  /// <summary>
  /// Zoom
  /// </summary>
  public Int32? Zoom { get ; set; }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public Rotation? Rotation { get ; set; }
  
}
