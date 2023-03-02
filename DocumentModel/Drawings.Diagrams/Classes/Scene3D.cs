namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   3-D Scene.
/// </summary>
public record Scene3D
{
  /// <summary>
  ///   Camera.
  /// </summary>
  public Camera? Camera { get; set; }

  /// <summary>
  ///   Light Rig.
  /// </summary>
  public LightRig? LightRig { get; set; }

  /// <summary>
  ///   Backdrop Plane.
  /// </summary>
  public Backdrop? Backdrop { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public Drawings.ExtensionList? ExtensionList { get; set; }
}