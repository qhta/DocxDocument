namespace DocumentModel.Drawings;

/// <summary>
///   Defines properties for a 3D scene, including camera, lighting, and backdrop configuration.
/// </summary>
public interface Scene3DType : IExtendableElement
{
  /// <summary>
  ///   Camera settings for the 3D scene.
  /// </summary>
  public Camera? Camera { get; set; }

  /// <summary>
  ///   Light rig configuration for the 3D scene.
  /// </summary>
  public LightRig? LightRig { get; set; }

  /// <summary>
  ///   Backdrop plane for the 3D scene.
  /// </summary>
  public Backdrop? Backdrop { get; set; }
}