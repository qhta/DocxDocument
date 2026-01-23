namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Represents a 3-D scene, including camera, lighting, backdrop, and extension information.
/// </summary>
public class Scene3D: ModelElement<DXO10W.Scene3D>, IExtendableElement
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

  /// <summary>
  /// List of extension elements.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}