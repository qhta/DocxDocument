namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Scene3D Class.
/// </summary>
public record Scene3D
{
  /// <summary>
  ///   Camera.
  /// </summary>
  public Camera? Camera { get; set; }

  /// <summary>
  ///   LightRig.
  /// </summary>
  public LightRig? LightRig { get; set; }
}