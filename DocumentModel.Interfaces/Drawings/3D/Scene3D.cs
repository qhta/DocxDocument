namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Represents a 3-D scene, including camera, lighting, backdrop, and extension information.
/// </summary>
public interface Scene3D: ExtendableElement
{
  /// <summary>
  ///   Camera settings for the 3-D scene.
  /// </summary>
  public Camera? Camera { get; set; }

  /// <summary>
  ///   Light rig configuration for the 3-D scene.
  /// </summary>
  public LightRig? LightRig { get; set; }

  /// <summary>
  ///   Backdrop plane for the 3-D scene.
  /// </summary>
  public Backdrop? Backdrop { get; set; }

}