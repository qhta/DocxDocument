namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Camera.
/// </summary>
public class Camera: ModelElement
{
  /// <summary>
  ///   Preset Camera Type
  /// </summary>
  public PresetCameraKind? Preset { get; set; }

  /// <summary>
  ///   Field of View
  /// </summary>
  public Int32? FieldOfView { get; set; }

  /// <summary>
  ///   Zoom
  /// </summary>
  public Int32? Zoom { get; set; }

  /// <summary>
  ///   Rotation.
  /// </summary>
  public Rotation? Rotation { get; set; }
}