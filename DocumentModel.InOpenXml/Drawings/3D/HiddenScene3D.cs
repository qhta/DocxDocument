namespace DocumentModel.Drawings;

/// <summary>
///   Represents hidden 3D scene properties, including camera, lighting, and backdrop configuration.
/// </summary>
public class HiddenScene3D : ModelElement<DXO10D.HiddenScene3D>, IExtendableElement
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

  /// <summary>
  /// List of extension elements.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}