namespace DocumentModel.Drawings;

/// <summary>
/// Camera settings for 3D effects in drawing elements.
/// </summary>
public class Camera: ModelElement<DXD.Camera>
{
  /// <summary>
  /// Preset camera type.
  /// </summary>
  public PresetCameraKind? Preset { get; set; }

  /// <summary>
  /// Field of view.
  /// </summary>
  public Int32? FieldOfView { get; set; }

  /// <summary>
  /// Zoom factor.
  /// </summary>
  public Int32? Zoom { get; set; }

  /// <summary>
  /// Camera rotation.
  /// </summary>
  public Rotation? Rotation { get; set; }
}