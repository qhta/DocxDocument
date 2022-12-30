namespace DocumentModel.Drawings;

/// <summary>
/// Camera.
/// </summary>
public partial class Camera
{
  /// <summary>
  /// Preset Camera Type
  /// </summary>
  public DocumentModel.Drawings.PresetCameraKind? Preset { get; set; }
  
  /// <summary>
  /// Field of View
  /// </summary>
  public Int32? FieldOfView { get; set; }
  
  /// <summary>
  /// Zoom
  /// </summary>
  public Int32? Zoom { get; set; }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public DocumentModel.Drawings.Rotation? Rotation { get; set; }
  
}
