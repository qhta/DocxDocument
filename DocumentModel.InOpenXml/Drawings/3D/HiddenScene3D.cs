namespace DocumentModel.Drawings;

/// <summary>
///   Represents hidden 3D scene properties, including camera, lighting, and backdrop configuration.
/// </summary>
public interface HiddenScene3D : IExtendableElement
{
  /// <summary>
  ///   Camera settings for the hidden 3D scene.
  /// </summary>
  public Camera? Camera { get; set; }

  /// <summary>
  ///   Light rig configuration for the hidden 3D scene.
  /// </summary>
  public LightRig? LightRig { get; set; }

  /// <summary>
  ///   Backdrop plane for the hidden 3D scene.
  /// </summary>
  public Backdrop? Backdrop { get; set; }
}